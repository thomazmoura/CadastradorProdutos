using SysShop.Forms.UserControls;
namespace SysShop.Forms
{
    partial class EdicaoProdutoJanela
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
            this.cadastroProdutoUC = new CadastroProduto();
            this.SuspendLayout();
            // 
            // cadastroProdutoUC
            // 
            this.cadastroProdutoUC.AutoSize = true;
            this.cadastroProdutoUC.Location = new System.Drawing.Point(12, 12);
            this.cadastroProdutoUC.Name = "cadastroProdutoUC";
            this.cadastroProdutoUC.Size = new System.Drawing.Size(253, 113);
            this.cadastroProdutoUC.TabIndex = 0;
            // 
            // EdicaoProdutoJanela
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(281, 138);
            this.Controls.Add(this.cadastroProdutoUC);
            this.Name = "EdicaoProdutoJanela";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Edição Produto";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CadastroProduto cadastroProdutoUC;
    }
}