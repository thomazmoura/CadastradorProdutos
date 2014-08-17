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
        //Apenas para não ter conflitos com o banco de dados por enquanto, defina o valor do TipoProdutoId como 0 (deve haver um registro "indefinido" no índice zero para a tabela ProdutoDTO
        public ProdutoDTO()
        {
            TipoProdutoId = 0;
        }

        /// <summary> Refere-se à ID (identificador único) do produto </summary>
        public int ProdutoId { get; set; }
        /// <summary> Nome de identificação do produto </summary>
        public string Nome { get; set; }
        /// <summary> Texto descritivo do produto </summary>
        public string Descricao { get; set; }
        /// <summary> Preço da unidade do produto </summary>
        public decimal Preco { get; set; }
        /// <summary> Id do Tipo de Produto </summary>
        public int TipoProdutoId { get; set; }
    }
}
