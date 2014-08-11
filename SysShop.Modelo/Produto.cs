#region Importações do sistema
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
#endregion

namespace SysShop.Modelo
{
    public class Produto
    {
        /// <summary> Refere-se à ID (identificador único) do produto </summary>
        public int ID { get; set; }
        /// <summary> Nome de identificação do produto </summary>
        public string Nome { get; set; }
        /// <summary> Texto descritivo do produto </summary>
        public string Descricao { get; set; }
        /// <summary> Preço da unidade do produto </summary>
        public decimal Preco { get; set; }
    }
}
