namespace Barzinho
{
    partial class CadEntretenimento
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
            this.btnSair = new System.Windows.Forms.Button();
            this.txtValorEntretenimento = new System.Windows.Forms.TextBox();
            this.btnNovo = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.btnGravar = new System.Windows.Forms.Button();
            this.txtTempo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.labelTempo = new System.Windows.Forms.Label();
            this.btnConsulta = new System.Windows.Forms.Button();
            this.labelMinutos = new System.Windows.Forms.Label();
            this.txtCodigoEntretenimento = new System.Windows.Forms.TextBox();
            this.cbTempo = new System.Windows.Forms.CheckBox();
            this.txtDescricaoEntretenimento = new System.Windows.Forms.TextBox();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label4.Location = new System.Drawing.Point(10, 49);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 17);
            this.label4.TabIndex = 1;
            this.label4.Text = "Descrição";
            // 
            // btnSair
            // 
            this.btnSair.ForeColor = System.Drawing.Color.Red;
            this.btnSair.Location = new System.Drawing.Point(417, 74);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(44, 23);
            this.btnSair.TabIndex = 9;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // txtValorEntretenimento
            // 
            this.txtValorEntretenimento.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtValorEntretenimento.Location = new System.Drawing.Point(81, 76);
            this.txtValorEntretenimento.Name = "txtValorEntretenimento";
            this.txtValorEntretenimento.Size = new System.Drawing.Size(102, 20);
            this.txtValorEntretenimento.TabIndex = 6;
            this.txtValorEntretenimento.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btnNovo
            // 
            this.btnNovo.ForeColor = System.Drawing.Color.ForestGreen;
            this.btnNovo.Location = new System.Drawing.Point(213, 74);
            this.btnNovo.Name = "btnNovo";
            this.btnNovo.Size = new System.Drawing.Size(69, 23);
            this.btnNovo.TabIndex = 7;
            this.btnNovo.Text = "Novo";
            this.btnNovo.UseVisualStyleBackColor = true;
            this.btnNovo.Click += new System.EventHandler(this.btnNovo_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label3.Location = new System.Drawing.Point(40, 77);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "Valor";
            // 
            // btnGravar
            // 
            this.btnGravar.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.btnGravar.Location = new System.Drawing.Point(345, 74);
            this.btnGravar.Name = "btnGravar";
            this.btnGravar.Size = new System.Drawing.Size(69, 23);
            this.btnGravar.TabIndex = 8;
            this.btnGravar.Text = "Gravar";
            this.btnGravar.UseVisualStyleBackColor = true;
            this.btnGravar.Click += new System.EventHandler(this.btnGravar_Click);
            // 
            // txtTempo
            // 
            this.txtTempo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTempo.Location = new System.Drawing.Point(359, 19);
            this.txtTempo.Name = "txtTempo";
            this.txtTempo.Size = new System.Drawing.Size(44, 20);
            this.txtTempo.TabIndex = 4;
            this.txtTempo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label1.Location = new System.Drawing.Point(13, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(21, 17);
            this.label1.TabIndex = 10;
            this.label1.Text = "ID";
            // 
            // labelTempo
            // 
            this.labelTempo.AutoSize = true;
            this.labelTempo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.labelTempo.Location = new System.Drawing.Point(307, 20);
            this.labelTempo.Name = "labelTempo";
            this.labelTempo.Size = new System.Drawing.Size(52, 17);
            this.labelTempo.TabIndex = 3;
            this.labelTempo.Text = "Tempo";
            // 
            // btnConsulta
            // 
            this.btnConsulta.ForeColor = System.Drawing.Color.Black;
            this.btnConsulta.Location = new System.Drawing.Point(81, 18);
            this.btnConsulta.Name = "btnConsulta";
            this.btnConsulta.Size = new System.Drawing.Size(69, 23);
            this.btnConsulta.TabIndex = 0;
            this.btnConsulta.Text = "Consultar";
            this.btnConsulta.UseVisualStyleBackColor = true;
            this.btnConsulta.Click += new System.EventHandler(this.btnConsulta_Click);
            // 
            // labelMinutos
            // 
            this.labelMinutos.AutoSize = true;
            this.labelMinutos.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.labelMinutos.Location = new System.Drawing.Point(403, 20);
            this.labelMinutos.Name = "labelMinutos";
            this.labelMinutos.Size = new System.Drawing.Size(57, 17);
            this.labelMinutos.TabIndex = 12;
            this.labelMinutos.Text = "Minutos";
            // 
            // txtCodigoEntretenimento
            // 
            this.txtCodigoEntretenimento.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCodigoEntretenimento.Location = new System.Drawing.Point(34, 19);
            this.txtCodigoEntretenimento.Name = "txtCodigoEntretenimento";
            this.txtCodigoEntretenimento.ReadOnly = true;
            this.txtCodigoEntretenimento.Size = new System.Drawing.Size(39, 20);
            this.txtCodigoEntretenimento.TabIndex = 11;
            // 
            // cbTempo
            // 
            this.cbTempo.AutoSize = true;
            this.cbTempo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.cbTempo.Location = new System.Drawing.Point(179, 20);
            this.cbTempo.Name = "cbTempo";
            this.cbTempo.Size = new System.Drawing.Size(109, 21);
            this.cbTempo.TabIndex = 13;
            this.cbTempo.Text = "Ficha/Tempo";
            this.cbTempo.UseVisualStyleBackColor = true;
            this.cbTempo.CheckedChanged += new System.EventHandler(this.cbTempo_CheckedChanged);
            // 
            // txtDescricaoEntretenimento
            // 
            this.txtDescricaoEntretenimento.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDescricaoEntretenimento.Location = new System.Drawing.Point(81, 48);
            this.txtDescricaoEntretenimento.Name = "txtDescricaoEntretenimento";
            this.txtDescricaoEntretenimento.Size = new System.Drawing.Size(380, 20);
            this.txtDescricaoEntretenimento.TabIndex = 2;
            // 
            // btnExcluir
            // 
            this.btnExcluir.ForeColor = System.Drawing.Color.Crimson;
            this.btnExcluir.Location = new System.Drawing.Point(287, 74);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(52, 23);
            this.btnExcluir.TabIndex = 14;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // CadEntretenimento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(490, 142);
            this.ControlBox = false;
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.txtDescricaoEntretenimento);
            this.Controls.Add(this.txtCodigoEntretenimento);
            this.Controls.Add(this.cbTempo);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.labelMinutos);
            this.Controls.Add(this.txtValorEntretenimento);
            this.Controls.Add(this.btnConsulta);
            this.Controls.Add(this.btnNovo);
            this.Controls.Add(this.labelTempo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnGravar);
            this.Controls.Add(this.txtTempo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CadEntretenimento";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Cadastro de Entretenimento";
            this.Load += new System.EventHandler(this.CadEntretenimento_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.TextBox txtValorEntretenimento;
        private System.Windows.Forms.Button btnNovo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnGravar;
        private System.Windows.Forms.TextBox txtTempo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelTempo;
        private System.Windows.Forms.Button btnConsulta;
        private System.Windows.Forms.Label labelMinutos;
        private System.Windows.Forms.TextBox txtCodigoEntretenimento;
        private System.Windows.Forms.CheckBox cbTempo;
        private System.Windows.Forms.TextBox txtDescricaoEntretenimento;
        private System.Windows.Forms.Button btnExcluir;
    }
}