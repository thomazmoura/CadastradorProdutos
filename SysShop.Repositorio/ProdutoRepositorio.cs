#region Importações do sistema
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
#endregion
#region Importações da solução
using SysShop.Modelo;
#endregion

namespace SysShop.Repositorio
{
    /// <summary> Classe responsável por fazer o intermédio entre os produtos salvos na fonte de dados e o sistema </summary>
    public class ProdutoRepositorio
    {
        //Campo privado que armazena a lista usada para guardar temporariamente os dados salvos no sistema
        private static IList<Produto> listaProdutos;
        //Acessador para a lista de produtos salvas no sistema
        protected IList<Produto> ListaProdutos {
            get
            {
                //Se não houver já uma lista instanciada, instancie uma nova
                if (listaProdutos == null)
                    listaProdutos = new List<Produto>();
                //Retorna a lista de produtos salvos
                return listaProdutos;
            }
        }

        /// <summary> Acessador público para a lista de produtos salvos no sistema </summary>
        /// <returns> A lista de produtos salvos no sistema </returns>
        public IEnumerable<Produto> GetProdutos()
        {
            //Retorna a lista de produtos salvos como uma interface iterável
            return ListaProdutos as IEnumerable<Produto>;
        }

        /// <summary> Acrescenta um produto à lista de produtos salvos no sistema </summary>
        /// <param name="produto"> O produto salvo no sistema </param>
        public void AddProduto(Produto produto)
        {
            ListaProdutos.Add(produto);
        }
    }
}
