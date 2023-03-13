namespace Barzinho
{
    partial class Venda
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtClienteVenda = new System.Windows.Forms.TextBox();
            this.txtNomeClienteVenda = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnConsultaCliente = new System.Windows.Forms.Button();
            this.TabVenda = new System.Windows.Forms.TabControl();
            this.tabProduto = new System.Windows.Forms.TabPage();
            this.btnConsultaProduto = new System.Windows.Forms.Button();
            this.labelNomeProduto = new System.Windows.Forms.Label();
            this.txtValorProdutoVenda = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtQuantidadeProdutoVenda = new System.Windows.Forms.TextBox();
            this.btnExcluirProduto = new System.Windows.Forms.Button();
            this.btnInserirProduto = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.txtProdutoVenda = new System.Windows.Forms.TextBox();
            this.dgProdutos = new System.Windows.Forms.DataGridView();
            this.tabEntretenimento = new System.Windows.Forms.TabPage();
            this.labelEntretenimentoNome = new System.Windows.Forms.Label();
            this.txtValorEntretenimento = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.txtQuantidadeEntretenimento = new System.Windows.Forms.TextBox();
            this.btnExcluirEntretenimento = new System.Windows.Forms.Button();
            this.btnInserirEntretenimento = new System.Windows.Forms.Button();
            this.dgEntretenimento = new System.Windows.Forms.DataGridView();
            this.btnConsultaEntretenimento = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.txtEntretenimento = new System.Windows.Forms.TextBox();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnNovo = new System.Windows.Forms.Button();
            this.btnGravar = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.txtPedidoNumero = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.btnConsultaPedido = new System.Windows.Forms.Button();
            this.txtObservacao = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.TabVenda.SuspendLayout();
            this.tabProduto.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgProdutos)).BeginInit();
            this.tabEntretenimento.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgEntretenimento)).BeginInit();
            this.SuspendLayout();
            // 
            // txtClienteVenda
            // 
            this.txtClienteVenda.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtClienteVenda.HideSelection = false;
            this.txtClienteVenda.Location = new System.Drawing.Point(503, 9);
            this.txtClienteVenda.Name = "txtClienteVenda";
            this.txtClienteVenda.ReadOnly = true;
            this.txtClienteVenda.Size = new System.Drawing.Size(41, 20);
            this.txtClienteVenda.TabIndex = 12;
            // 
            // txtNomeClienteVenda
            // 
            this.txtNomeClienteVenda.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNomeClienteVenda.HideSelection = false;
            this.txtNomeClienteVenda.Location = new System.Drawing.Point(502, 35);
            this.txtNomeClienteVenda.Name = "txtNomeClienteVenda";
            this.txtNomeClienteVenda.ReadOnly = true;
            this.txtNomeClienteVenda.Size = new System.Drawing.Size(273, 20);
            this.txtNomeClienteVenda.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(445, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 20);
            this.label1.TabIndex = 11;
            this.label1.Text = "Cliente";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(445, 32);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 20);
            this.label3.TabIndex = 1;
            this.label3.Text = "Nome";
            // 
            // btnConsultaCliente
            // 
            this.btnConsultaCliente.Location = new System.Drawing.Point(557, 9);
            this.btnConsultaCliente.Name = "btnConsultaCliente";
            this.btnConsultaCliente.Size = new System.Drawing.Size(65, 20);
            this.btnConsultaCliente.TabIndex = 0;
            this.btnConsultaCliente.Text = "Consultar";
            this.btnConsultaCliente.UseVisualStyleBackColor = true;
            this.btnConsultaCliente.Click += new System.EventHandler(this.btnConsultaCliente_Click);
            // 
            // TabVenda
            // 
            this.TabVenda.Controls.Add(this.tabProduto);
            this.TabVenda.Controls.Add(this.tabEntretenimento);
            this.TabVenda.Location = new System.Drawing.Point(16, 61);
            this.TabVenda.Name = "TabVenda";
            this.TabVenda.SelectedIndex = 0;
            this.TabVenda.Size = new System.Drawing.Size(802, 346);
            this.TabVenda.TabIndex = 3;
            // 
            // tabProduto
            // 
            this.tabProduto.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.tabProduto.Controls.Add(this.btnConsultaProduto);
            this.tabProduto.Controls.Add(this.labelNomeProduto);
            this.tabProduto.Controls.Add(this.txtValorProdutoVenda);
            this.tabProduto.Controls.Add(this.label4);
            this.tabProduto.Controls.Add(this.label6);
            this.tabProduto.Controls.Add(this.txtQuantidadeProdutoVenda);
            this.tabProduto.Controls.Add(this.btnExcluirProduto);
            this.tabProduto.Controls.Add(this.btnInserirProduto);
            this.tabProduto.Controls.Add(this.label7);
            this.tabProduto.Controls.Add(this.txtProdutoVenda);
            this.tabProduto.Controls.Add(this.dgProdutos);
            this.tabProduto.Location = new System.Drawing.Point(4, 22);
            this.tabProduto.Name = "tabProduto";
            this.tabProduto.Padding = new System.Windows.Forms.Padding(3);
            this.tabProduto.Size = new System.Drawing.Size(794, 320);
            this.tabProduto.TabIndex = 0;
            this.tabProduto.Text = "Produtos";
            // 
            // btnConsultaProduto
            // 
            this.btnConsultaProduto.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnConsultaProduto.Location = new System.Drawing.Point(74, 26);
            this.btnConsultaProduto.Name = "btnConsultaProduto";
            this.btnConsultaProduto.Size = new System.Drawing.Size(75, 21);
            this.btnConsultaProduto.TabIndex = 9;
            this.btnConsultaProduto.Text = "Consultar";
            this.btnConsultaProduto.UseVisualStyleBackColor = true;
            this.btnConsultaProduto.Click += new System.EventHandler(this.btnConsultaProduto_Click);
            // 
            // labelNomeProduto
            // 
            this.labelNomeProduto.AutoSize = true;
            this.labelNomeProduto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.labelNomeProduto.Location = new System.Drawing.Point(148, 24);
            this.labelNomeProduto.Name = "labelNomeProduto";
            this.labelNomeProduto.Size = new System.Drawing.Size(21, 20);
            this.labelNomeProduto.TabIndex = 1;
            this.labelNomeProduto.Text = "...";
            this.labelNomeProduto.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtValorProdutoVenda
            // 
            this.txtValorProdutoVenda.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtValorProdutoVenda.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtValorProdutoVenda.HideSelection = false;
            this.txtValorProdutoVenda.Location = new System.Drawing.Point(550, 27);
            this.txtValorProdutoVenda.Name = "txtValorProdutoVenda";
            this.txtValorProdutoVenda.Size = new System.Drawing.Size(88, 20);
            this.txtValorProdutoVenda.TabIndex = 5;
            this.txtValorProdutoVenda.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label4.Location = new System.Drawing.Point(594, 4);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 20);
            this.label4.TabIndex = 4;
            this.label4.Text = "Valor";
            this.label4.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label6.Location = new System.Drawing.Point(454, 4);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(92, 20);
            this.label6.TabIndex = 2;
            this.label6.Text = "Quantidade";
            this.label6.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // txtQuantidadeProdutoVenda
            // 
            this.txtQuantidadeProdutoVenda.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtQuantidadeProdutoVenda.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtQuantidadeProdutoVenda.HideSelection = false;
            this.txtQuantidadeProdutoVenda.Location = new System.Drawing.Point(456, 27);
            this.txtQuantidadeProdutoVenda.Name = "txtQuantidadeProdutoVenda";
            this.txtQuantidadeProdutoVenda.Size = new System.Drawing.Size(88, 20);
            this.txtQuantidadeProdutoVenda.TabIndex = 3;
            this.txtQuantidadeProdutoVenda.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btnExcluirProduto
            // 
            this.btnExcluirProduto.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnExcluirProduto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExcluirProduto.ForeColor = System.Drawing.Color.Red;
            this.btnExcluirProduto.Location = new System.Drawing.Point(755, 22);
            this.btnExcluirProduto.Name = "btnExcluirProduto";
            this.btnExcluirProduto.Size = new System.Drawing.Size(35, 25);
            this.btnExcluirProduto.TabIndex = 7;
            this.btnExcluirProduto.Text = "X";
            this.btnExcluirProduto.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnExcluirProduto.UseVisualStyleBackColor = true;
            this.btnExcluirProduto.Click += new System.EventHandler(this.btnExcluirProduto_Click);
            // 
            // btnInserirProduto
            // 
            this.btnInserirProduto.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnInserirProduto.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.btnInserirProduto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInserirProduto.ForeColor = System.Drawing.Color.Black;
            this.btnInserirProduto.Location = new System.Drawing.Point(658, 22);
            this.btnInserirProduto.Name = "btnInserirProduto";
            this.btnInserirProduto.Size = new System.Drawing.Size(91, 25);
            this.btnInserirProduto.TabIndex = 6;
            this.btnInserirProduto.Text = "Inserir";
            this.btnInserirProduto.UseVisualStyleBackColor = false;
            this.btnInserirProduto.Click += new System.EventHandler(this.btnInserirProduto_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label7.Location = new System.Drawing.Point(3, 5);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(65, 20);
            this.label7.TabIndex = 0;
            this.label7.Text = "Produto";
            this.label7.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // txtProdutoVenda
            // 
            this.txtProdutoVenda.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtProdutoVenda.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtProdutoVenda.HideSelection = false;
            this.txtProdutoVenda.Location = new System.Drawing.Point(3, 26);
            this.txtProdutoVenda.Name = "txtProdutoVenda";
            this.txtProdutoVenda.ReadOnly = true;
            this.txtProdutoVenda.Size = new System.Drawing.Size(65, 20);
            this.txtProdutoVenda.TabIndex = 0;
            // 
            // dgProdutos
            // 
            this.dgProdutos.AllowUserToAddRows = false;
            this.dgProdutos.AllowUserToDeleteRows = false;
            this.dgProdutos.AllowUserToResizeRows = false;
            this.dgProdutos.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dgProdutos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgProdutos.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.dgProdutos.Location = new System.Drawing.Point(3, 53);
            this.dgProdutos.MultiSelect = false;
            this.dgProdutos.Name = "dgProdutos";
            this.dgProdutos.ReadOnly = true;
            this.dgProdutos.RowHeadersVisible = false;
            this.dgProdutos.RowHeadersWidth = 62;
            this.dgProdutos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgProdutos.Size = new System.Drawing.Size(789, 261);
            this.dgProdutos.TabIndex = 8;
            // 
            // tabEntretenimento
            // 
            this.tabEntretenimento.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.tabEntretenimento.Controls.Add(this.labelEntretenimentoNome);
            this.tabEntretenimento.Controls.Add(this.txtValorEntretenimento);
            this.tabEntretenimento.Controls.Add(this.label10);
            this.tabEntretenimento.Controls.Add(this.label11);
            this.tabEntretenimento.Controls.Add(this.txtQuantidadeEntretenimento);
            this.tabEntretenimento.Controls.Add(this.btnExcluirEntretenimento);
            this.tabEntretenimento.Controls.Add(this.btnInserirEntretenimento);
            this.tabEntretenimento.Controls.Add(this.dgEntretenimento);
            this.tabEntretenimento.Controls.Add(this.btnConsultaEntretenimento);
            this.tabEntretenimento.Controls.Add(this.label12);
            this.tabEntretenimento.Controls.Add(this.txtEntretenimento);
            this.tabEntretenimento.Location = new System.Drawing.Point(4, 22);
            this.tabEntretenimento.Name = "tabEntretenimento";
            this.tabEntretenimento.Padding = new System.Windows.Forms.Padding(3);
            this.tabEntretenimento.Size = new System.Drawing.Size(794, 320);
            this.tabEntretenimento.TabIndex = 1;
            this.tabEntretenimento.Text = "Entretenimentos";
            // 
            // labelEntretenimentoNome
            // 
            this.labelEntretenimentoNome.AutoSize = true;
            this.labelEntretenimentoNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.labelEntretenimentoNome.Location = new System.Drawing.Point(145, 26);
            this.labelEntretenimentoNome.Name = "labelEntretenimentoNome";
            this.labelEntretenimentoNome.Size = new System.Drawing.Size(21, 20);
            this.labelEntretenimentoNome.TabIndex = 32;
            this.labelEntretenimentoNome.Text = "...";
            this.labelEntretenimentoNome.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtValorEntretenimento
            // 
            this.txtValorEntretenimento.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtValorEntretenimento.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtValorEntretenimento.HideSelection = false;
            this.txtValorEntretenimento.Location = new System.Drawing.Point(550, 29);
            this.txtValorEntretenimento.Name = "txtValorEntretenimento";
            this.txtValorEntretenimento.Size = new System.Drawing.Size(88, 20);
            this.txtValorEntretenimento.TabIndex = 5;
            this.txtValorEntretenimento.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label10.Location = new System.Drawing.Point(594, 6);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(46, 20);
            this.label10.TabIndex = 4;
            this.label10.Text = "Valor";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label11.Location = new System.Drawing.Point(454, 6);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(92, 20);
            this.label11.TabIndex = 2;
            this.label11.Text = "Quantidade";
            // 
            // txtQuantidadeEntretenimento
            // 
            this.txtQuantidadeEntretenimento.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtQuantidadeEntretenimento.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtQuantidadeEntretenimento.HideSelection = false;
            this.txtQuantidadeEntretenimento.Location = new System.Drawing.Point(456, 29);
            this.txtQuantidadeEntretenimento.Name = "txtQuantidadeEntretenimento";
            this.txtQuantidadeEntretenimento.Size = new System.Drawing.Size(88, 20);
            this.txtQuantidadeEntretenimento.TabIndex = 3;
            this.txtQuantidadeEntretenimento.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btnExcluirEntretenimento
            // 
            this.btnExcluirEntretenimento.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnExcluirEntretenimento.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExcluirEntretenimento.ForeColor = System.Drawing.Color.Red;
            this.btnExcluirEntretenimento.Location = new System.Drawing.Point(755, 24);
            this.btnExcluirEntretenimento.Name = "btnExcluirEntretenimento";
            this.btnExcluirEntretenimento.Size = new System.Drawing.Size(35, 25);
            this.btnExcluirEntretenimento.TabIndex = 7;
            this.btnExcluirEntretenimento.Text = "X";
            this.btnExcluirEntretenimento.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnExcluirEntretenimento.UseVisualStyleBackColor = true;
            this.btnExcluirEntretenimento.Click += new System.EventHandler(this.btnExcluirEntretenimento_Click);
            // 
            // btnInserirEntretenimento
            // 
            this.btnInserirEntretenimento.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnInserirEntretenimento.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.btnInserirEntretenimento.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInserirEntretenimento.ForeColor = System.Drawing.Color.Black;
            this.btnInserirEntretenimento.Location = new System.Drawing.Point(658, 24);
            this.btnInserirEntretenimento.Name = "btnInserirEntretenimento";
            this.btnInserirEntretenimento.Size = new System.Drawing.Size(91, 25);
            this.btnInserirEntretenimento.TabIndex = 6;
            this.btnInserirEntretenimento.Text = "Inserir";
            this.btnInserirEntretenimento.UseVisualStyleBackColor = false;
            this.btnInserirEntretenimento.Click += new System.EventHandler(this.btnInserirEntretenimento_Click);
            // 
            // dgEntretenimento
            // 
            this.dgEntretenimento.AllowUserToAddRows = false;
            this.dgEntretenimento.AllowUserToDeleteRows = false;
            this.dgEntretenimento.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dgEntretenimento.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgEntretenimento.Location = new System.Drawing.Point(3, 55);
            this.dgEntretenimento.MultiSelect = false;
            this.dgEntretenimento.Name = "dgEntretenimento";
            this.dgEntretenimento.ReadOnly = true;
            this.dgEntretenimento.RowHeadersVisible = false;
            this.dgEntretenimento.RowHeadersWidth = 62;
            this.dgEntretenimento.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgEntretenimento.Size = new System.Drawing.Size(789, 261);
            this.dgEntretenimento.TabIndex = 8;
            // 
            // btnConsultaEntretenimento
            // 
            this.btnConsultaEntretenimento.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnConsultaEntretenimento.Location = new System.Drawing.Point(72, 27);
            this.btnConsultaEntretenimento.Name = "btnConsultaEntretenimento";
            this.btnConsultaEntretenimento.Size = new System.Drawing.Size(75, 21);
            this.btnConsultaEntretenimento.TabIndex = 1;
            this.btnConsultaEntretenimento.Text = "Consultar";
            this.btnConsultaEntretenimento.UseVisualStyleBackColor = true;
            this.btnConsultaEntretenimento.Click += new System.EventHandler(this.btnConsultaEntretenimento_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label12.Location = new System.Drawing.Point(3, 6);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(119, 20);
            this.label12.TabIndex = 0;
            this.label12.Text = "Entretenimento";
            // 
            // txtEntretenimento
            // 
            this.txtEntretenimento.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtEntretenimento.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtEntretenimento.HideSelection = false;
            this.txtEntretenimento.Location = new System.Drawing.Point(3, 28);
            this.txtEntretenimento.Name = "txtEntretenimento";
            this.txtEntretenimento.ReadOnly = true;
            this.txtEntretenimento.Size = new System.Drawing.Size(65, 20);
            this.txtEntretenimento.TabIndex = 31;
            // 
            // btnCancelar
            // 
            this.btnCancelar.ForeColor = System.Drawing.Color.Red;
            this.btnCancelar.Location = new System.Drawing.Point(775, 423);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(44, 23);
            this.btnCancelar.TabIndex = 6;
            this.btnCancelar.Text = "Sair";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnNovo
            // 
            this.btnNovo.ForeColor = System.Drawing.Color.ForestGreen;
            this.btnNovo.Location = new System.Drawing.Point(565, 423);
            this.btnNovo.Name = "btnNovo";
            this.btnNovo.Size = new System.Drawing.Size(69, 23);
            this.btnNovo.TabIndex = 4;
            this.btnNovo.Text = "Novo";
            this.btnNovo.UseVisualStyleBackColor = true;
            this.btnNovo.Click += new System.EventHandler(this.btnNovo_Click);
            // 
            // btnGravar
            // 
            this.btnGravar.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.btnGravar.Location = new System.Drawing.Point(699, 423);
            this.btnGravar.Name = "btnGravar";
            this.btnGravar.Size = new System.Drawing.Size(69, 23);
            this.btnGravar.TabIndex = 5;
            this.btnGravar.Text = "Gravar";
            this.btnGravar.UseVisualStyleBackColor = true;
            this.btnGravar.Click += new System.EventHandler(this.btnGravar_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(12, 9);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(58, 20);
            this.label9.TabIndex = 13;
            this.label9.Text = "Pedido";
            // 
            // txtPedidoNumero
            // 
            this.txtPedidoNumero.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPedidoNumero.HideSelection = false;
            this.txtPedidoNumero.Location = new System.Drawing.Point(70, 9);
            this.txtPedidoNumero.Name = "txtPedidoNumero";
            this.txtPedidoNumero.ReadOnly = true;
            this.txtPedidoNumero.Size = new System.Drawing.Size(41, 20);
            this.txtPedidoNumero.TabIndex = 14;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label13.ForeColor = System.Drawing.Color.Black;
            this.label13.Location = new System.Drawing.Point(13, 423);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(44, 20);
            this.label13.TabIndex = 15;
            this.label13.Text = "Total";
            // 
            // txtTotal
            // 
            this.txtTotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTotal.Location = new System.Drawing.Point(57, 423);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.ReadOnly = true;
            this.txtTotal.ShortcutsEnabled = false;
            this.txtTotal.Size = new System.Drawing.Size(112, 20);
            this.txtTotal.TabIndex = 16;
            // 
            // btnConsultaPedido
            // 
            this.btnConsultaPedido.Location = new System.Drawing.Point(125, 9);
            this.btnConsultaPedido.Name = "btnConsultaPedido";
            this.btnConsultaPedido.Size = new System.Drawing.Size(65, 20);
            this.btnConsultaPedido.TabIndex = 17;
            this.btnConsultaPedido.Text = "Consultar";
            this.btnConsultaPedido.UseVisualStyleBackColor = true;
            this.btnConsultaPedido.Click += new System.EventHandler(this.btnConsultaPedido_Click);
            // 
            // txtObservacao
            // 
            this.txtObservacao.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtObservacao.HideSelection = false;
            this.txtObservacao.Location = new System.Drawing.Point(70, 35);
            this.txtObservacao.Name = "txtObservacao";
            this.txtObservacao.Size = new System.Drawing.Size(347, 20);
            this.txtObservacao.TabIndex = 18;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(31, 33);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 20);
            this.label5.TabIndex = 19;
            this.label5.Text = "Obs";
            // 
            // btnExcluir
            // 
            this.btnExcluir.ForeColor = System.Drawing.Color.Crimson;
            this.btnExcluir.Location = new System.Drawing.Point(639, 423);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(55, 23);
            this.btnExcluir.TabIndex = 20;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // Venda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(864, 502);
            this.ControlBox = false;
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.txtClienteVenda);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.txtNomeClienteVenda);
            this.Controls.Add(this.btnNovo);
            this.Controls.Add(this.txtObservacao);
            this.Controls.Add(this.txtPedidoNumero);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnGravar);
            this.Controls.Add(this.btnConsultaPedido);
            this.Controls.Add(this.TabVenda);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtTotal);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.btnConsultaCliente);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "Venda";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Venda";
            this.TabVenda.ResumeLayout(false);
            this.tabProduto.ResumeLayout(false);
            this.tabProduto.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgProdutos)).EndInit();
            this.tabEntretenimento.ResumeLayout(false);
            this.tabEntretenimento.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgEntretenimento)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtClienteVenda;
        private System.Windows.Forms.TextBox txtNomeClienteVenda;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.Button btnConsultaCliente;
        private System.Windows.Forms.TabControl TabVenda;
        private System.Windows.Forms.TabPage tabProduto;
        private System.Windows.Forms.TabPage tabEntretenimento;
        private System.Windows.Forms.TextBox txtValorEntretenimento;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtQuantidadeEntretenimento;
        public System.Windows.Forms.Button btnExcluirEntretenimento;
        public System.Windows.Forms.Button btnInserirEntretenimento;
        public System.Windows.Forms.Button btnConsultaEntretenimento;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtEntretenimento;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnNovo;
        private System.Windows.Forms.Button btnGravar;
        private System.Windows.Forms.Label labelNomeProduto;
        private System.Windows.Forms.TextBox txtValorProdutoVenda;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtQuantidadeProdutoVenda;
        public System.Windows.Forms.Button btnExcluirProduto;
        public System.Windows.Forms.Button btnInserirProduto;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtProdutoVenda;
        public System.Windows.Forms.Button btnConsultaProduto;
        private System.Windows.Forms.Label labelEntretenimentoNome;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtPedidoNumero;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtTotal;
        public System.Windows.Forms.Button btnConsultaPedido;
        private System.Windows.Forms.TextBox txtObservacao;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.DataGridView dgProdutos;
        private System.Windows.Forms.DataGridView dgEntretenimento;
    }
}

