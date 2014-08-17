using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SysShop.BLL.Excecoes
{
    /// <summary> Exceção amigável e personalizada para o usuário. Serve para encapsular o lançamento de exceções caso o comportamento deste venha a ser alterado. Fornece também a opção de se definir uma mensagem e um título. </summary>
    public class InfoException : Exception
    {
        /// <summary> Título opcional que pode ser acrescentado às janelas de aviso. </summary>
        public string Titulo { get; protected set;}

        /// <summary> Sobrecarga do InfoException que recebe apenas a mensagem. </summary>
        /// <param name="mensagem"> Uma mensagem descritiva da exceção. </param>
        public InfoException(string mensagem)
            : base(mensagem) { }

        /// <summary> Sobrecarga do InfoException que recebe uma mensagem e uma excecao interna. </summary>
        /// <param name="mensagem"> Uma mensagem descritiva da exceção. </param>
        /// <param name="excecaoInterna"> A exceção interna que gerou a exceção. </param>
        public InfoException(string mensagem, Exception excecaoInterna)
            : base(mensagem, excecaoInterna) { }

        /// <summary> Sobrecarga do InfoException que recebe um titulo, uma mensagem e uma excecao interna. </summary>
        /// <param name="titulo"> Um título identificador para a exceção. </param>
        /// <param name="mensagem"> Uma mensagem descritiva da exceção. </param>
        /// <param name="excecaoInterna"> A exceção interna que gerou a exceção. </param>
        public InfoException(string titulo, string mensagem, Exception excecaoInterna)
            : base(mensagem, excecaoInterna)
        {
            this.Titulo = titulo;
        }
    }
}
