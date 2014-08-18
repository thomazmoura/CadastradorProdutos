#region Importações do sistema
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
#endregion

namespace SysShop.DTO
{
    public class ProdutoDTO
    {
        //Apenas para não ter conflitos com o banco de dados por enquanto, defina o valor do TipoProdutoId como 0 (deve haver um registro "indefinido" no índice zero para a tabela ProdutoDTO.
        public ProdutoDTO()
        {
            TipoProdutoId = 0;
        }

        /// <summary> Refere-se à ID (identificador único) do produto. </summary>
        public int ProdutoId { get; set; }
        /// <summary> Nome de identificação do produto. </summary>
        public string Nome { get; set; }
        /// <summary> Texto descritivo do produto. </summary>
        public string Descricao { get; set; }
        /// <summary> Preço da unidade do produto. </summary>
        public decimal Preco { get; set; }
        /// <summary> Id do Tipo de Produto. </summary>
        public int TipoProdutoId { get; set; }

        /// <summary> Referência ao TipoProduto do Produto. </summary>
        public TipoProdutoDTO TipoProduto { get; set; }

        /// <summary> Define como esse objeto deve ser exibido em controles genéricos. </summary>
        /// <returns> Uma string que representa ou identifica o objeto. </returns>
        public override string ToString()
        {
            return Nome;
        }
    }
}
