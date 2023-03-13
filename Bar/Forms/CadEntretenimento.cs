using Bar.Forms;
using System;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Windows.Forms;

namespace Barzinho
{
    public partial class CadEntretenimento : Form
    {
        Menu menu = new Menu();

        //MySqlConnection conexao;
        //string connectionString = ConfigurationManager.ConnectionStrings["MySQL"].ConnectionString;
        SqlConnection conexao;
        string connectionString = ConfigurationManager.ConnectionStrings["SQLServer"].ConnectionString;

        public CadEntretenimento()
        {
            InitializeComponent();
            limparTela();
            //conexao = new MySqlConnection(connectionString);
            conexao = new SqlConnection(connectionString);
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja fechar o cadastro de entretenimento?", "Atenção.", MessageBoxButtons.YesNo) == DialogResult.Yes)
                this.Close();
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtDescricaoEntretenimento.Text)
                || !string.IsNullOrEmpty(txtTempo.Text)
                || !string.IsNullOrEmpty(txtValorEntretenimento.Text))
            {
                if (MessageBox.Show("Alterações na tela serão excluídas", "Atenção.", MessageBoxButtons.OKCancel) == DialogResult.OK)
                    limparTela();
            }
            else
            {
                limparTela();
            }
        }

        private void limparTela()
        {
            txtCodigoEntretenimento.Text = "0";
            txtDescricaoEntretenimento.Text = txtTempo.Text = txtValorEntretenimento.Text = "";
            cbTempo.Checked = false;
        }

        private void cbTempo_CheckedChanged(object sender, EventArgs e)
        {
            if (cbTempo.Checked)
                labelTempo.Enabled = txtTempo.Enabled = labelMinutos.Enabled = true;
            else
            {
                labelTempo.Enabled = txtTempo.Enabled = labelMinutos.Enabled = false;
                txtTempo.Text = "";
            }
        }

        private void CadEntretenimento_Load(object sender, EventArgs e)
        {
            txtTempo.Enabled = labelTempo.Enabled = labelMinutos.Enabled = false;
        }

        private void btnGravar_Click(object sender, EventArgs e)
        {
            if (txtCodigoEntretenimento.Text == "0")
            {
                if (string.IsNullOrEmpty(txtDescricaoEntretenimento.Text))
                {
                    MessageBox.Show("Preencha a descrição.");
                    return;
                }
                else if (string.IsNullOrEmpty(txtValorEntretenimento.Text))
                {
                    MessageBox.Show("Preencha o valor.");
                    return;
                }
                else
                {
                    var descricao = txtDescricaoEntretenimento.Text;
                    var tempo = txtTempo.Text;
                    var valor = txtValorEntretenimento.Text;

                    if (string.IsNullOrEmpty(tempo))
                        tempo = "null";
                    if (valor.Contains(','))
                        valor = valor.Replace(',', '.');

                    try
                    {
                        string sql = $@"insert into entretenimento (descricao, tempo, valor)
                               values('{descricao}',{tempo},{valor});";

                        //MySqlCommand comando = new MySqlCommand(sql, conexao);
                        SqlCommand comando = new SqlCommand(sql, conexao);

                        conexao.Open();

                        comando.ExecuteReader();

                        MessageBox.Show("Entretenimento registrado!", "Sucesso", MessageBoxButtons.OK);
                        limparTela();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Erro ao registrar o novo entretenimento: " + ex.Message, "Erro.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    finally
                    {
                        conexao.Close();
                    }
                }
            }
            else
            {
                string sql = $"select id,descricao, tempo, valor from entretenimento where id = {int.Parse(txtCodigoEntretenimento.Text)}";

                try
                {
                    conexao.Open();

                    //MySqlCommand comando = new MySqlCommand(sql, conexao);
                    SqlCommand comando = new SqlCommand(sql, conexao);

                    //MySqlDataReader reader = comando.ExecuteReader();
                    SqlDataReader reader = comando.ExecuteReader();

                    var descricao = "";
                    var tempo = "";
                    var valor = "";

                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            descricao = reader["descricao"].ToString();
                            tempo = reader["tempo"].ToString();
                            valor = reader["valor"].ToString();
                        }
                    }

                    if (txtDescricaoEntretenimento.Text != descricao
                        || txtTempo.Text != tempo
                        || txtValorEntretenimento.Text != valor)
                    {
                        conexao.Close();
                        if (MessageBox.Show("Deseja alterar o cadastro?", "Atenção.", MessageBoxButtons.YesNo) == DialogResult.Yes)
                        {
                            conexao.Open();

                            var novoValor = txtValorEntretenimento.Text;
                            var novoTempo = txtTempo.Text;

                            if (novoValor.Contains(','))
                                novoValor = novoValor.Replace(',', '.');

                            if (string.IsNullOrEmpty(novoTempo))
                                novoTempo = "null";

                            string update = $@"update entretenimento set 
                                                descricao = '{txtDescricaoEntretenimento.Text}',
                                                tempo = {novoTempo},
                                                valor = {novoValor}
                                               where id = {txtCodigoEntretenimento.Text}";

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

        private void btnConsulta_Click(object sender, EventArgs e)
        {
            SuperConsulta consulta = new SuperConsulta();

            consulta.CarregaConsulta("entretenimento");

            consulta.ShowDialog();

            string consultaID = consulta.BuscaRetorno();

            if (!string.IsNullOrEmpty(consultaID))
            {
                string sql = $"select id, descricao, tempo, valor from entretenimento where id = {int.Parse(consultaID)}";

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
                            txtCodigoEntretenimento.Text = reader["id"].ToString();
                            txtDescricaoEntretenimento.Text = reader["descricao"].ToString();
                            txtTempo.Text = reader["tempo"].ToString();
                            txtValorEntretenimento.Text = reader["valor"].ToString();
                        }
                        if (!string.IsNullOrEmpty(txtTempo.Text))
                            cbTempo.Checked = true;
                    }
                    else
                    {
                        MessageBox.Show("Entretenimento não encontrado.");
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
            if (string.IsNullOrEmpty(txtCodigoEntretenimento.Text)
                || txtCodigoEntretenimento.Text == "0")
                MessageBox.Show("Consulte 1 entretenimento primeiro.");
            else
            {
                try
                {
                    string sql = $"delete from entretenimento where id = {int.Parse(txtCodigoEntretenimento.Text)}";

                    //MySqlCommand cmd = new MySqlCommand(sql, conexao);
                    SqlCommand cmd = new SqlCommand(sql, conexao);

                    conexao.Open();

                    cmd.ExecuteReader();

                    MessageBox.Show("Registro excluído");
                    limparTela();
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
