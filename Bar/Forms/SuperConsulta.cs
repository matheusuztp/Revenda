using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Bar.Forms
{
    public partial class SuperConsulta : Form
    {
        SqlConnection conexao;
        string connectionString = ConfigurationManager.ConnectionStrings["SQLServer"].ConnectionString;
        string _tabela = "";
        string consultaID = "";
        string colunas = string.Empty;

        public SuperConsulta()
        {
            InitializeComponent();
            conexao = new SqlConnection(connectionString);
        }

        public void CarregaConsulta(string tabela)
        {
            lblMensagem.Text = $"Pesquisar {tabela}:";
            CarregaFiltros(tabela);
            _tabela = tabela;
            cmbFiltro.SelectedIndex = 0;
            cmbOrdem.SelectedIndex = 0;
        }
        public void CarregaFiltros(string tabela)
        {
            DataTable combo = new DataTable();

            switch (tabela)
            {
                case "venda":
                    colunas = $@"SELECT case COLUMN_NAME WHEN 'numero' then 'Número da Venda' 
	                                       when'clienteID' then 'Número do Cliente'
	                                       when 'observacao' then 'Observação'
	                                       when 'total' then 'Total da Venda'
	                                       else ''
	                                    end colunas
                                    FROM INFORMATION_SCHEMA.COLUMNS
                                    WHERE TABLE_NAME = '{tabela}'";
                    break;
                case "produto":
                    colunas = $@"SELECT case COLUMN_NAME WHEN 'id' then 'Número do Produto' 
	                                       when'descricao' then 'Descrição'
	                                       when 'valor' then 'Preço'
	                                       when 'saldoEstoque' then 'Quantidade em estoque'
	                                       when 'tipo' then 'Tipo de produto'
	                                       when 'unidade' then 'Unidade'
	                                       when 'volume' then 'Volume'
	                                       else ''
	                                    end colunas
                                    FROM INFORMATION_SCHEMA.COLUMNS
                                    WHERE TABLE_NAME = '{tabela}'";
                    break;
                case "entretenimento":
                    colunas = $@"SELECT case COLUMN_NAME WHEN 'id' then 'Número do Entretenimento' 
	                                       when'descricao' then 'Descrição'
	                                       when 'valor' then 'Preço da ficha'
	                                       when 'tempo' then 'Tempo da ficha'
	                                       else ''
	                                    end colunas
                                    FROM INFORMATION_SCHEMA.COLUMNS
                                    WHERE TABLE_NAME = '{tabela}'";
                    break;
                case "cliente":
                    colunas = $@"SELECT case COLUMN_NAME WHEN 'id' then 'Número do Cliente' 
	                                       when'nome' then 'Nome'
	                                       when 'idade' then 'Idade'
	                                       when 'recorde' then 'Recorde de Doses'
	                                       else ''
	                                    end colunas
                                    FROM INFORMATION_SCHEMA.COLUMNS
                                    WHERE TABLE_NAME = '{tabela}'";
                    break;
            }

            try
            {
                conexao.Open();

                SqlDataAdapter daCombo = new SqlDataAdapter(colunas, conexao);

                daCombo.Fill(combo);
                cmbFiltro.Items.Clear();
                for (int i = 0; i < combo.Rows.Count; i++)
                    cmbFiltro.Items.Add(combo.Rows[i]["colunas"].ToString());

            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao gerar filtros: " + ex.Message, "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                conexao.Close();
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja fechar a consulta?", "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                this.Close();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            string ordem = "";

            if (cmbOrdem.SelectedIndex > 0)
            {
                if (cmbOrdem.SelectedIndex == 1)
                    ordem = $" order by {cmbFiltro.SelectedItem.ToString()} asc ";
                else
                    ordem = $" order by {cmbFiltro.SelectedItem.ToString()} desc ";
            }

            string busca = "";

            if (string.IsNullOrEmpty(txtConsulta.Text))
            {
                if (MessageBox.Show("Pesquisar por tudo?", "Atenção", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    busca = $" select * from {_tabela} {ordem}";
                else
                    busca = "";
            }
            else
            {
                busca = $"select * from {_tabela} where {cmbFiltro.SelectedItem.ToString()} like '{txtConsulta.Text}' {ordem}";
            }

            if (!string.IsNullOrEmpty(busca))
            {
                try
                {
                    conexao.Open();

                    SqlDataAdapter daConsulta = new SqlDataAdapter(busca, conexao);

                    DataTable dtConsulta = new DataTable();

                    daConsulta.Fill(dtConsulta);

                    if (dtConsulta.Rows.Count == 0)
                    {
                        MessageBox.Show($"Nenhum {_tabela} encontrado", "Atenção", MessageBoxButtons.OK);
                        return;
                    }

                    dgConsulta.DataSource = dtConsulta;
                    EditarColunas(colunas);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Erro ao consultar os dados de: {_tabela} - " + ex.Message, "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    conexao.Close();
                }
            }
        }

        private void EditarColunas(string colunas)
        {
            DataTable dtColunas = new DataTable();

            try
            {
                SqlDataAdapter daCombo = new SqlDataAdapter(colunas, conexao);

                daCombo.Fill(dtColunas);
                cmbFiltro.Items.Clear();
                var i = 0;
                foreach (DataGridViewColumn columnTabela in dgConsulta.Columns)
                {
                    if (i > dgConsulta.Rows.Count)
                        return;

                    columnTabela.HeaderText = dtColunas.Rows[i]["colunas"].ToString();
                    columnTabela.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                    i++;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao alterar colunas: " + ex.Message, "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        public string BuscaRetorno()
        {
            return consultaID;
        }

        private void dgConsulta_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            consultaID = dgConsulta.SelectedRows[0].Cells[0].Value.ToString();
            this.Close();
        }

        private void dgConsulta_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            consultaID = dgConsulta.SelectedRows[0].Cells[0].Value.ToString();
            this.Close();
        }
    }

}
