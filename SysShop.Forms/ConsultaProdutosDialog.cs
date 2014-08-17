using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using SysShop.BLL;
using SysShop.DTO;

namespace SysShop.Forms
{
    public partial class ConsultaProdutosDialog : Form
    {

        /// <summary> Construtor do UserControl para consulta de produtos registrados no sistema </summary>
        public ConsultaProdutosDialog()
        {
            InitializeComponent();
            PopularProdutos();
        }

        /// <summary> Método para popular o produtosGridView com os produtos salvos na fonte de dados. </summary>
        public void PopularProdutos(){
            var repositorio = new ProdutoBLL();
            produtosGridView.DataSource = repositorio.GetProdutos();
        }

        /// <summary> Evento de clique para o botão "Detalhes" </summary>
        private void btnDetalhes_Click(object sender, EventArgs e)
        {
            ProdutoDTO produto;
            if (produtosGridView.SelectedCells.Count > 0)
                produto = produtosGridView.SelectedCells[0].OwningRow.DataBoundItem as ProdutoDTO;
            else
                return;
            var janelaEdicao = new CadastroProdutoDialog(produto);
            if (janelaEdicao.ShowDialog() == DialogResult.OK)
                produtosGridView.Refresh();
        }
    }
}
