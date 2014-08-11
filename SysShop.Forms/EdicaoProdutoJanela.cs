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
using SysShop.Modelo;
using SysShop.Forms.UserControls;
#endregion

namespace SysShop.Forms
{
    /// <summary> Formulário modal para edição de produtos </summary>
    public partial class EdicaoProdutoJanela : Form
    {
        /// <summary> Construtor básico para instanciação de edição de produtos </summary>
        public EdicaoProdutoJanela()
        {
            InitializeComponent();
        }

        /// <summary> Construtor para janela modal de edição de produtos </summary>
        /// <param name="produto"> O produto a ser instanciado </param>
        public EdicaoProdutoJanela(Produto produto)
        {
            //Cria um novo user control para cadastro de produto
            var cadastroProduto = new CadastroProduto();
            //Limpa os controles presentes na tela
            Controls.Clear();
            //Acrescenta o cadastroProduto à lista de controles dessa janela
            Controls.Add( cadastroProduto );
            //Torna o AceptButton padrão dessa janela o AcceptButton do user control
            AcceptButton = cadastroProduto.AcceptButton;
        }
    }
}
