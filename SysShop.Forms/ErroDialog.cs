using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SysShop.Forms
{
    public partial class ErroDialog : Form
    {
        /// <summary> Janela modal personalizada para exibição de erros. </summary>
        /// <param name="titulo"> Título da janela. </param>
        /// <param name="texto"> Descrição do erro. </param>
        public ErroDialog(string titulo, string texto)
        {
            InitializeComponent();

            lblTitulo.Text = titulo;
            tbxTexto.Text = texto;
        }

        /// <summary> Evento do clique do botão "Ok". Encerra a janela. </summary>
        private void btnOk_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
