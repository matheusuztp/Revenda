using Bar.Forms;
using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Windows.Forms;

namespace Barzinho
{
    public partial class CadProduto : Form
    {
        Menu menu = new Menu();

        //MySqlConnection conexao;
        //string connectionString = ConfigurationManager.ConnectionStrings["MySQL"].ConnectionString;
        SqlConnection conexao;
        string connectionString = ConfigurationManager.ConnectionStrings["SQLServer"].ConnectionString;

        public CadProduto()
        {
            InitializeComponent();
            LimparTela();
            //conexao = new MySqlConnection(connectionString);
            conexao = new SqlConnection(connectionString);
        }

        private void radioBedida_CheckedChanged(object sender, EventArgs e)
        {
            if (radioBedida.Checked)
            {
                txtVolumeProduto.Enabled = labelVolume.Enabled = true;
                txtUnidadeProduto.Text = "Litros";
                txtUnidadeProduto.ReadOnly = true;
            }
            else
            {
                txtUnidadeProduto.Text = "";
                txtVolumeProduto.Text = "";
                txtValorProduto.Text = "";
                txtVolumeProduto.Enabled = labelVolume.Enabled = false;
                txtUnidadeProduto.ReadOnly = false;
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja fechar o cadastro de produto?", "Atenção.", MessageBoxButtons.YesNo) == DialogResult.Yes)
                this.Close();
        }

        private void LimparTela()
        {
            txtCodigoProduto.Text = "0";
            txtDescricaoProduto.Text = txtEstoqueProduto.Text = txtValorProduto.Text = txtVolumeProduto.Text = txtUnidadeProduto.Text = "";
            radioBedida.Checked = true;
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtDescricaoProduto.Text)
                || !string.IsNullOrEmpty(txtEstoqueProduto.Text)
                || !string.IsNullOrEmpty(txtValorProduto.Text)
                || !string.IsNullOrEmpty(txtVolumeProduto.Text))
            {
                if (radioBedida.Checked)
                {
                    if (MessageBox.Show("Alterações da tela serão excluídas", "Atenção", MessageBoxButtons.OKCancel) == DialogResult.OK)
                        LimparTela();
                }
                else
                {
                    if (!string.IsNullOrEmpty(txtUnidadeProduto.Text))
                        if (MessageBox.Show("Alterações da tela serão excluídas", "Atenção", MessageBoxButtons.OKCancel) == DialogResult.OK)
                            LimparTela();
                }
            }
        }

        private void CadProduto_Load(object sender, EventArgs e)
        {
            if (radioBedida.Checked)
            {
                txtUnidadeProduto.Text = "Litros";
                labelVolume.Enabled = txtVolumeProduto.Enabled = true;
            }
        }

        public static bool verificaNumeros(string number)
        {
            foreach (char c in number)
            {
                if (c >= '0' && c <= '9')
                {
                    return true;
                }
            }
            return false;
        }

        private void btnGravar_Click(object sender, EventArgs e)
        {
            if (txtCodigoProduto.Text == "0")
            {
                if (string.IsNullOrEmpty(txtDescricaoProduto.Text))
                {
                    MessageBox.Show("Preencha a descrição.");
                    return;
                }
                else if (string.IsNullOrEmpty(txtValorProduto.Text))
                {
                    MessageBox.Show("Preencha o valor.");
                    return;
                }
                else if (string.IsNullOrEmpty(txtUnidadeProduto.Text))
                {
                    MessageBox.Show("Preencha a unidade.");
                    return;
                }
                else if (string.IsNullOrEmpty(txtEstoqueProduto.Text))
                {
                    MessageBox.Show("Preencha o saldo em estoque.");
                    return;
                }
                else if (string.IsNullOrEmpty(txtVolumeProduto.Text) && radioBedida.Checked)
                {
                    MessageBox.Show("Preencha o volume da bebida.");
                    return;
                }
                else
                {
                    string descricao = txtDescricaoProduto.Text;
                    string valor = txtValorProduto.Text;
                    string unidade = txtUnidadeProduto.Text;
                    string tipo = retornaTipo();
                    string volume = "";
                    if (tipo == "B")
                        volume = txtVolumeProduto.Text;
                    string estoque = txtEstoqueProduto.Text;

                    if (valor.Contains(','))
                        valor = valor.Replace(',', '.');

                    if (volume.Contains(','))
                        volume = volume.Replace(',', '.');

                    if (string.IsNullOrEmpty(txtVolumeProduto.Text))
                        volume = "null";

                    try
                    {
                        string sql = $@"insert into produto(descricao, unidade, volume, valor, saldoEstoque, tipo)
                               values('{descricao}','{unidade}',{volume}, {valor}, {estoque}, '{tipo}');";

                        //MySqlCommand comando = new MySqlCommand(sql, conexao);
                        SqlCommand cmd = new SqlCommand(sql, conexao);

                        conexao.Open();

                        //comando.ExecuteReader();
                        cmd.ExecuteReader();

                        MessageBox.Show("Produto registrado!", "Sucesso", MessageBoxButtons.OK);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Erro ao registrar o novo produto: " + ex.Message, "Erro.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    finally
                    {
                        conexao.Close();
                    }
                    LimparTela();
                }
            }
            else
            {
                string sql = $"select id, descricao, unidade, volume, valor, saldoEstoque, tipo from produto where id = {int.Parse(txtCodigoProduto.Text)}";

                try
                {
                    conexao.Open();

                    //MySqlCommand comando = new MySqlCommand(sql, conexao);
                    SqlCommand comando = new SqlCommand(sql, conexao);

                    //MySqlDataReader reader = comando.ExecuteReader();
                    SqlDataReader reader = comando.ExecuteReader();

                    var id = "";
                    var descricao = "";
                    var tipo = "";
                    var unidade = "";
                    var volume = "";
                    var valor = "";
                    var estoque = "";

                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            id = reader["id"].ToString();
                            descricao = reader["descricao"].ToString();
                            tipo = reader["tipo"].ToString();
                            unidade = reader["unidade"].ToString();
                            volume = reader["volume"].ToString();
                            valor = reader["valor"].ToString();
                            estoque = reader["saldoEstoque"].ToString();
                        }
                    }

                    if (txtDescricaoProduto.Text != descricao
                        || txtUnidadeProduto.Text != unidade
                        || txtValorProduto.Text != valor
                        || txtVolumeProduto.Text != volume
                        || txtEstoqueProduto.Text != estoque
                        || retornaTipo() != tipo)
                    {
                        conexao.Close();
                        if (MessageBox.Show("Deseja alterar o cadastro?", "Atenção.", MessageBoxButtons.YesNo) == DialogResult.Yes)
                        {
                            conexao.Open();

                            var novoVolume = txtVolumeProduto.Text;

                            if (string.IsNullOrEmpty(novoVolume))
                                novoVolume = "null";

                            if (novoVolume.Contains(','))
                                novoVolume = novoVolume.Replace(',', '.');

                            var novoValor = txtValorProduto.Text;
                            if (novoValor.Contains(','))
                                novoValor = novoValor.Replace(',', '.');

                            string update = $@"update produto set 
                                                descricao = '{txtDescricaoProduto.Text}',
                                                unidade = '{txtUnidadeProduto.Text}',
                                                volume = {novoVolume},
                                                valor = {novoValor},
                                                saldoEstoque = {txtEstoqueProduto.Text},
                                                tipo = '{retornaTipo()}'
                                               where id = {txtCodigoProduto.Text}";

                            //comando = new MySqlCommand(update, conexao);
                            comando = new SqlCommand(update, conexao);

                            comando.ExecuteReader();

                            MessageBox.Show("Registro alterado.");
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao resgatar dados do banco: " + ex.Message, "Erro.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    conexao.Close();
                }
            }
        }

        private void txtEstoqueProduto_Leave(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtEstoqueProduto.Text))
            {
                if (!verificaNumeros(txtEstoqueProduto.Text))
                {
                    MessageBox.Show("Preencha somente números!");
                    txtEstoqueProduto.Text = "";
                    txtEstoqueProduto.Focus();
                    return;
                }
            }
        }

        private void txtVolumeProduto_Leave(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtVolumeProduto.Text))
            {
                if (!verificaNumeros(txtVolumeProduto.Text))
                {
                    MessageBox.Show("Preencha somente números!");
                    txtVolumeProduto.Text = "";
                    txtVolumeProduto.Focus();
                    return;
                }
            }
        }

        private void txtValorProduto_Leave(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtValorProduto.Text))
            {
                if (!verificaNumeros(txtValorProduto.Text))
                {
                    MessageBox.Show("Preencha somente números!");
                    txtValorProduto.Text = "";
                    txtValorProduto.Focus();
                    return;
                }
            }
        }

        private string retornaTipo()
        {
            if (radioBedida.Checked)
                return "B";
            else if (radioDoce.Checked)
                return "D";
            else
                return "P";
        }

        private void btnConsulta_Click(object sender, EventArgs e)
        {
            DataTable dtProduto = new DataTable();

            SuperConsulta consulta = new SuperConsulta();

            consulta.CarregaConsulta("produto");

            consulta.ShowDialog();

            string consultaID = consulta.BuscaRetorno();

            if (!string.IsNullOrEmpty(consultaID))
            {
                string sql = $"select id, descricao, unidade, volume, valor, saldoEstoque, tipo from produto where id = {int.Parse(consultaID)}";

                try
                {
                    conexao.Open();

                    //MySqlCommand comando = new MySqlCommand(sql, conexao);
                    SqlCommand comando = new SqlCommand(sql, conexao);

                    //MySqlDataReader reader = comando.ExecuteReader();
                    SqlDataReader reader = comando.ExecuteReader();

                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            txtCodigoProduto.Text = reader["id"].ToString();
                            txtDescricaoProduto.Text = reader["descricao"].ToString();

                            if (reader["tipo"].ToString() == "B")
                                radioBedida.Checked = true;
                            else if (reader["tipo"].ToString() == "D")
                                radioDoce.Checked = true;
                            else
                                radioPetisco.Checked = true;

                            txtUnidadeProduto.Text = reader["unidade"].ToString();
                            txtVolumeProduto.Text = reader["volume"].ToString();
                            txtValorProduto.Text = reader["valor"].ToString();
                            txtEstoqueProduto.Text = reader["saldoEstoque"].ToString();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Produto não encontrado.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao executar consulta: " + ex.Message, "Erro.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    conexao.Close();
                }
            }//
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtCodigoProduto.Text)
                || txtCodigoProduto.Text == "0")
                MessageBox.Show("Consulte 1 produto primeiro.");
            else
            {
                try
                {
                    string sql = $"delete from produto where id = {int.Parse(txtCodigoProduto.Text)}";

                    //MySqlCommand comando = new MySqlCommand(sql, conexao);
                    SqlCommand cmd = new SqlCommand(sql, conexao);

                    conexao.Open();

                    cmd.ExecuteReader();

                    MessageBox.Show("Registro excluído");
                    LimparTela();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao excluir registro: " + ex.Message);
                }
                finally
                {
                    conexao.Close();
                }
            }
        }
    }
}
