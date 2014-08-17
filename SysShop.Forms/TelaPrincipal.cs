#region Importações do sistema
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
#endregion
#region Importações da solução
using SysShop.BLL;
#endregion

namespace SysShop.Forms
{
    /// <summary> Classe que representa a tela inicial do sistema - Que também serve como intermediário
    ///  para as demais telas </summary>
    public partial class TelaPrincipal : Form
    {
        /// <summary> Construtor da classe TelaPrincipal </summary>
        public TelaPrincipal()
        {
            InitializeComponent();
        }

        /// <summary> Evento para a ação de se clicar no toolstripmenuitem Arquivo>>Cadastro </summary>
        private void cadastroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Cria a janela modal de cadastro de produtos
            var cadastroProduto = new CadastroProdutoDialog();
            //Exibe a janela modal de cadastro de produtos
            cadastroProduto.ShowDialog();
        }

        /// <summary> Evento para a ação de se clicar no toolstripmenuitem Arquivo>>Consulta </summary>
        private void consultaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Cria o UserControl de consulta de produtos
            var consultaProdutos = new ConsultaProdutosDialog();
            consultaProdutos.ShowDialog();
        }

        /// <summary> Evento para a ação de se clicar no toolstripmenuitem Arquivo>>Sair </summary>
        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Encerra o programa
            Application.Exit();
        }

        /// <summary> Evento para a ação de se clicar no toolstripmenuitem Ajuda>>Sobre </summary>
        private void sobreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Cria o texto informativo de "Sobre" do programa
            string textoAjuda = string.Format("SysShop\nPrograma de registro de produtos\nDesenvolvido por: Thomaz Padilha");
            //Exibe o texto informativo em uma janela modal
            MessageBox.Show(textoAjuda);
        }
    }
}
