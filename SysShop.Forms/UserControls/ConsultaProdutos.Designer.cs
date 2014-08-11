namespace SysShop.Forms.UserControls
{
    partial class ConsultaProdutos
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnDetalhes = new System.Windows.Forms.Button();
            this.produtosGridView = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.produtosGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // btnDetalhes
            // 
            this.btnDetalhes.Location = new System.Drawing.Point(330, 3);
            this.btnDetalhes.Name = "btnDetalhes";
            this.btnDetalhes.Size = new System.Drawing.Size(75, 23);
            this.btnDetalhes.TabIndex = 1;
            this.btnDetalhes.Text = "Detalhes";
            this.btnDetalhes.UseVisualStyleBackColor = true;
            this.btnDetalhes.Click += new System.EventHandler(this.btnDetalhes_Click);
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
            this.produtosGridView.Location = new System.Drawing.Point(0, 29);
            this.produtosGridView.MultiSelect = false;
            this.produtosGridView.Name = "produtosGridView";
            this.produtosGridView.ReadOnly = true;
            this.produtosGridView.Size = new System.Drawing.Size(405, 272);
            this.produtosGridView.TabIndex = 0;
            // 
            // ConsultaProdutos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.produtosGridView);
            this.Controls.Add(this.btnDetalhes);
            this.Name = "ConsultaProdutos";
            this.Size = new System.Drawing.Size(408, 304);
            ((System.ComponentModel.ISupportInitialize)(this.produtosGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnDetalhes;
        private System.Windows.Forms.DataGridView produtosGridView;
    }
}
