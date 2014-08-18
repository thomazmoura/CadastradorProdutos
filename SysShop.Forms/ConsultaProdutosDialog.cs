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
using SysShop.BLL.Excecoes;

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

        /// <summary> Popula o produtosGridView com os produtos salvos na fonte de dados. </summary>
        public void PopularProdutos(){
            var produtoBLL = new ProdutoBLL();
            try
            {
                produtosGridView.DataSource = produtoBLL.GetProdutos();
                ConfigurarGridView();
            }
            catch (InfoException ex)
            {
                new ErroDialog(ex.Titulo, ex.Message + "\nInformações técnicas:\n" + ex.InnerException.StackTrace).ShowDialog();
                DialogResult = DialogResult.Cancel;
            }
        }

        /// <summary> Evento de clique para o botão "Detalhes" </summary>
        private void btnDetalhes_Click(object sender, EventArgs e)
        {
            ProdutoDTO produto;
            
            //Através da célula selecionada se obtém a linha selecionada a através dela o objeto de negócios selecionado
            if (produtosGridView.SelectedCells.Count > 0)
                produto = produtosGridView.SelectedCells[0].OwningRow.DataBoundItem as ProdutoDTO;
            else
                return;

            var janelaEdicao = new CadastroProdutoDialog(produto);
            if (janelaEdicao.ShowDialog() == DialogResult.OK)
                PopularProdutos();
        }

        /// <summary> Evento de clique para o botão "Deletar" </summary>
        private void btnDeletar_Click(object sender, EventArgs e)
        {
            ProdutoDTO produto;

            //Através da célula selecionada se obtém a linha selecionada a através dela o objeto de negócios selecionado
            if (produtosGridView.SelectedCells.Count > 0)
                produto = produtosGridView.SelectedCells[0].OwningRow.DataBoundItem as ProdutoDTO;
            else
                return;

            string pergunta = string.Format("Deseja mesmo excluir o produto {0}?", produto.Nome);

            //Variável que armazenará o resultado da confirmação
            DialogResult resposta;
            //Faz a pergunta (através de um MessageBox) e atribui o resultado à variável resposta
            resposta = MessageBox.Show(pergunta, "Confirmação de exclusão", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            //Se a resposta for posistiva
            if (resposta == DialogResult.Yes)
            {
                try
                {
                    //Deleta o produto do banco de dados
                    new ProdutoBLL().DeletarProduto(produto);

                    PopularProdutos();
                }
                catch (InfoException ex)
                {
                    new ErroDialog(ex.Titulo, ex.Message + "\nInformações técnicas:\n" + ex.InnerException.StackTrace).ShowDialog();
                    DialogResult = DialogResult.Cancel;
                }
            }
        }

        /// <summary> Configura os detalhes visuais do DataGridView </summary>
        private void ConfigurarGridView()
        {
            produtosGridView.Columns["ProdutoId"].Width = 30; //Define largura da coluna ProdutoId
            produtosGridView.Columns["ProdutoId"].HeaderText = "ID"; //Define o texto do cabeçalho da coluna ProdutoId
            produtosGridView.Columns["Descricao"].Width = 250;
            produtosGridView.Columns["Descricao"].HeaderText = "Descrição";
            produtosGridView.Columns["Preco"].HeaderText = "Preço";
            produtosGridView.Columns["Preco"].DefaultCellStyle.Format = "c"; //Define o formato padrão como currency (moeda) para a coluna Preco
            produtosGridView.Columns["TipoProdutoId"].Visible = false;
        }

        private void tbxVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
