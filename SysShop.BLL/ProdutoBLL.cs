using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using SysShop.DAL;
using SysShop.DTO;
using SysShop.BLL.Excecoes;

namespace SysShop.BLL
{
    public class ProdutoBLL
    {
        protected ProdutoDAL produtoDAL;

        public ProdutoBLL(){
            produtoDAL = new ProdutoDAL();
        }

        /// <summary> Acessador público para a lista de produtos salvos no sistema </summary>
        /// <returns> A lista de produtos salvos no sistema </returns>
        public IEnumerable<ProdutoDTO> GetProdutos()
        {
            try
            {
                //Retorna a lista de produtos salvos como uma interface iterável
                return produtoDAL.GetProdutos();
            }
            catch (Exception ex)
            {
                //Lança uma exceção personalizada
                throw new InfoException("Erro de acesso aos dados","Houve algum erro no acesso ao banco de dados ao ler os produtos registrados.\nNão foi possível se obter os dados.\nPor gentileza, contate a área de desenvolvimento da empresa.", ex);
            }
        }

        /// <summary> Acrescenta um produto à lista de produtos salvos no sistema </summary>
        /// <param name="produto"> O produto salvo no sistema </param>
        public void AcrescentarProduto(ProdutoDTO produto)
        {
            try
            {
                produtoDAL.AcrescentarProduto(produto);
            }
            catch (Exception ex)
            {
                //Lança uma exceção personalizada
                throw new InfoException("Erro de acesso aos dados", "Houve algum erro no acesso ao banco de dados durante a gravação do produto.\nO registro do produto não foi efetuado.\nPor gentileza, contate a área de desenvolvimento da empresa.", ex);
            }
        }

        /// <summary> Atualiza um produto salvo com os novos valores passados. </summary>
        /// <param name="produto"> O produto a ser atualizado. </param>
        public void EditarProduto(ProdutoDTO produto)
        {
            try
            {
                produtoDAL.EditarProduto(produto);
            }
            catch (Exception ex)
            {
                //Lança uma exceção personalizada
                throw new InfoException("Erro de acesso aos dados", "Houve algum erro no acesso ao banco de dados durante a atualização do produto.\nA atualização não foi realizada.\nPor gentileza, contate a área de desenvolvimento da empresa.", ex);
            }
        }

        /// <summary> Exclui um produto salvo do banco de dados. </summary>
        /// <param name="produto"> O produto a ser excluído. </param>
        public void DeletarProduto(ProdutoDTO produto)
        {
            try
            {
                produtoDAL.DeletarProduto(produto);
            }
            catch (Exception ex)
            {
                //Lança uma exceção personalizada
                throw new InfoException("Erro de acesso aos dados", "Houve algum erro no acesso ao banco de dados durante a exclusão do produto.\nO produto não pôde ser excluído.\nPor gentileza, contate a área de desenvolvimento da empresa.", ex);
            }
        }

    }
}
