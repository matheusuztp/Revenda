namespace Barzinho
{
    partial class CadProduto
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
            this.label4 = new System.Windows.Forms.Label();
            this.txtUnidadeProduto = new System.Windows.Forms.TextBox();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.btnNovo = new System.Windows.Forms.Button();
            this.txtValorProduto = new System.Windows.Forms.TextBox();
            this.btnGravar = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.radioBedida = new System.Windows.Forms.RadioButton();
            this.btnConsulta = new System.Windows.Forms.Button();
            this.radioDoce = new System.Windows.Forms.RadioButton();
            this.txtCodigoProduto = new System.Windows.Forms.TextBox();
            this.radioPetisco = new System.Windows.Forms.RadioButton();
            this.label5 = new System.Windows.Forms.Label();
            this.txtVolumeProduto = new System.Windows.Forms.TextBox();
            this.txtEstoqueProduto = new System.Windows.Forms.TextBox();
            this.labelVolume = new System.Windows.Forms.Label();
            this.txtDescricaoProduto = new System.Windows.Forms.TextBox();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label4.Location = new System.Drawing.Point(17, 41);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 17);
            this.label4.TabIndex = 1;
            this.label4.Text = "Descrição";
            // 
            // txtUnidadeProduto
            // 
            this.txtUnidadeProduto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtUnidadeProduto.Location = new System.Drawing.Point(88, 67);
            this.txtUnidadeProduto.Name = "txtUnidadeProduto";
            this.txtUnidadeProduto.Size = new System.Drawing.Size(39, 20);
            this.txtUnidadeProduto.TabIndex = 4;
            // 
            // btnCancelar
            // 
            this.btnCancelar.ForeColor = System.Drawing.Color.Red;
            this.btnCancelar.Location = new System.Drawing.Point(426, 93);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(44, 23);
            this.btnCancelar.TabIndex = 16;
            this.btnCancelar.Text = "Sair";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label2.Location = new System.Drawing.Point(27, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Unidade";
            // 
            // btnNovo
            // 
            this.btnNovo.ForeColor = System.Drawing.Color.ForestGreen;
            this.btnNovo.Location = new System.Drawing.Point(221, 93);
            this.btnNovo.Name = "btnNovo";
            this.btnNovo.Size = new System.Drawing.Size(69, 23);
            this.btnNovo.TabIndex = 14;
            this.btnNovo.Text = "Novo";
            this.btnNovo.UseVisualStyleBackColor = true;
            this.btnNovo.Click += new System.EventHandler(this.btnNovo_Click);
            // 
            // txtValorProduto
            // 
            this.txtValorProduto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtValorProduto.Location = new System.Drawing.Point(378, 67);
            this.txtValorProduto.Name = "txtValorProduto";
            this.txtValorProduto.Size = new System.Drawing.Size(92, 20);
            this.txtValorProduto.TabIndex = 8;
            this.txtValorProduto.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtValorProduto.Leave += new System.EventHandler(this.txtValorProduto_Leave);
            // 
            // btnGravar
            // 
            this.btnGravar.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.btnGravar.Location = new System.Drawing.Point(352, 93);
            this.btnGravar.Name = "btnGravar";
            this.btnGravar.Size = new System.Drawing.Size(69, 23);
            this.btnGravar.TabIndex = 15;
            this.btnGravar.Text = "Gravar";
            this.btnGravar.UseVisualStyleBackColor = true;
            this.btnGravar.Click += new System.EventHandler(this.btnGravar_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label3.Location = new System.Drawing.Point(335, 68);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 17);
            this.label3.TabIndex = 7;
            this.label3.Text = "Valor";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label1.Location = new System.Drawing.Point(17, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(21, 17);
            this.label1.TabIndex = 17;
            this.label1.Text = "ID";
            // 
            // radioBedida
            // 
            this.radioBedida.AutoSize = true;
            this.radioBedida.Checked = true;
            this.radioBedida.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.radioBedida.Location = new System.Drawing.Point(12, 95);
            this.radioBedida.Name = "radioBedida";
            this.radioBedida.Size = new System.Drawing.Size(70, 21);
            this.radioBedida.TabIndex = 11;
            this.radioBedida.TabStop = true;
            this.radioBedida.Text = "Bebida";
            this.radioBedida.UseVisualStyleBackColor = true;
            this.radioBedida.CheckedChanged += new System.EventHandler(this.radioBedida_CheckedChanged);
            // 
            // btnConsulta
            // 
            this.btnConsulta.ForeColor = System.Drawing.Color.Black;
            this.btnConsulta.Location = new System.Drawing.Point(88, 9);
            this.btnConsulta.Name = "btnConsulta";
            this.btnConsulta.Size = new System.Drawing.Size(69, 23);
            this.btnConsulta.TabIndex = 0;
            this.btnConsulta.Text = "Consultar";
            this.btnConsulta.UseVisualStyleBackColor = true;
            this.btnConsulta.Click += new System.EventHandler(this.btnConsulta_Click);
            // 
            // radioDoce
            // 
            this.radioDoce.AutoSize = true;
            this.radioDoce.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.radioDoce.Location = new System.Drawing.Point(88, 95);
            this.radioDoce.Name = "radioDoce";
            this.radioDoce.Size = new System.Drawing.Size(59, 21);
            this.radioDoce.TabIndex = 12;
            this.radioDoce.Text = "Doce";
            this.radioDoce.UseVisualStyleBackColor = true;
            this.radioDoce.CheckedChanged += new System.EventHandler(this.radioBedida_CheckedChanged);
            // 
            // txtCodigoProduto
            // 
            this.txtCodigoProduto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCodigoProduto.Location = new System.Drawing.Point(38, 12);
            this.txtCodigoProduto.Name = "txtCodigoProduto";
            this.txtCodigoProduto.ReadOnly = true;
            this.txtCodigoProduto.Size = new System.Drawing.Size(39, 20);
            this.txtCodigoProduto.TabIndex = 18;
            // 
            // radioPetisco
            // 
            this.radioPetisco.AutoSize = true;
            this.radioPetisco.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.radioPetisco.Location = new System.Drawing.Point(148, 95);
            this.radioPetisco.Name = "radioPetisco";
            this.radioPetisco.Size = new System.Drawing.Size(72, 21);
            this.radioPetisco.TabIndex = 13;
            this.radioPetisco.Text = "Petisco";
            this.radioPetisco.UseVisualStyleBackColor = true;
            this.radioPetisco.CheckedChanged += new System.EventHandler(this.radioBedida_CheckedChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label5.Location = new System.Drawing.Point(256, 15);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(122, 17);
            this.label5.TabIndex = 9;
            this.label5.Text = "Saldo em estoque";
            // 
            // txtVolumeProduto
            // 
            this.txtVolumeProduto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtVolumeProduto.Enabled = false;
            this.txtVolumeProduto.Location = new System.Drawing.Point(185, 67);
            this.txtVolumeProduto.Name = "txtVolumeProduto";
            this.txtVolumeProduto.Size = new System.Drawing.Size(92, 20);
            this.txtVolumeProduto.TabIndex = 6;
            this.txtVolumeProduto.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtVolumeProduto.Leave += new System.EventHandler(this.txtVolumeProduto_Leave);
            // 
            // txtEstoqueProduto
            // 
            this.txtEstoqueProduto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtEstoqueProduto.Location = new System.Drawing.Point(378, 14);
            this.txtEstoqueProduto.Name = "txtEstoqueProduto";
            this.txtEstoqueProduto.Size = new System.Drawing.Size(92, 20);
            this.txtEstoqueProduto.TabIndex = 10;
            this.txtEstoqueProduto.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtEstoqueProduto.Leave += new System.EventHandler(this.txtEstoqueProduto_Leave);
            // 
            // labelVolume
            // 
            this.labelVolume.AutoSize = true;
            this.labelVolume.Enabled = false;
            this.labelVolume.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.labelVolume.Location = new System.Drawing.Point(130, 68);
            this.labelVolume.Name = "labelVolume";
            this.labelVolume.Size = new System.Drawing.Size(55, 17);
            this.labelVolume.TabIndex = 5;
            this.labelVolume.Text = "Volume";
            // 
            // txtDescricaoProduto
            // 
            this.txtDescricaoProduto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDescricaoProduto.Location = new System.Drawing.Point(88, 40);
            this.txtDescricaoProduto.Name = "txtDescricaoProduto";
            this.txtDescricaoProduto.Size = new System.Drawing.Size(382, 20);
            this.txtDescricaoProduto.TabIndex = 2;
            // 
            // btnExcluir
            // 
            this.btnExcluir.ForeColor = System.Drawing.Color.Crimson;
            this.btnExcluir.Location = new System.Drawing.Point(296, 93);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(51, 23);
            this.btnExcluir.TabIndex = 19;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // CadProduto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(493, 157);
            this.ControlBox = false;
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.txtDescricaoProduto);
            this.Controls.Add(this.btnConsulta);
            this.Controls.Add(this.labelVolume);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtEstoqueProduto);
            this.Controls.Add(this.txtUnidadeProduto);
            this.Controls.Add(this.txtVolumeProduto);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.radioPetisco);
            this.Controls.Add(this.btnNovo);
            this.Controls.Add(this.txtCodigoProduto);
            this.Controls.Add(this.txtValorProduto);
            this.Controls.Add(this.radioDoce);
            this.Controls.Add(this.btnGravar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.radioBedida);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CadProduto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Cadastro de produto";
            this.Load += new System.EventHandler(this.CadProduto_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtUnidadeProduto;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnNovo;
        private System.Windows.Forms.TextBox txtValorProduto;
        private System.Windows.Forms.Button btnGravar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton radioBedida;
        private System.Windows.Forms.Button btnConsulta;
        private System.Windows.Forms.RadioButton radioDoce;
        private System.Windows.Forms.TextBox txtCodigoProduto;
        private System.Windows.Forms.RadioButton radioPetisco;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtVolumeProduto;
        private System.Windows.Forms.TextBox txtEstoqueProduto;
        private System.Windows.Forms.Label labelVolume;
        private System.Windows.Forms.TextBox txtDescricaoProduto;
        private System.Windows.Forms.Button btnExcluir;
    }
}