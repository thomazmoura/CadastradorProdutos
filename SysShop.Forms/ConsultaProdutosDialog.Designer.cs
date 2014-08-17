namespace SysShop.Forms
{
    partial class ConsultaProdutosDialog
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
            this.produtosGridView = new System.Windows.Forms.DataGridView();
            this.btnDetalhes = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.produtosGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // produtosGridView
            // 
            this.produtosGridView.AllowUserToAddRows = false;
            this.produtosGridView.AllowUserToDeleteRows = false;
            this.produtosGridView.AllowUserToOrderColumns = true;
            this.produtosGridView.AllowUserToResizeRows = false;
            this.produtosGridView.CausesValidation = false;
            this.produtosGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.produtosGridView.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.produtosGridView.Location = new System.Drawing.Point(12, 41);
            this.produtosGridView.MultiSelect = false;
            this.produtosGridView.Name = "produtosGridView";
            this.produtosGridView.ReadOnly = true;
            this.produtosGridView.Size = new System.Drawing.Size(504, 316);
            this.produtosGridView.TabIndex = 2;
            // 
            // btnDetalhes
            // 
            this.btnDetalhes.Location = new System.Drawing.Point(441, 12);
            this.btnDetalhes.Name = "btnDetalhes";
            this.btnDetalhes.Size = new System.Drawing.Size(75, 23);
            this.btnDetalhes.TabIndex = 3;
            this.btnDetalhes.Text = "Detalhes";
            this.btnDetalhes.UseVisualStyleBackColor = true;
            // 
            // ConsultaProdutosDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(528, 369);
            this.Controls.Add(this.produtosGridView);
            this.Controls.Add(this.btnDetalhes);
            this.Name = "ConsultaProdutosDialog";
            this.Text = "ConsultaProdutosDialog";
            ((System.ComponentModel.ISupportInitialize)(this.produtosGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView produtosGridView;
        private System.Windows.Forms.Button btnDetalhes;
    }
}