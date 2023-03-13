namespace Barzinho
{
    partial class Menu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnCad = new System.Windows.Forms.Button();
            this.btnVenda = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.btnRelatorios = new System.Windows.Forms.Button();
            this.panelMenu = new System.Windows.Forms.Panel();
            this.toolStripContainer1 = new System.Windows.Forms.ToolStripContainer();
            this.btnCadEntretenimento = new System.Windows.Forms.Button();
            this.btnCadProduto = new System.Windows.Forms.Button();
            this.btnCadCliente = new System.Windows.Forms.Button();
            this.toolStripContainer2 = new System.Windows.Forms.ToolStripContainer();
            this.RelVendaItens = new System.Windows.Forms.Button();
            this.RelVenda = new System.Windows.Forms.Button();
            this.RelEntretenimento = new System.Windows.Forms.Button();
            this.RelProduto = new System.Windows.Forms.Button();
            this.RelCliente = new System.Windows.Forms.Button();
            this.toolStripContainer1.ContentPanel.SuspendLayout();
            this.toolStripContainer1.SuspendLayout();
            this.toolStripContainer2.ContentPanel.SuspendLayout();
            this.toolStripContainer2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCad
            // 
            this.btnCad.BackColor = System.Drawing.Color.Green;
            this.btnCad.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.btnCad.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnCad.Location = new System.Drawing.Point(12, 12);
            this.btnCad.Name = "btnCad";
            this.btnCad.Size = new System.Drawing.Size(218, 82);
            this.btnCad.TabIndex = 0;
            this.btnCad.Text = "Cadastros";
            this.btnCad.UseVisualStyleBackColor = false;
            this.btnCad.Click += new System.EventHandler(this.btnCadCliente_Click);
            // 
            // btnVenda
            // 
            this.btnVenda.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.btnVenda.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.btnVenda.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnVenda.Location = new System.Drawing.Point(12, 129);
            this.btnVenda.Name = "btnVenda";
            this.btnVenda.Size = new System.Drawing.Size(218, 82);
            this.btnVenda.TabIndex = 3;
            this.btnVenda.Text = "Venda";
            this.btnVenda.UseVisualStyleBackColor = false;
            this.btnVenda.Click += new System.EventHandler(this.btnVenda_Click);
            // 
            // btnSair
            // 
            this.btnSair.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnSair.BackColor = System.Drawing.Color.OrangeRed;
            this.btnSair.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.btnSair.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnSair.Location = new System.Drawing.Point(12, 689);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(154, 45);
            this.btnSair.TabIndex = 4;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = false;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // btnRelatorios
            // 
            this.btnRelatorios.BackColor = System.Drawing.Color.DarkCyan;
            this.btnRelatorios.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.btnRelatorios.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnRelatorios.Location = new System.Drawing.Point(12, 243);
            this.btnRelatorios.Name = "btnRelatorios";
            this.btnRelatorios.Size = new System.Drawing.Size(218, 82);
            this.btnRelatorios.TabIndex = 5;
            this.btnRelatorios.Text = "Relatórios";
            this.btnRelatorios.UseVisualStyleBackColor = false;
            this.btnRelatorios.Click += new System.EventHandler(this.btnRelatorios_Click);
            // 
            // panelMenu
            // 
            this.panelMenu.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panelMenu.BackColor = System.Drawing.SystemColors.Control;
            this.panelMenu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panelMenu.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelMenu.ImeMode = System.Windows.Forms.ImeMode.On;
            this.panelMenu.Location = new System.Drawing.Point(236, 12);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(1245, 722);
            this.panelMenu.TabIndex = 6;
            // 
            // toolStripContainer1
            // 
            this.toolStripContainer1.BottomToolStripPanelVisible = false;
            // 
            // toolStripContainer1.ContentPanel
            // 
            this.toolStripContainer1.ContentPanel.BackColor = System.Drawing.SystemColors.Control;
            this.toolStripContainer1.ContentPanel.Controls.Add(this.btnCadEntretenimento);
            this.toolStripContainer1.ContentPanel.Controls.Add(this.btnCadProduto);
            this.toolStripContainer1.ContentPanel.Controls.Add(this.btnCadCliente);
            this.toolStripContainer1.ContentPanel.Size = new System.Drawing.Size(167, 177);
            this.toolStripContainer1.LeftToolStripPanelVisible = false;
            this.toolStripContainer1.Location = new System.Drawing.Point(236, 12);
            this.toolStripContainer1.Name = "toolStripContainer1";
            this.toolStripContainer1.RightToolStripPanelVisible = false;
            this.toolStripContainer1.Size = new System.Drawing.Size(167, 177);
            this.toolStripContainer1.TabIndex = 0;
            this.toolStripContainer1.Text = "toolStripContainer1";
            // 
            // toolStripContainer1.TopToolStripPanel
            // 
            this.toolStripContainer1.TopToolStripPanel.Enabled = false;
            this.toolStripContainer1.TopToolStripPanelVisible = false;
            this.toolStripContainer1.Visible = false;
            this.toolStripContainer1.Leave += new System.EventHandler(this.toolStripContainer1_Leave);
            this.toolStripContainer1.MouseLeave += new System.EventHandler(this.toolStripContainer1_MouseLeave);
            // 
            // btnCadEntretenimento
            // 
            this.btnCadEntretenimento.BackColor = System.Drawing.Color.Green;
            this.btnCadEntretenimento.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.btnCadEntretenimento.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnCadEntretenimento.Location = new System.Drawing.Point(1, 120);
            this.btnCadEntretenimento.Name = "btnCadEntretenimento";
            this.btnCadEntretenimento.Size = new System.Drawing.Size(165, 54);
            this.btnCadEntretenimento.TabIndex = 3;
            this.btnCadEntretenimento.Text = "Entretenimento";
            this.btnCadEntretenimento.UseVisualStyleBackColor = false;
            this.btnCadEntretenimento.Click += new System.EventHandler(this.btnCadEntretenimento_Click_1);
            // 
            // btnCadProduto
            // 
            this.btnCadProduto.BackColor = System.Drawing.Color.Green;
            this.btnCadProduto.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.btnCadProduto.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnCadProduto.Location = new System.Drawing.Point(1, 60);
            this.btnCadProduto.Name = "btnCadProduto";
            this.btnCadProduto.Size = new System.Drawing.Size(165, 54);
            this.btnCadProduto.TabIndex = 2;
            this.btnCadProduto.Text = "Produto";
            this.btnCadProduto.UseVisualStyleBackColor = false;
            this.btnCadProduto.Click += new System.EventHandler(this.btnCadProduto_Click_1);
            // 
            // btnCadCliente
            // 
            this.btnCadCliente.BackColor = System.Drawing.Color.Green;
            this.btnCadCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.btnCadCliente.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnCadCliente.Location = new System.Drawing.Point(2, 0);
            this.btnCadCliente.Name = "btnCadCliente";
            this.btnCadCliente.Size = new System.Drawing.Size(165, 54);
            this.btnCadCliente.TabIndex = 1;
            this.btnCadCliente.Text = "Cliente";
            this.btnCadCliente.UseVisualStyleBackColor = false;
            this.btnCadCliente.Click += new System.EventHandler(this.btnCadCliente_Click_1);
            // 
            // toolStripContainer2
            // 
            this.toolStripContainer2.BottomToolStripPanelVisible = false;
            // 
            // toolStripContainer2.ContentPanel
            // 
            this.toolStripContainer2.ContentPanel.BackColor = System.Drawing.SystemColors.Control;
            this.toolStripContainer2.ContentPanel.Controls.Add(this.RelVendaItens);
            this.toolStripContainer2.ContentPanel.Controls.Add(this.RelVenda);
            this.toolStripContainer2.ContentPanel.Controls.Add(this.RelEntretenimento);
            this.toolStripContainer2.ContentPanel.Controls.Add(this.RelProduto);
            this.toolStripContainer2.ContentPanel.Controls.Add(this.RelCliente);
            this.toolStripContainer2.ContentPanel.Size = new System.Drawing.Size(167, 300);
            this.toolStripContainer2.LeftToolStripPanelVisible = false;
            this.toolStripContainer2.Location = new System.Drawing.Point(236, 243);
            this.toolStripContainer2.Name = "toolStripContainer2";
            this.toolStripContainer2.RightToolStripPanelVisible = false;
            this.toolStripContainer2.Size = new System.Drawing.Size(167, 300);
            this.toolStripContainer2.TabIndex = 7;
            this.toolStripContainer2.Text = "toolStripContainer2";
            // 
            // toolStripContainer2.TopToolStripPanel
            // 
            this.toolStripContainer2.TopToolStripPanel.Enabled = false;
            this.toolStripContainer2.TopToolStripPanelVisible = false;
            this.toolStripContainer2.Visible = false;
            this.toolStripContainer2.Leave += new System.EventHandler(this.toolStripContainer2_Leave);
            this.toolStripContainer2.MouseLeave += new System.EventHandler(this.toolStripContainer2_MouseLeave);
            // 
            // RelVendaItens
            // 
            this.RelVendaItens.BackColor = System.Drawing.Color.DarkCyan;
            this.RelVendaItens.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.RelVendaItens.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.RelVendaItens.Location = new System.Drawing.Point(0, 243);
            this.RelVendaItens.Name = "RelVendaItens";
            this.RelVendaItens.Size = new System.Drawing.Size(165, 54);
            this.RelVendaItens.TabIndex = 5;
            this.RelVendaItens.Text = "Venda + Itens";
            this.RelVendaItens.UseVisualStyleBackColor = false;
            // 
            // RelVenda
            // 
            this.RelVenda.BackColor = System.Drawing.Color.DarkCyan;
            this.RelVenda.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.RelVenda.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.RelVenda.Location = new System.Drawing.Point(1, 183);
            this.RelVenda.Name = "RelVenda";
            this.RelVenda.Size = new System.Drawing.Size(165, 54);
            this.RelVenda.TabIndex = 4;
            this.RelVenda.Text = "Venda";
            this.RelVenda.UseVisualStyleBackColor = false;
            // 
            // RelEntretenimento
            // 
            this.RelEntretenimento.BackColor = System.Drawing.Color.DarkCyan;
            this.RelEntretenimento.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.RelEntretenimento.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.RelEntretenimento.Location = new System.Drawing.Point(1, 123);
            this.RelEntretenimento.Name = "RelEntretenimento";
            this.RelEntretenimento.Size = new System.Drawing.Size(165, 54);
            this.RelEntretenimento.TabIndex = 3;
            this.RelEntretenimento.Text = "Entretenimento";
            this.RelEntretenimento.UseVisualStyleBackColor = false;
            // 
            // RelProduto
            // 
            this.RelProduto.BackColor = System.Drawing.Color.DarkCyan;
            this.RelProduto.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.RelProduto.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.RelProduto.Location = new System.Drawing.Point(1, 63);
            this.RelProduto.Name = "RelProduto";
            this.RelProduto.Size = new System.Drawing.Size(165, 54);
            this.RelProduto.TabIndex = 2;
            this.RelProduto.Text = "Produto";
            this.RelProduto.UseVisualStyleBackColor = false;
            // 
            // RelCliente
            // 
            this.RelCliente.BackColor = System.Drawing.Color.DarkCyan;
            this.RelCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.RelCliente.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.RelCliente.Location = new System.Drawing.Point(1, 3);
            this.RelCliente.Name = "RelCliente";
            this.RelCliente.Size = new System.Drawing.Size(165, 54);
            this.RelCliente.TabIndex = 1;
            this.RelCliente.Text = "Cliente";
            this.RelCliente.UseVisualStyleBackColor = false;
            this.RelCliente.Click += new System.EventHandler(this.RelCliente_Click);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(1493, 746);
            this.ControlBox = false;
            this.Controls.Add(this.toolStripContainer2);
            this.Controls.Add(this.toolStripContainer1);
            this.Controls.Add(this.panelMenu);
            this.Controls.Add(this.btnRelatorios);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.btnVenda);
            this.Controls.Add(this.btnCad);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Menu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu";
            this.toolStripContainer1.ContentPanel.ResumeLayout(false);
            this.toolStripContainer1.ResumeLayout(false);
            this.toolStripContainer1.PerformLayout();
            this.toolStripContainer2.ContentPanel.ResumeLayout(false);
            this.toolStripContainer2.ResumeLayout(false);
            this.toolStripContainer2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCad;
        private System.Windows.Forms.Button btnVenda;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Button btnRelatorios;
        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Button btnCadEntretenimento;
        private System.Windows.Forms.Button btnCadProduto;
        private System.Windows.Forms.Button btnCadCliente;
        public System.Windows.Forms.ToolStripContainer toolStripContainer1;
        public System.Windows.Forms.ToolStripContainer toolStripContainer2;
        private System.Windows.Forms.Button RelCliente;
        private System.Windows.Forms.Button RelVendaItens;
        private System.Windows.Forms.Button RelVenda;
        private System.Windows.Forms.Button RelEntretenimento;
        private System.Windows.Forms.Button RelProduto;
    }
}