namespace SysShop.Forms
{
    partial class ErroDialog
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
            this.btnOk = new System.Windows.Forms.Button();
            this.pbxIcone = new System.Windows.Forms.PictureBox();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.tbxTexto = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbxIcone)).BeginInit();
            this.SuspendLayout();
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(205, 150);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(75, 23);
            this.btnOk.TabIndex = 0;
            this.btnOk.Text = "Ok";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // pbxIcone
            // 
            this.pbxIcone.Image = global::SysShop.Forms.Properties.Resources.warning_145066_640;
            this.pbxIcone.InitialImage = null;
            this.pbxIcone.Location = new System.Drawing.Point(12, 22);
            this.pbxIcone.Name = "pbxIcone";
            this.pbxIcone.Size = new System.Drawing.Size(126, 119);
            this.pbxIcone.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxIcone.TabIndex = 1;
            this.pbxIcone.TabStop = false;
            // 
            // lblTitulo
            // 
            this.lblTitulo.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lblTitulo.Location = new System.Drawing.Point(144, 22);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(70, 25);
            this.lblTitulo.TabIndex = 2;
            this.lblTitulo.Text = "Aviso";
            this.lblTitulo.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // tbxTexto
            // 
            this.tbxTexto.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbxTexto.Location = new System.Drawing.Point(144, 50);
            this.tbxTexto.Multiline = true;
            this.tbxTexto.Name = "tbxTexto";
            this.tbxTexto.ReadOnly = true;
            this.tbxTexto.Size = new System.Drawing.Size(303, 91);
            this.tbxTexto.TabIndex = 3;
            // 
            // ErroDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(459, 185);
            this.Controls.Add(this.tbxTexto);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.pbxIcone);
            this.Controls.Add(this.btnOk);
            this.Name = "ErroDialog";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Aviso";
            ((System.ComponentModel.ISupportInitialize)(this.pbxIcone)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.PictureBox pbxIcone;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.TextBox tbxTexto;
    }
}