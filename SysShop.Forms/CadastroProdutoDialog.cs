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
using SysShop.DTO;
using SysShop.BLL;
using SysShop.BLL.Excecoes;
#endregion

namespace SysShop.Forms
{
    /// <summary> Formulário modal para edição de produtos. </summary>
    public partial class CadastroProdutoDialog : Form
    {
        /// <summary> Armazena o produto gerado por esse Dialog (Janela modal). </summary>
        protected ProdutoDTO produto = null;

        /// <summary> Lista de resultados possíveis para o teste de validação de entrada para essa tela. </summary>
        protected enum ValidacaoDeEntrada
        {
            DadosValidos,
            NomeVazio,
            DescricaoVazia,
            PrecoVazio,
            PrecoInvalido,
            PrecoNegativo
        }

        /// <summary> Construtor básico do CadastroProdutoDialog - Para criação de novos produtos em uma TelaPrincipal. </summary>
        public CadastroProdutoDialog()
        {
            InitializeComponent();
            EJanelaDeEdicao = false;
            produto = new ProdutoDTO();
            PopularTiposProduto();
        }

        /// <summary> Construtor para edição de produtos - Para uso em edição de produtos em uma TelaPrincipal </summary>
        /// <param name="produto"> O produto a ser editado </param>
        public CadastroProdutoDialog(ProdutoDTO produto)
        {
            InitializeComponent();
            //Armazena o produto informado localmente
            this.produto = produto;
            AtualizarCampos();
            //Altera o texto dos botões
            btnOk.Text = "Salvar";
            btnLimpar.Text = "Cancelar";
            EJanelaDeEdicao = true;
            PopularTiposProduto();
        }

        /// <summary> Define se esse controle é um controle de edição de um produto existente ou gravação de um produto novo </summary>
        protected bool EJanelaDeEdicao { get; private set; }

        /// <summary> Evento de clique para o botão "Ok" </summary>
        private void btnOk_Click(object sender, EventArgs e)
        {
            //Verifica se os dados enviados passaram em todas as validações de entrada para pode registrar o novo produto
            if (ValidarDados() == ValidacaoDeEntrada.DadosValidos)
            {
                //Instancia o repositorio (que é o meio de acesso aos dados salvos no sistema)
                var produtoBLL = new ProdutoBLL();

                try
                {
                    //Verifica se a janela modal no momento está tendo a função de edição ou cadastro
                    if (!EJanelaDeEdicao) //Caso não esteja em modo de edição (esteja em modo de cadastro)
                    {
                        //Cria um novo produto de acordo com os campos do Dialog (Janela modal)
                        GerarProduto();
                        //Acrescenta o produto gerado ao sistema
                        produtoBLL.AcrescentarProduto(produto);
                        //Informa ao usuário do sucesso da gravação
                        MessageBox.Show("Produto gravado com sucesso!", "Ação realizada com sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        //Retorne o resultado do Dialog como ok
                        DialogResult = DialogResult.OK;
                    }
                    else //if (EJanelaDeEdicao) - Caso esteja em modo de edição, não cadastro
                    {
                        //Atualiza o produto de acordo com os campos
                        AtualizarProduto();

                        //Chama o método EditarProduto da BLL para registrar a mudança no Banco de dados
                        produtoBLL.EditarProduto(produto);

                        //Informa ao usuário do sucesso da alteração
                        MessageBox.Show("Produto alterado com sucesso!", "Ação realizada com sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        //Retorne o resultado do Dialog como ok
                        DialogResult = DialogResult.OK;
                    }
                }
                catch (InfoException ex)
                {
                    new ErroDialog(ex.Titulo, ex.Message + "\nInformações técnicas:\n" + ex.InnerException.StackTrace).ShowDialog();
                    DialogResult = DialogResult.Cancel;
                }
            }
            //Caso não tenha se passado no teste de validação
            else //if ( !(ValidarDados() == ValidacaoDeEntrada.DadosValidos) )
            {
                //Define-se qual mensagem de erro será exibida para o usuário
                switch (ValidarDados())
                {
                    case ValidacaoDeEntrada.NomeVazio:
                        MessageBox.Show("É necessário fornecer o nome do produto!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        break;
                    case ValidacaoDeEntrada.DescricaoVazia:
                        MessageBox.Show("É necessário fornecer uma descrição para o produto!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        break;
                    case ValidacaoDeEntrada.PrecoVazio:
                        MessageBox.Show("É necessário fornecer um preço para o produto!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        break;
                    case ValidacaoDeEntrada.PrecoInvalido:
                        MessageBox.Show("O preço informado não é válido! Utilize apenas valores numéricos ", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        break;
                    case ValidacaoDeEntrada.PrecoNegativo:
                        MessageBox.Show("O preço informado não é válido! O valor não pode ser negativo", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        break;
                }
            }
        }

        /// <summary> Verifica se os dados informados para registro ou edição dos dados são válidos ou não </summary>
        /// <returns> "true" quando os dados informados forem válidos e "false" quando eles não passarem na validação </returns>
        protected ValidacaoDeEntrada ValidarDados()
        {
            //Caso o tbxNome ou o tbxDescricao sejam nulos ou vazios, retorne "false"
            if (string.IsNullOrEmpty(tbxNome.Text) )
                return ValidacaoDeEntrada.NomeVazio;
            else if(string.IsNullOrEmpty(tbxDescricao.Text) )
                return ValidacaoDeEntrada.DescricaoVazia;
            else if(string.IsNullOrEmpty(tbxPreco.Text) )
                return ValidacaoDeEntrada.PrecoVazio;
            else {
                decimal preco;
                //Tente converter o tbxPreco para um decimal e retorne "false" caso o valor seja menor que 0
                if (!decimal.TryParse(tbxPreco.Text, out preco))
                    return ValidacaoDeEntrada.PrecoInvalido;
                else if (preco < 0)
                    return ValidacaoDeEntrada.PrecoNegativo;
                else
                    //Caso nenhum das validações anteriores seja disparado, retorne "true"
                    return ValidacaoDeEntrada.DadosValidos;
            }
        }

        /// <summary> Atualiza os campos para refletirem os dados contidos no Produto do Dialog (Janela modal) </summary>
        public void AtualizarCampos()
        {
            if (produto != null)
            {
                tbxNome.Text = produto.Nome;
                tbxDescricao.Text = produto.Descricao;
                tbxPreco.Text = produto.Preco.ToString();
                cbxTipoProduto.SelectedValue = produto.TipoProdutoId;
            }
        }

        /// <summary> Limpa os campos do Dialog (Janela modal) (e o Produto, caso houver) </summary>
        public void LimparCampos()
        {
            if (produto != null)
                produto = null;
            tbxNome.Clear();
            tbxDescricao.Clear();
            tbxPreco.Clear();
            cbxTipoProduto.SelectedIndex = 0;
        }

        /// <summary> Instancia um Produto de acordo com os valores informados dos campos do Dialog (Janela modal) </summary>
        public void GerarProduto()
        {
            produto = new ProdutoDTO()
            {
                Nome = tbxNome.Text,
                Descricao = tbxDescricao.Text,
                Preco = decimal.Parse(tbxPreco.Text),
                TipoProdutoId = Convert.ToInt32(cbxTipoProduto.SelectedValue)
            };
        }

        /// <summary> Atualiza o produto do Dialog (Janela modal) de acordo com os valores dos campos do Dialog (Janela modal) </summary>
        public void AtualizarProduto()
        {
            if (produto != null)
            {
                produto.Nome = tbxNome.Text;
                produto.Descricao = tbxDescricao.Text;
                produto.Preco = decimal.Parse(tbxPreco.Text);
                produto.TipoProdutoId = Convert.ToInt32(cbxTipoProduto.SelectedValue);
            }
            else
                GerarProduto();
        }

        /// <summary> Evento de clique para o botão "Cancelar" </summary>
        private void btnLimpar_Click(object sender, EventArgs e)
        {
            LimparCampos();
        }

        /// <summary> Evento de clique para o botão "Voltar". Basicamente retorna o valor de janela modal como DialogResult.Cancel e fecha a janela. </summary>
        private void btnVoltar_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            this.Close();
        }

        /// <summary> Alimenta o combobox de TiposProduto. </summary>
        protected void PopularTiposProduto()
        {
            //Alimenta o combobox com os TiposProduto salvos no sistema
            cbxTipoProduto.DataSource = new TipoProdutoBLL().GetTiposProduto();

            //Define o TipoProdutoId como sendo o elemento enviado como dado selecionado do combobox
            cbxTipoProduto.ValueMember = "TipoProdutoId";
            //Define a Descricao como sendo o elemento visível do combobox
            cbxTipoProduto.DisplayMember = "Descricao";
            //Define o item selecionado do combobox como sendo o TipoProduto do Produto sendo cadastrado/editado
            cbxTipoProduto.SelectedValue = produto.TipoProdutoId;
        }
    }
}
