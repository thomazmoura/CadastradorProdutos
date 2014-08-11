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
using SysShop.Forms.UserControls;
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
            //Cria o UserControl de cadastro de produtos
            var cadastroProduto = new CadastroProduto();
            //Limpa qualquer controle que esteja ativo
            if(pnlPrincipal.Controls.Count > 0)
                pnlPrincipal.Controls.Clear();
            //Ativa o controle de Cadastro de Produto
            pnlPrincipal.Controls.Add(cadastroProduto);
            //Define o botão de confirmação do cadastroProduto como sendo o botão de confirmação para a TelaPrincipal
            AcceptButton = cadastroProduto.AcceptButton;
        }

        /// <summary> Evento para a ação de se clicar no toolstripmenuitem Arquivo>>Consulta </summary>
        private void consultaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Cria o UserControl de consulta de produtos
            var consultaProdutos = new ConsultaProdutos();
            //Limpa qualquer controle que esteja ativo
            if (pnlPrincipal.Controls.Count > 0)
                pnlPrincipal.Controls.Clear();
            //Ativa o controle de Consulta de Produtos
            pnlPrincipal.Controls.Add(consultaProdutos);
            //Define o botão de confirmação do consultaProdutos como sendo o botão de confirmação para a TelaPrincipal
            AcceptButton = consultaProdutos.AcceptButton;
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
