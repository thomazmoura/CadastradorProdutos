#region Importações do sistema
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
#endregion
#region Importações da solução
using SysShop.Modelo;
using SysShop.Repositorio;
#endregion

namespace SysShop.Forms.UserControls
{
    /// <summary> UserControl para consulta de produtos </summary>
    public partial class ConsultaProdutos : UserControl, IAcceptableControl
    {
        /// <summary> Retorna o botão de confirmação </summary>
        public Button AcceptButton
        {
            get { return btnDetalhes; }
        }

        /// <summary> Construtor do UserControl para consulta de produtos registrados no sistema </summary>
        public ConsultaProdutos()
        {
            InitializeComponent();
            PopularProdutos();
        }

        /// <summary> Método para popular o produtosGridView com os produtos salvos na fonte de dados. </summary>
        public void PopularProdutos(){
            var repositorio = new ProdutoRepositorio();
            produtosGridView.DataSource = repositorio.GetProdutos();
        }

        /// <summary> Evento de clique para o botão "Detalhes" </summary>
        private void btnDetalhes_Click(object sender, EventArgs e)
        {
            Produto produto;
            if (produtosGridView.SelectedCells.Count > 0)
                produto = produtosGridView.SelectedCells[0].OwningRow.DataBoundItem as Produto;
            else
                return;
            var janelaEdicao = new EdicaoProdutoJanela(produto);
            if (janelaEdicao.ShowDialog() == DialogResult.OK)
                produtosGridView.Refresh();
        }
    }
}
