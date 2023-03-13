using Bar.Forms;
using System;
using System.Configuration;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Barzinho
{
    public partial class CadCliente : Form
    {
        Menu menu = new Menu();

        //MySqlConnection conexao;
        //string connectionString = ConfigurationManager.ConnectionStrings["MySQL"].ConnectionString;
        SqlConnection conexao;
        string connectionString = ConfigurationManager.ConnectionStrings["SQLServer"].ConnectionString;

        public CadCliente()
        {
            InitializeComponent();
            LimparTela();
            //conexao = new MySqlConnection(connectionString);
            conexao = new SqlConnection(connectionString);
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja sair do cadastro de cliente?", "Atenção", MessageBoxButtons.YesNo) == DialogResult.Yes)
                this.Close();
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtNomeCliente.Text)
                || !string.IsNullOrEmpty(txtNomeCliente.Text)
                || !string.IsNullOrEmpty(txtRecordeCliente.Text))
            {
                if (MessageBox.Show("Alterações da tela serão excluídas", "Atenção", MessageBoxButtons.OKCancel) == DialogResult.OK)
                    LimparTela();
            }
            else
                LimparTela();
        }

        private void LimparTela()
        {
            txtNomeCliente.Text = "";
            txtCodigoCliente.Text = "0";
            txtRecordeCliente.Text = "";
            txtIdade.Text = "";
        }

        private void btnConsultaCliente_Click(object sender, EventArgs e)
        {
            SuperConsulta consulta = new SuperConsulta();

            consulta.CarregaConsulta("cliente");

            consulta.ShowDialog();

            string consultaID = consulta.BuscaRetorno();

            if (!string.IsNullOrEmpty(consultaID))
            {
                string sql = $"select id,nome, idade, recorde from cliente where id = {int.Parse(consultaID)}";
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
                            txtCodigoCliente.Text = reader["id"].ToString();
                            txtNomeCliente.Text = reader["nome"].ToString();
                            txtIdade.Text = reader["idade"].ToString();
                            txtRecordeCliente.Text = reader["recorde"].ToString();
                        }
                    }
                    else
                        MessageBox.Show("Cliente não encontrado.");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao executar consulta: " + ex.Message, "Erro.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    conexao.Close();
                }
            }
        }

        private void btnGravar_Click(object sender, EventArgs e)
        {
            if (txtCodigoCliente.Text == "0")
            {
                if (string.IsNullOrEmpty(txtNomeCliente.Text))
                {
                    MessageBox.Show("Preencha o nome.");
                    return;
                }
                else
                {
                    string nome = txtNomeCliente.Text;
                    int recorde = 0;
                    int idade = 0;
                    if (!string.IsNullOrEmpty(txtRecordeCliente.Text))
                        recorde = int.Parse(txtRecordeCliente.Text);

                    if (!string.IsNullOrEmpty(txtIdade.Text))
                        idade = int.Parse(txtIdade.Text);

                    try
                    {
                        string sql = $@"insert into cliente(nome, idade, recorde)
                               values('{nome}',{idade},{recorde});";

                        //MySqlCommand comando = new MySqlCommand(sql, conexao);
                        SqlCommand comando = new SqlCommand(sql, conexao);

                        conexao.Open();

                        comando.ExecuteReader();

                        MessageBox.Show("Cliente registrado!", "Sucesso", MessageBoxButtons.OK);
                        LimparTela();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Erro ao registrar o novo cliente: " + ex.Message, "Erro.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    finally
                    {
                        conexao.Close();
                    }
                }
            }
            else
            {
                string sql = $"select id,nome, idade, recorde from cliente where id = {int.Parse(txtCodigoCliente.Text)}";

                try
                {
                    conexao.Open();

                    //MySqlCommand comando = new MySqlCommand(sql, conexao);
                    SqlCommand comando = new SqlCommand(sql, conexao);

                    //MySqlDataReader reader = comando.ExecuteReader();
                    SqlDataReader reader = comando.ExecuteReader();

                    var nome = "";
                    var idade = "";
                    var recorde = "";

                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            nome = reader["nome"].ToString();
                            idade = reader["idade"].ToString();
                            recorde = reader["recorde"].ToString();
                        }
                    }

                    if (txtNomeCliente.Text != nome
                        || txtIdade.Text != idade
                        || txtRecordeCliente.Text != recorde)
                    {
                        conexao.Close();
                        if (MessageBox.Show("Deseja alterar o cadastro?", "Atenção.", MessageBoxButtons.YesNo) == DialogResult.Yes)
                        {
                            conexao.Open();


                            string update = $@"update cliente set 
                                                nome = '{txtNomeCliente.Text}',
                                                idade = {txtIdade.Text},
                                                recorde = {txtRecordeCliente.Text}
                                               where id = {txtCodigoCliente.Text}";

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

        private void txtRecordeCliente_Leave(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtRecordeCliente.Text))
            {
                if (!verificaNumeros(txtRecordeCliente.Text))
                {
                    MessageBox.Show("Preencha somente números!");
                    txtRecordeCliente.Text = "";
                    txtRecordeCliente.Focus();
                    return;
                }
            }
        }

        private void textIdade_Leave(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtIdade.Text))
            {
                if (!verificaNumeros(txtIdade.Text))
                {
                    MessageBox.Show("Preencha somente números!");
                    txtIdade.Text = "";
                    txtIdade.Focus();
                    return;
                }
            }
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtCodigoCliente.Text)
                || txtCodigoCliente.Text == "0")
                MessageBox.Show("Consulte 1 cliente primeiro.");
            else
            {
                if (validaVendaExistente())
                {
                    MessageBox.Show("Operação não disponível! Cliente possui vendas registradas.", "Atenção");
                    return;
                }
                else
                {
                    try
                    {
                        string sql = $"delete from cliente where id = {int.Parse(txtCodigoCliente.Text)}";

                        //MySqlCommand cmd = new MySqlCommand(sql, conexao);
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

        private bool validaVendaExistente()
        {
            string sql = $"select * from venda where clienteID = {txtCodigoCliente.Text}";

            var temVenda = false;

            try
            {
                conexao.Open();

                //MySqlCommand comando = new MySqlCommand(sql, conexao);
                SqlCommand comando = new SqlCommand(sql, conexao);

                //MySqlDataReader reader = comando.ExecuteReader();
                SqlDataReader reader = comando.ExecuteReader();

                if (reader.HasRows)
                    temVenda = true;
                else
                    temVenda = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao validar vendas do cliente: "+ex.Message, "Erro");
            }
            finally
            {
                conexao.Close();
            }

            return temVenda;
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

    }
}
