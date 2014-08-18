using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SysShop.DTO
{
    /// <summary> Classe de transferência de dados de Tipos de Produto </summary>
    public class TipoProdutoDTO
    {
        /// <summary> Chave primária do TipoProduto. </summary>
        public int TipoProdutoId { get; set; }
        /// <summary> Descrição identificadora do TipoProduto. </summary>
        public string Descricao { get; set; }

        /// <summary> Define como esse objeto deve ser exibido em controles genéricos. </summary>
        /// <returns> Uma string que representa ou identifica o objeto. </returns>
        public override string ToString()
        {
            return Descricao;
        }
    }
}
