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
using SysShop.Forms.UserControls;
#endregion

namespace SysShop.Forms.UserControls
{
    /// <summary> UserControl para cadastro de produto </summary>
    public partial class CadastroProduto : UserControl, IAcceptableControl
    {
        /// <summary> Armazena o produto gerado por esse UserControl </summary>
        protected Produto produto = null;
        /// <summary> Armazena o formulário pai quando esse for informado (para janelas modais) </summary>
        protected Form formPai = null;

        /// <summary> Retorna o botão de confirmação </summary>
        public Button AcceptButton
        {
            get { return btnOk; }
        }

        /// <summary> Construtor básico do CadastroProduto - Para criação de novos produtos em uma TelaPrincipal </summary>
        public CadastroProduto()
        {
            InitializeComponent();
            EControleDeEdicao = false;
        }

        /// <summary> Construtor para edição de produtos - Para uso em edição de produtos em uma TelaPrincipal </summary>
        /// <param name="produto"> O produto a ser editado </param>
        public CadastroProduto(Produto produto)
        {
            InitializeComponent();
            //Armazena o produto informado localmente
            this.produto = produto;
            AtualizarCampos();
            //Altera o texto dos botões
            btnOk.Text = "Salvar";
            btnCancelar.Text = "Cancelar";
            EControleDeEdicao = true;
        }

        /// <summary> Construtor para edição modal de produtos - Para uso em janelas modais de edição de um produo </summary>
        /// <param name="formPai"> Janela modal pai (formulário onde o controle está inserido) </param>
        /// <param name="produto"> O produto a ser inserido </param>
        public CadastroProduto(Form formPai, Produto produto)
            :this(produto)
        {
            this.formPai = formPai;
        }

        /// <summary> Define se esse controle é um controle de edição de um produto existente ou gravação de um produto novo </summary>
        protected bool EControleDeEdicao { get; private set; }

        /// <summary> Evento de clique para o botão "Ok" </summary>
        private void btnOk_Click(object sender, EventArgs e)
        {
            if (ValidarDados())
            {
                //Instancia o repositorio (que é o meio de acesso aos dados salvos no sistema)
                var repositorio = new ProdutoRepositorio();

                if (!EControleDeEdicao)
                {
                    //Cria um novo produto de acordo com os campos do UserControl
                    GerarProduto();
                    //Acrescenta o produto gerado ao sistema
                    repositorio.AddProduto(produto);
                    //Informa ao usuário do sucesso da gravação
                    MessageBox.Show("Produto gravado com sucesso!", "Ação realizada com sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    
                    //Se houver formPai, registre-o como completado
                    if (formPai != null)
                        formPai.DialogResult = DialogResult.OK;
                    //Caso não haja, limpe os campos
                    else
                        LimparCampos();
                }
                else
                {
                    //Atualiza o produto de acordo com os campos
                    AtualizarProduto();
                    //Informa ao usuário do sucesso da alteração
                    MessageBox.Show("Produto alterado com sucesso!", "Ação realizada com sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    //Se houver formPai, registre-o como completado
                    if (formPai != null)
                        formPai.DialogResult = DialogResult.OK;
                    //Caso não haja, limpe os campos
                    else
                        LimparCampos();
                }
            }
            else
            {
                MessageBox.Show("Dados inválidos para registro do produto!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        /// <summary> Verifica se os dados informados para registro ou edição dos dados são válidos ou não </summary>
        /// <returns> "true" quando os dados informados forem válidos e "false" quando eles não passarem na validação </returns>
        protected bool ValidarDados()
        {
            //Caso o tbxNome ou o tbxDescricao sejam nulos ou vazios, retorne "false"
            if (string.IsNullOrEmpty(tbxNome.Text) &&
                string.IsNullOrEmpty(tbxDescricao.Text) )
            {
                return false;
            }else{
                //Tente converter o tbxPreco para um decimal e retorne "false" caso o valor seja menor ou igual a 0
                try
                {
                    if (string.IsNullOrEmpty(tbxPreco.Text) ||
                        decimal.Parse(tbxPreco.Text) <= 0)
                        return false;
                }
                //Caso o valor não possa ser convertido, retorne "false"
                catch (Exception ex)
                {
                    return false;
                }
            }
            //Caso nenhum dos testes anteriores seja disparado, retorne "true"
            return true;
        }

        /// <summary> Atualiza os campos para refletirem os dados contidos no Produto do UserControl </summary>
        public void AtualizarCampos()
        {
            if (produto != null)
            {
                tbxNome.Text = produto.Nome;
                tbxDescricao.Text = produto.Descricao;
                tbxPreco.Text = produto.Preco.ToString();
            }
        }

        /// <summary> Limpa os campos do UserControl (e o Produto, caso houver) </summary>
        public void LimparCampos()
        {
            if (produto != null)
                produto = null;
            tbxNome.Clear();
            tbxDescricao.Clear();
            tbxPreco.Clear();
        }

        /// <summary> Instancia um Produto de acordo com os valores informados dos campos do UserControl </summary>
        public void GerarProduto()
        {
            produto = new Produto()
            {
                Nome = tbxNome.Text,
                Descricao = tbxDescricao.Text,
                Preco = decimal.Parse(tbxPreco.Text)
            };
        }

        /// <summary> Atualiza o produto do UserControl de acordo com os valores dos campos do UserControl </summary>
        public void AtualizarProduto()
        {
            if (produto != null)
            {
                produto.Nome = tbxNome.Text;
                produto.Descricao = tbxDescricao.Text;
                produto.Preco = decimal.Parse(tbxPreco.Text);
            }
            else
                GerarProduto();
        }

        /// <summary> Evento de clique para o botão "Cancelar" </summary>
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            if (!EControleDeEdicao)
            {
                LimparCampos();
            }
            else
            {
                if (formPai != null)
                    formPai.DialogResult = DialogResult.Cancel;
                else
                    LimparCampos();
            }
        }
    }
}
