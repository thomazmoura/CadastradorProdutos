using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using SysShop.DTO;
using SysShop.DAL;
using SysShop.BLL.Excecoes;

namespace SysShop.BLL
{
    public class TipoProdutoBLL
    {
        protected TipoProdutoDAL produtoDAL;

        public TipoProdutoBLL(){
            tipoProdutoDAL = new TipoProdutoDAL();
        }

        protected TipoProdutoDAL tipoProdutoDAL;

        /// <summary> Obtém a lista de Tipos de Produtos salvos no sistema. </summary>
        /// <returns> A lista de produtos salvos no sistema. </returns>
        public IList<TipoProdutoDTO> GetTiposProduto()
        {
            try
            {
                return tipoProdutoDAL.GetTiposProduto();
            }
            catch (Exception ex)
            {
                //Lança uma exceção personalizada
                throw new InfoException("Erro de acesso aos dados", "Houve algum erro no acesso ao banco de dados ao ler os tipos de produtos registrados.\nNão foi possível se obter os dados.\nPor gentileza, contate a área de desenvolvimento da empresa.", ex);
            }
        }

        /// <summary> Obtém um Tipo de Produto específico de acordo com sua ID. </summary>
        /// <param name="tipoProdutoId"> O ID do produto que será retornado. </param>
        /// <returns> O TipoProduto salvo no sistema que possui aquela ID </returns>
        public TipoProdutoDTO GetTipoProduto(int tipoProdutoId)
        {
            try
            {
                return tipoProdutoDAL.GetTipoProduto(tipoProdutoId);
            }
            catch (Exception ex)
            {
                //Lança uma exceção personalizada
                throw new InfoException("Erro de acesso aos dados", "Houve algum erro no acesso ao banco de dados ao ler os tipos de produtos registrados.\nNão foi possível se obter os dados.\nPor gentileza, contate a área de desenvolvimento da empresa.", ex);
            }
        }
    }
}
