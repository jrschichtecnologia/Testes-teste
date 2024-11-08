namespace WorkflowSolicitacao
{
    partial class Form1
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
            this.btnFormSolicitacao = new System.Windows.Forms.Button();
            this.rdbOperacional = new System.Windows.Forms.RadioButton();
            this.rdbFinanceiro = new System.Windows.Forms.RadioButton();
            this.txtNroConta = new System.Windows.Forms.TextBox();
            this.lblNroConta = new System.Windows.Forms.Label();
            this.rdbFinanceiroMaster = new System.Windows.Forms.RadioButton();
            this.btnConsulta = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnFormSolicitacao
            // 
            this.btnFormSolicitacao.Location = new System.Drawing.Point(47, 119);
            this.btnFormSolicitacao.Name = "btnFormSolicitacao";
            this.btnFormSolicitacao.Size = new System.Drawing.Size(143, 49);
            this.btnFormSolicitacao.TabIndex = 0;
            this.btnFormSolicitacao.Text = "Solicitação";
            this.btnFormSolicitacao.UseVisualStyleBackColor = true;
            this.btnFormSolicitacao.Click += new System.EventHandler(this.btnFormSolicitacao_Click);
            // 
            // rdbOperacional
            // 
            this.rdbOperacional.AutoSize = true;
            this.rdbOperacional.Location = new System.Drawing.Point(47, 27);
            this.rdbOperacional.Name = "rdbOperacional";
            this.rdbOperacional.Size = new System.Drawing.Size(136, 20);
            this.rdbOperacional.TabIndex = 1;
            this.rdbOperacional.TabStop = true;
            this.rdbOperacional.Text = "OP - WORKFLOW";
            this.rdbOperacional.UseVisualStyleBackColor = true;
            // 
            // rdbFinanceiro
            // 
            this.rdbFinanceiro.AutoSize = true;
            this.rdbFinanceiro.Location = new System.Drawing.Point(205, 27);
            this.rdbFinanceiro.Name = "rdbFinanceiro";
            this.rdbFinanceiro.Size = new System.Drawing.Size(128, 20);
            this.rdbFinanceiro.TabIndex = 2;
            this.rdbFinanceiro.TabStop = true;
            this.rdbFinanceiro.Text = "FI - WORKFLOW";
            this.rdbFinanceiro.UseVisualStyleBackColor = true;
            // 
            // txtNroConta
            // 
            this.txtNroConta.Location = new System.Drawing.Point(50, 73);
            this.txtNroConta.Name = "txtNroConta";
            this.txtNroConta.Size = new System.Drawing.Size(152, 22);
            this.txtNroConta.TabIndex = 3;
            // 
            // lblNroConta
            // 
            this.lblNroConta.AutoSize = true;
            this.lblNroConta.Location = new System.Drawing.Point(47, 54);
            this.lblNroConta.Name = "lblNroConta";
            this.lblNroConta.Size = new System.Drawing.Size(70, 16);
            this.lblNroConta.TabIndex = 4;
            this.lblNroConta.Text = "Nro. Conta";
            // 
            // rdbFinanceiroMaster
            // 
            this.rdbFinanceiroMaster.AutoSize = true;
            this.rdbFinanceiroMaster.Location = new System.Drawing.Point(357, 27);
            this.rdbFinanceiroMaster.Name = "rdbFinanceiroMaster";
            this.rdbFinanceiroMaster.Size = new System.Drawing.Size(188, 20);
            this.rdbFinanceiroMaster.TabIndex = 5;
            this.rdbFinanceiroMaster.TabStop = true;
            this.rdbFinanceiroMaster.Text = "FI - WORKFLOW MASTER";
            this.rdbFinanceiroMaster.UseVisualStyleBackColor = true;
            // 
            // btnConsulta
            // 
            this.btnConsulta.Location = new System.Drawing.Point(232, 119);
            this.btnConsulta.Name = "btnConsulta";
            this.btnConsulta.Size = new System.Drawing.Size(143, 49);
            this.btnConsulta.TabIndex = 6;
            this.btnConsulta.Text = "Consulta";
            this.btnConsulta.UseVisualStyleBackColor = true;
            this.btnConsulta.Click += new System.EventHandler(this.btnConsulta_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnConsulta);
            this.Controls.Add(this.rdbFinanceiroMaster);
            this.Controls.Add(this.lblNroConta);
            this.Controls.Add(this.txtNroConta);
            this.Controls.Add(this.rdbFinanceiro);
            this.Controls.Add(this.rdbOperacional);
            this.Controls.Add(this.btnFormSolicitacao);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnFormSolicitacao;
        private System.Windows.Forms.RadioButton rdbOperacional;
        private System.Windows.Forms.RadioButton rdbFinanceiro;
        private System.Windows.Forms.TextBox txtNroConta;
        private System.Windows.Forms.Label lblNroConta;
        private System.Windows.Forms.RadioButton rdbFinanceiroMaster;
        private System.Windows.Forms.Button btnConsulta;
    }
}

