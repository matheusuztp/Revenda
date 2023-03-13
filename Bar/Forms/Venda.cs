using Bar.Forms;
using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Windows.Forms;

namespace Barzinho
{
    public partial class Venda : Form
    {
        Menu menu = new Menu();

        //MySqlConnection conexao;
        //string connectionString = ConfigurationManager.ConnectionStrings["MySQL"].ConnectionString;
        SqlConnection conexao;
        string connectionString = ConfigurationManager.ConnectionStrings["SQLServer"].ConnectionString;
        DataTable dtProdutos = new DataTable();

        public Venda()
        {
            InitializeComponent();
            LimparTela();
            //conexao = new MySqlConnection(connectionString);
            conexao = new SqlConnection(connectionString);
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja sair da tela de vendas?", "Atenção.", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtClienteVenda.Text))
            {
                if (dgProdutos.Rows.Count > 0 || dgEntretenimento.Rows.Count > 0)
                {
                    if (MessageBox.Show("Desistir da venda e apagar os valores da tela?", "Atenção.", MessageBoxButtons.YesNo) == DialogResult.Yes)
                        LimparTela();
                }
                else
                {
                    if (MessageBox.Show("Alterações da tela serão excluídas", "Atenção", MessageBoxButtons.OKCancel) == DialogResult.OK)
                        LimparTela();
                }
            }
            else
                LimparTela();
        }

        public void LimparTela()
        {
            txtClienteVenda.Text = "";
            txtNomeClienteVenda.Text = "";
            txtProdutoVenda.Text = "";
            txtQuantidadeProdutoVenda.Text = "";
            txtValorProdutoVenda.Text = "";
            txtEntretenimento.Text = "";
            txtQuantidadeEntretenimento.Text = "";
            txtValorEntretenimento.Text = "";
            txtPedidoNumero.Text = "0";
            txtTotal.Text = "";
            txtObservacao.Text = "";

            dgProdutos.DataSource = null; //Remover a datasource
            dgProdutos.Columns.Clear(); //Remover as colunas
            dgProdutos.Rows.Clear();    //Remover as linhas
            dgProdutos.Refresh();

            dgEntretenimento.DataSource = null; //Remover a datasource
            dgEntretenimento.Columns.Clear(); //Remover as colunas
            dgEntretenimento.Rows.Clear();    //Remover as linhas
            dgEntretenimento.Refresh();
        }

        private void btnConsultaCliente_Click(object sender, EventArgs e)
        {
            SuperConsulta consulta = new SuperConsulta();

            consulta.CarregaConsulta("cliente");

            consulta.ShowDialog();

            string consultaID = consulta.BuscaRetorno();

            if (!string.IsNullOrEmpty(consultaID))
            {
                try
                {
                    string sql = $"select id, nome from cliente where id = {consultaID}";

                    //MySqlCommand cmd = new MySqlCommand(sql, conexao);
                    SqlCommand cmd = new SqlCommand(sql, conexao);

                    conexao.Open();

                    //MySqlDataReader reader = cmd.ExecuteReader();
                    SqlDataReader reader = cmd.ExecuteReader();

                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            txtClienteVenda.Text = reader["id"].ToString();
                            txtNomeClienteVenda.Text = reader["Nome"].ToString();
                        }
                    }
                    else
                        MessageBox.Show("Cliente não encontrado.");

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao consultar cliente: " + ex.Message);
                }
                finally
                {
                    conexao.Close();
                }
            }
        }

        private void btnConsultaProduto_Click(object sender, EventArgs e)
        {
            SuperConsulta consulta = new SuperConsulta();

            consulta.CarregaConsulta("produto");

            consulta.ShowDialog();

            string consultaID = consulta.BuscaRetorno();

            if (!string.IsNullOrEmpty(consultaID))
            {
                try
                {
                    string sql = $"select id, descricao, valor from produto where id = {consultaID}";

                    //MySqlCommand cmd = new MySqlCommand(sql, conexao);
                    SqlCommand cmd = new SqlCommand(sql, conexao);

                    conexao.Open();

                    //MySqlDataReader reader = cmd.ExecuteReader();
                    SqlDataReader reader = cmd.ExecuteReader();

                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            txtProdutoVenda.Text = reader["id"].ToString();
                            labelNomeProduto.Text = reader["descricao"].ToString();
                            txtQuantidadeProdutoVenda.Text = "0";
                            txtValorProdutoVenda.Text = reader["valor"].ToString();
                        }
                        txtQuantidadeProdutoVenda.Focus();
                    }
                    else
                        MessageBox.Show("Produto não encontrado.");

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao consultar produto: " + ex.Message);
                }
                finally
                {
                    conexao.Close();
                }
            }
        }

        private void btnConsultaEntretenimento_Click(object sender, EventArgs e)
        {
            SuperConsulta consulta = new SuperConsulta();

            consulta.CarregaConsulta("entretenimento");

            consulta.ShowDialog();

            string consultaID = consulta.BuscaRetorno();

            if (!string.IsNullOrEmpty(consultaID))
            {
                try
                {
                    string sql = $"select id, descricao, valor from entretenimento where id = {consultaID}";

                    //MySqlCommand cmd = new MySqlCommand(sql, conexao);
                    SqlCommand cmd = new SqlCommand(sql, conexao);

                    conexao.Open();

                    //MySqlDataReader reader = cmd.ExecuteReader();
                    SqlDataReader reader = cmd.ExecuteReader();

                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            txtEntretenimento.Text = reader["id"].ToString();
                            labelEntretenimentoNome.Text = reader["descricao"].ToString();
                            txtQuantidadeEntretenimento.Text = "0";
                            txtValorEntretenimento.Text = reader["valor"].ToString();
                        }
                        txtQuantidadeEntretenimento.Focus();
                    }
                    else
                        MessageBox.Show("Entretenimento não encontrado.");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao consultar entretenimento: " + ex.Message);
                }
                finally
                {
                    conexao.Close();
                }
            }
        }

        private void btnInserirProduto_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtProdutoVenda.Text)
                || txtProdutoVenda.Text == "0")
            {
                MessageBox.Show("Consulte um produto primeiro.");
                return;
            }
            else if (txtQuantidadeProdutoVenda.Text == "0")
            {
                MessageBox.Show("Defina a quantidade de itens para inserir");
                return;
            }
            else
            {
                if (string.IsNullOrEmpty(txtPedidoNumero.Text)
                    || txtPedidoNumero.Text == "0")
                    btnGravar_Click(sender, e);

                for (int i = 0; i < dgProdutos.Rows.Count; i++)
                {
                    if (dgProdutos.Rows[i].Cells["produto"].Value.ToString() == txtProdutoVenda.Text)
                    {
                        if (MessageBox.Show("Produto já inserido! Deseja somar quantidades?", "Atenção", MessageBoxButtons.YesNo) == DialogResult.Yes)
                        {
                            try
                            {
                                var quantidade = int.Parse(txtQuantidadeProdutoVenda.Text);
                                var quantidadeBanco = int.Parse(dgProdutos.Rows[i].Cells["quantidade"].Value.ToString());
                                var total = quantidade + quantidadeBanco;

                                string updatesql = $" update vendaItens set quantidade = {total} where vendaID = {txtPedidoNumero.Text} and produtoID = {txtProdutoVenda.Text}";


                                conexao.Open();
                                //MySqlCommand cmd = new MySqlCommand(updatesql, conexao);
                                SqlCommand cmd = new SqlCommand(updatesql, conexao);
                                cmd.ExecuteReader();

                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show("Erro ao somar quantidades: "+ex.Message);
                            }
                            finally
                            {
                                conexao.Close();
                            }
                        }
                        atualizaGradeProduto();
                        somartotais();
                        return;
                    }
                }

                var valor = txtValorProdutoVenda.Text;

                if (valor.Contains(','))
                    valor = valor.Replace(',', '.');

                string sql = $@"insert into vendaItens (vendaID, produtoID, quantidade, valorProduto, tipo)
                                values({txtPedidoNumero.Text}, {txtProdutoVenda.Text}, {txtQuantidadeProdutoVenda.Text}, {valor}, 'P')";

                try
                {
                    conexao.Open();

                    //MySqlCommand cmd = new MySqlCommand(sql, conexao);
                    SqlCommand cmd = new SqlCommand(sql, conexao);

                    cmd.ExecuteReader();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao inserir produto na grade: " + ex.Message);
                }
                finally
                {
                    conexao.Close();
                }
                atualizaGradeProduto();
            }
            somartotais();
        }

        private void atualizaGradeProduto()
        {
            txtProdutoVenda.Text = "";
            labelNomeProduto.Text = "";
            txtQuantidadeProdutoVenda.Text = "";
            txtValorProdutoVenda.Text = "";

            string sql = $"select vendaID Pedido, produtoID Produto, descricao 'Descrição', quantidade Quantidade, valorProduto Valor from vendaItensDescricao where vendaID = {txtPedidoNumero.Text} and tipo = 'P'";

            try
            {
                conexao.Open();

                dtProdutos = new DataTable();

                //MySqlDataAdapter daProdutos = new MySqlDataAdapter(sql, conexao);
                SqlDataAdapter daProdutos = new SqlDataAdapter(sql, conexao);

                daProdutos.Fill(dtProdutos);

                recarregaGradeProduto();

                dgProdutos.DataSource = dtProdutos;

            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao carregar grade dos produtos: " + ex.Message, "Erro");
            }
            finally
            {
                conexao.Close();
            }
        }

        private void recarregaGradeProduto()
        {
            if (dgProdutos.Rows.Count > 0)
            {
                for (int i = 0; i < dgProdutos.RowCount; i++)
                {
                    dgProdutos.Rows[i].DataGridView.Columns.Clear();
                }
            }
        }

        private void btnGravar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtClienteVenda.Text)
                || txtClienteVenda.Text == "0")
            {
                MessageBox.Show("Cliente não inserido.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                var total = txtTotal.Text;

                if (string.IsNullOrEmpty(total))
                    total = "0";
                else
                {
                    if (total.Contains(','))
                        total = total.Replace(',', '.');
                }

                string sql = $@"insert into venda (clienteID, observacao, total) 
                                values ({txtClienteVenda.Text}, '{txtObservacao.Text}', {total})";

                try
                {
                    conexao.Open();

                    //MySqlCommand cmd = new MySqlCommand(sql, conexao);
                    SqlCommand cmd = new SqlCommand(sql, conexao);

                    cmd.ExecuteReader();

                    //string ultimoPedido = "select numero from venda order by numero desc limit 1";
                    string ultimoPedido = "select top 1 numero from venda order by numero des";

                    conexao.Close();

                    conexao.Open();

                    //cmd = new MySqlCommand(ultimoPedido, conexao);
                    cmd = new SqlCommand(ultimoPedido, conexao);

                    //MySqlDataReader reader = cmd.ExecuteReader();
                    SqlDataReader reader = cmd.ExecuteReader();

                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            txtPedidoNumero.Text = reader["numero"].ToString();
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao gravar cabeçalho do pedido: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    conexao.Close();
                }
            }

            somartotais();

        }

        private void somartotais()
        {
            decimal total = 0;

            if (dgProdutos.Rows.Count > 0)
            {
                for (int i = 0; i < dgProdutos.Rows.Count; i++)
                {
                    decimal novoTotal = int.Parse(dgProdutos.Rows[i].Cells["quantidade"].Value.ToString()) * decimal.Parse(dgProdutos.Rows[i].Cells["valor"].Value.ToString());

                    total = total + novoTotal;
                }
            }
            if (dgEntretenimento.Rows.Count > 0)
            {
                for (int i = 0; i < dgEntretenimento.Rows.Count; i++)
                {
                    decimal novoTotal = int.Parse(dgEntretenimento.Rows[i].Cells["quantidade"].Value.ToString()) * decimal.Parse(dgEntretenimento.Rows[i].Cells["valor"].Value.ToString());

                    total = total + novoTotal;
                }
            }


            txtTotal.Text = total.ToString();

        }

        private void btnExcluirProduto_Click(object sender, EventArgs e)
        {
            if (dgProdutos.Rows.Count > 0)
            {
                string id = dgProdutos.SelectedRows[0].Cells[1].Value.ToString();

                if (MessageBox.Show($"Excluir o item selecionado: {id}?", "Atenção", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    try
                    {
                        conexao.Open();

                        string sql = $"delete from vendaItens where vendaID = {txtPedidoNumero.Text} and produtoID = {id}";

                        //MySqlCommand cmd = new MySqlCommand(sql, conexao);
                        SqlCommand cmd = new SqlCommand(sql, conexao);

                        cmd.ExecuteReader();

                        MessageBox.Show("Item excluído.");

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Erro ao excluir item: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    finally
                    {
                        conexao.Close();
                    }
                    atualizaGradeProduto();
                }
            }
            somartotais();
        }

        private void btnInserirEntretenimento_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtEntretenimento.Text)
                || txtEntretenimento.Text == "0")
            {
                MessageBox.Show("Preencha o entretenimento primeiro.");
                return;
            }
            else if (txtQuantidadeEntretenimento.Text == "0")
            {
                MessageBox.Show("Defina a quantidade de itens para inserir");
                return;
            }
            else
            {
                if (string.IsNullOrEmpty(txtPedidoNumero.Text)
                    || txtPedidoNumero.Text == "0")
                    btnGravar_Click(sender, e);

                for (int i = 0; i < dgEntretenimento.Rows.Count; i++)
                {
                    if (dgEntretenimento.Rows[i].Cells["produto"].Value.ToString() == txtEntretenimento.Text)
                    {
                        if (MessageBox.Show("Entretenimento já inserido! Deseja somar quantidades?", "Atenção", MessageBoxButtons.YesNo) == DialogResult.Yes)
                        {
                            try
                            {
                                var quantidade = int.Parse(txtQuantidadeEntretenimento.Text);
                                var quantidadeBanco = int.Parse(dgEntretenimento.Rows[i].Cells["quantidade"].Value.ToString());
                                var total = quantidade + quantidadeBanco;

                                string updatesql = $" update vendaItens set quantidade = {total} where vendaID = {txtPedidoNumero.Text} and produtoID = {txtEntretenimento.Text}";

                                conexao.Open();
                                //MySqlCommand cmd = new MySqlCommand(updatesql, conexao);
                                SqlCommand cmd = new SqlCommand(updatesql, conexao);
                                cmd.ExecuteReader();

                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show("Erro ao somar quantidades: "+ex.Message);
                            }
                            finally
                            {
                                conexao.Close();
                            }
                        }
                        atualizaGradeEntretenimento();
                        somartotais();
                        return;
                    }
                }

                var valor = txtValorEntretenimento.Text;

                if (valor.Contains(','))
                    valor = valor.Replace(',', '.');

                string sql = $@"insert into vendaItens (vendaID, produtoID, quantidade, valorProduto, tipo)
                                values({txtPedidoNumero.Text}, {txtEntretenimento.Text}, {txtQuantidadeEntretenimento.Text}, {valor}, 'E')";

                try
                {
                    conexao.Open();

                    //MySqlCommand cmd = new MySqlCommand(sql, conexao);
                    SqlCommand cmd = new SqlCommand(sql, conexao);

                    cmd.ExecuteReader();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao inserir entretenimento na grade: " + ex.Message);
                }
                finally
                {
                    conexao.Close();
                }
                atualizaGradeEntretenimento();
            }
            somartotais();
        }

        private void atualizaGradeEntretenimento()
        {
            txtEntretenimento.Text = "";
            labelEntretenimentoNome.Text = "";
            txtQuantidadeEntretenimento.Text = "";
            txtValorEntretenimento.Text = "";

            string sql = $"select vendaID Pedido, produtoID Produto, descricao 'Descrição', quantidade Quantidade, valorProduto Valor from vendaItensDescricao where vendaID = {txtPedidoNumero.Text} and tipo = 'E'";

            try
            {
                conexao.Open();

                dtProdutos = new DataTable();

                //MySqlDataAdapter daProdutos = new MySqlDataAdapter(sql, conexao);
                SqlDataAdapter daProdutos = new SqlDataAdapter(sql, conexao);

                daProdutos.Fill(dtProdutos);

                recarregaGradeEntretenimento();

                dgEntretenimento.DataSource = dtProdutos;

            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao carregar grade de entretenimentos: " + ex.Message, "Erro");
            }
            finally
            {
                conexao.Close();
            }
        }

        private void recarregaGradeEntretenimento()
        {
            if (dgEntretenimento.Rows.Count > 0)
            {
                for (int i = 0; i < dgEntretenimento.RowCount; i++)
                {
                    dgEntretenimento.Rows[i].DataGridView.Columns.Clear();
                }
            }

        }

        private void btnExcluirEntretenimento_Click(object sender, EventArgs e)
        {

            if (dgEntretenimento.Rows.Count > 0)
            {
                string id = dgEntretenimento.SelectedRows[0].Cells[1].Value.ToString();

                if (MessageBox.Show($"Excluir o item selecionado: {id}?", "Atenção", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    try
                    {
                        conexao.Open();

                        string sql = $"delete from vendaItens where vendaID = {txtPedidoNumero.Text} and produtoID = {id}";

                        //MySqlCommand cmd = new MySqlCommand(sql, conexao);
                        SqlCommand cmd = new SqlCommand(sql, conexao);

                        cmd.ExecuteReader();

                        MessageBox.Show("Item excluído.");

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Erro ao excluir item: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    finally
                    {
                        conexao.Close();
                    }
                    atualizaGradeEntretenimento();
                }
            }
            somartotais();
        }

        private void btnConsultaPedido_Click(object sender, EventArgs e)
        {
            SuperConsulta consulta = new SuperConsulta();

            consulta.CarregaConsulta("venda");

            consulta.ShowDialog();

            string consultaID = consulta.BuscaRetorno();

            if (!string.IsNullOrEmpty(consultaID))
            {

                try
                {
                    string sql = $"select * from pedidoClienteNome where numero = {consultaID}";

                    //MySqlCommand cmd = new MySqlCommand(sql, conexao);
                    SqlCommand cmd = new SqlCommand(sql, conexao);

                    conexao.Open();

                    //MySqlDataReader reader = cmd.ExecuteReader();
                    SqlDataReader reader = cmd.ExecuteReader();

                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            txtPedidoNumero.Text = reader["numero"].ToString();
                            txtObservacao.Text = reader["observacao"].ToString();
                            txtClienteVenda.Text = reader["clienteID"].ToString();
                            txtNomeClienteVenda.Text = reader["nome"].ToString();
                            txtTotal.Text = reader["total"].ToString();
                        }
                        primeiroCarregamento();
                    }
                    else
                        MessageBox.Show("Pedido não encontrado.");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao consultar entretenimento: " + ex.Message);
                }
                finally
                {
                    conexao.Close();
                }
            }

        }

        private void primeiroCarregamento()
        {
            conexao.Close();
            atualizaGradeEntretenimento();
            atualizaGradeProduto();
            somartotais();
            conexao.Open();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (txtPedidoNumero.Text != "0")
            {
                if (MessageBox.Show("Deseja excluir esta venda?", "Atenção", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    string deleteitens = $"delete from vendaItens where vendaID = {txtPedidoNumero.Text}";

                    try
                    {
                        conexao.Open();

                        //MySqlCommand cmd = new MySqlCommand(deleteitens, conexao);
                        SqlCommand cmd = new SqlCommand(deleteitens, conexao);

                        cmd.ExecuteReader();

                        conexao.Close();

                        string deletePedido = $"delete from venda where numero = {txtPedidoNumero.Text}";

                        conexao.Open();
                        //cmd = new MySqlCommand(deletePedido, conexao);
                        cmd = new SqlCommand(deletePedido, conexao);

                        cmd.ExecuteReader();

                        MessageBox.Show("Registro excluído.");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Erro ao escluir venda: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    finally
                    {
                        conexao.Close();
                    }

                    LimparTela();
                    atualizaGradeEntretenimento();
                    atualizaGradeProduto();
                }
            }
        }
    }
}