namespace SysShop.Forms
{
    partial class CadastroProdutoDialog
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
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnOk = new System.Windows.Forms.Button();
            this.lblPreco = new System.Windows.Forms.Label();
            this.lblDescricao = new System.Windows.Forms.Label();
            this.tbxPreco = new System.Windows.Forms.TextBox();
            this.lblNome = new System.Windows.Forms.Label();
            this.tbxDescricao = new System.Windows.Forms.TextBox();
            this.tbxNome = new System.Windows.Forms.TextBox();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnLimpar
            // 
            this.btnLimpar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnLimpar.Location = new System.Drawing.Point(107, 135);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(81, 23);
            this.btnLimpar.TabIndex = 12;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(26, 135);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(75, 23);
            this.btnOk.TabIndex = 10;
            this.btnOk.Text = "Gravar";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // lblPreco
            // 
            this.lblPreco.AutoSize = true;
            this.lblPreco.Location = new System.Drawing.Point(23, 74);
            this.lblPreco.Name = "lblPreco";
            this.lblPreco.Size = new System.Drawing.Size(35, 13);
            this.lblPreco.TabIndex = 13;
            this.lblPreco.Text = "Preço";
            // 
            // lblDescricao
            // 
            this.lblDescricao.AutoSize = true;
            this.lblDescricao.Location = new System.Drawing.Point(23, 48);
            this.lblDescricao.Name = "lblDescricao";
            this.lblDescricao.Size = new System.Drawing.Size(55, 13);
            this.lblDescricao.TabIndex = 11;
            this.lblDescricao.Text = "Descrição";
            // 
            // tbxPreco
            // 
            this.tbxPreco.Location = new System.Drawing.Point(88, 71);
            this.tbxPreco.Name = "tbxPreco";
            this.tbxPreco.Size = new System.Drawing.Size(169, 20);
            this.tbxPreco.TabIndex = 9;
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(23, 22);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(35, 13);
            this.lblNome.TabIndex = 7;
            this.lblNome.Text = "Nome";
            // 
            // tbxDescricao
            // 
            this.tbxDescricao.Location = new System.Drawing.Point(88, 45);
            this.tbxDescricao.Name = "tbxDescricao";
            this.tbxDescricao.Size = new System.Drawing.Size(169, 20);
            this.tbxDescricao.TabIndex = 8;
            // 
            // tbxNome
            // 
            this.tbxNome.Location = new System.Drawing.Point(88, 19);
            this.tbxNome.Name = "tbxNome";
            this.tbxNome.Size = new System.Drawing.Size(169, 20);
            this.tbxNome.TabIndex = 6;
            // 
            // btnVoltar
            // 
            this.btnVoltar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnVoltar.Location = new System.Drawing.Point(194, 135);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(75, 23);
            this.btnVoltar.TabIndex = 14;
            this.btnVoltar.Text = "Voltar";
            this.btnVoltar.UseVisualStyleBackColor = true;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // CadastroProdutoDialog
            // 
            this.AcceptButton = this.btnOk;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnVoltar;
            this.ClientSize = new System.Drawing.Size(281, 170);
            this.Controls.Add(this.btnVoltar);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.lblPreco);
            this.Controls.Add(this.lblDescricao);
            this.Controls.Add(this.tbxPreco);
            this.Controls.Add(this.lblNome);
            this.Controls.Add(this.tbxDescricao);
            this.Controls.Add(this.tbxNome);
            this.Name = "CadastroProdutoDialog";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Cadastro de Produto";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnLimpar;
        public System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Label lblPreco;
        private System.Windows.Forms.Label lblDescricao;
        private System.Windows.Forms.TextBox tbxPreco;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.TextBox tbxDescricao;
        private System.Windows.Forms.TextBox tbxNome;
        private System.Windows.Forms.Button btnVoltar;

    }
}