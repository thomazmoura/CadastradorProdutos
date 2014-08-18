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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.produtosGridView = new System.Windows.Forms.DataGridView();
            this.btnDetalhes = new System.Windows.Forms.Button();
            this.btnDeletar = new System.Windows.Forms.Button();
            this.tbxVoltar = new System.Windows.Forms.Button();
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
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.produtosGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.produtosGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.produtosGridView.DefaultCellStyle = dataGridViewCellStyle5;
            this.produtosGridView.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.produtosGridView.Location = new System.Drawing.Point(12, 41);
            this.produtosGridView.MultiSelect = false;
            this.produtosGridView.Name = "produtosGridView";
            this.produtosGridView.ReadOnly = true;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.produtosGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.produtosGridView.Size = new System.Drawing.Size(504, 316);
            this.produtosGridView.TabIndex = 2;
            // 
            // btnDetalhes
            // 
            this.btnDetalhes.Location = new System.Drawing.Point(279, 12);
            this.btnDetalhes.Name = "btnDetalhes";
            this.btnDetalhes.Size = new System.Drawing.Size(75, 23);
            this.btnDetalhes.TabIndex = 3;
            this.btnDetalhes.Text = "Detalhes";
            this.btnDetalhes.UseVisualStyleBackColor = true;
            this.btnDetalhes.Click += new System.EventHandler(this.btnDetalhes_Click);
            // 
            // btnDeletar
            // 
            this.btnDeletar.Location = new System.Drawing.Point(360, 12);
            this.btnDeletar.Name = "btnDeletar";
            this.btnDeletar.Size = new System.Drawing.Size(75, 23);
            this.btnDeletar.TabIndex = 4;
            this.btnDeletar.Text = "Deletar";
            this.btnDeletar.UseVisualStyleBackColor = true;
            this.btnDeletar.Click += new System.EventHandler(this.btnDeletar_Click);
            // 
            // tbxVoltar
            // 
            this.tbxVoltar.Location = new System.Drawing.Point(441, 12);
            this.tbxVoltar.Name = "tbxVoltar";
            this.tbxVoltar.Size = new System.Drawing.Size(75, 23);
            this.tbxVoltar.TabIndex = 5;
            this.tbxVoltar.Text = "Voltar";
            this.tbxVoltar.UseVisualStyleBackColor = true;
            this.tbxVoltar.Click += new System.EventHandler(this.tbxVoltar_Click);
            // 
            // ConsultaProdutosDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.tbxVoltar;
            this.ClientSize = new System.Drawing.Size(528, 369);
            this.Controls.Add(this.tbxVoltar);
            this.Controls.Add(this.btnDeletar);
            this.Controls.Add(this.produtosGridView);
            this.Controls.Add(this.btnDetalhes);
            this.Name = "ConsultaProdutosDialog";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "ConsultaProdutosDialog";
            ((System.ComponentModel.ISupportInitialize)(this.produtosGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView produtosGridView;
        private System.Windows.Forms.Button btnDetalhes;
        private System.Windows.Forms.Button btnDeletar;
        private System.Windows.Forms.Button tbxVoltar;
    }
}