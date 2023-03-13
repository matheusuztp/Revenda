using System;
using System.Windows.Forms;

namespace Barzinho
{
    public partial class Menu : Form
    {
        CadProduto produto;
        CadCliente cliente;
        Venda venda;
        public Menu()
        {
            InitializeComponent();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            if (toolStripContainer2.Visible == true)
                toolStripContainer2.Visible = false;

            if (toolStripContainer1.Visible == true)
                toolStripContainer1.Visible = false;

            if (MessageBox.Show("Deseja fechar o sistema?", "Atenção.", MessageBoxButtons.YesNo) == DialogResult.Yes)
                this.Close();
        }

        private void btnCadCliente_Click(object sender, EventArgs e)
        {
            toolStripContainer1.Visible = true;

            if (toolStripContainer2.Visible == true)
                toolStripContainer2.Visible = false;
        }

        private void btnCadProduto_Click(object sender, EventArgs e)
        {
            CadProduto produto = new CadProduto();
            produto.Show();
        }

        private void btnCadEntretenimento_Click(object sender, EventArgs e)
        {
            CadEntretenimento entretenimento = new CadEntretenimento();
            entretenimento.Show();
        }

        private void btnVenda_Click(object sender, EventArgs e)
        {
            if (toolStripContainer1.Visible == true)
                toolStripContainer1.Visible = false;

            if (toolStripContainer2.Visible == true)
                toolStripContainer2.Visible = false;

            venda = new Venda();

            ValidaPainel(venda);
            venda.TopLevel = false;
            panelMenu.Controls.Add(venda);
            venda.Show();
        }

        private void btnRelatorios_Click(object sender, EventArgs e)
        {
            if (toolStripContainer1.Visible == true)
                toolStripContainer1.Visible = false;

            toolStripContainer2.Visible = true;

        }

        private void toolStripContainer1_Leave(object sender, EventArgs e)
        {
            toolStripContainer1.Visible = false;
        }

        private void btnCadCliente_Click_1(object sender, EventArgs e)
        {
            cliente = new CadCliente();

            ValidaPainel(cliente);
            cliente.TopLevel = false;
            panelMenu.Controls.Add(cliente);
            cliente.Show();

            if (toolStripContainer1.Visible == true)
                toolStripContainer1.Visible = false;
        }

        private void btnCadProduto_Click_1(object sender, EventArgs e)
        {
            produto = new CadProduto();

            ValidaPainel(produto);
            produto.TopLevel = false;
            panelMenu.Controls.Add(produto);
            produto.StartPosition = FormStartPosition.CenterParent;
            produto.Show();

            if (toolStripContainer1.Visible == true)
                toolStripContainer1.Visible = false;
        }

        public void ValidaPainel(Form tela)
        {
            foreach (Form forms in panelMenu.Controls)
            {
                if (panelMenu.Controls.Count > 0)
                    forms.WindowState = FormWindowState.Minimized;
            }
        }

        private void btnCadEntretenimento_Click_1(object sender, EventArgs e)
        {
            CadEntretenimento entretenimento = new CadEntretenimento();

            ValidaPainel(entretenimento);
            entretenimento.TopLevel = false;
            panelMenu.Controls.Add(entretenimento);
            entretenimento.Show();

            if (toolStripContainer1.Visible == true)
                toolStripContainer1.Visible = false;
        }

        private void toolStripContainer1_MouseLeave(object sender, EventArgs e)
        {
            toolStripContainer1.Visible = false;
        }

        private void toolStripContainer2_Leave(object sender, EventArgs e)
        {
            toolStripContainer2.Visible = false;
        }

        private void toolStripContainer2_MouseLeave(object sender, EventArgs e)
        {
            toolStripContainer2.Visible = false;
        }

        private void RelCliente_Click(object sender, EventArgs e)
        {
            // relatorio de cliente
        }
    }
}
