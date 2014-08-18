using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using SysShop.DTO;
using System.Data;
using System.Data.Common;

namespace SysShop.DAL
{
    public class TipoProdutoDAL
    {
        /// <summary> Obtém a lista de Tipos de Produtos salvos no sistema. </summary>
        /// <returns> A lista de produtos salvos no sistema. </returns>
        public IList<TipoProdutoDTO> GetTiposProduto()
        {
            //Definimos a query que iremos executar
            string sqlString = "SELECT * FROM TipoProduto";

            //Cria-se uma instância da classe de conexão
            var conector = new ConectorDAL();
            //Abrimos uma nova conexão com o banco de dados utilizando o conector
            using (var conexao = conector.GetConexaoAberta())
            {
                //Executamos a query e salvamos o resultado
                using (var dataReader = conector.ExecutarConsulta(conexao, sqlString.ToString()))
                {

                    //Criamos uma nova lista de tipos de produto que receberá o resultado da consulta
                    var listaTiposProduto = new List<TipoProdutoDTO>();
                    //Enquanto ainda não tivermos lido todos os elementos do dataReader
                    while (dataReader.Read())
                    {
                        //Criamos um novo produto
                        var tipoProduto = new TipoProdutoDTO()
                        {
                            //Lemos o valor das colunas do dataReader atual (tupla atual) e passamos como propriedades do novo tipo de roduto
                            TipoProdutoId = Convert.ToInt32(dataReader["TipoProdutoId"]),
                            Descricao = dataReader["Descricao"].ToString(),
                        };
                        //Acrescenta o produto novo à lista
                        listaTiposProduto.Add(tipoProduto);
                    }
                    //Retorna a lista de produtos com os valores que estavam salvos no Banco
                    return listaTiposProduto;
                }
            }
        }

        /// <summary> Obtém um Tipo de Produto específico de acordo com sua ID. </summary>
        /// <param name="tipoProdutoId"> O ID do produto que será retornado. </param>
        /// <returns> O TipoProduto salvo no sistema que possui aquela ID </returns>
        public TipoProdutoDTO GetTipoProduto(int tipoProdutoId)
        {
            //Criação da string builder que montará nossa consulta
            var sqlStringBuilder = new StringBuilder();
            //Montamos a query que iremos executar
            sqlStringBuilder.AppendLine("SELECT * FROM TipoProduto");
            sqlStringBuilder.AppendLine("WHERE TipoProdutoId = @TipoProdutoId");

            //Cria-se uma instância da classe de conexão
            var conector = new ConectorDAL();
            //Abrimos uma nova conexão com o banco de dados utilizando o conector
            using (var conexao = conector.GetConexaoAberta())
            {
                //Criação da lista de parâmetros
                var listaParametros = new List<DbParameter>();
                listaParametros.Add( conector.CriarParametro("@TipoProdutoId", tipoProdutoId) );

                //Executamos a query e salvamos o resultado
                using (var dataReader = conector.ExecutarConsulta(conexao, sqlStringBuilder.ToString(), CommandType.Text, listaParametros))
                {
                    TipoProdutoDTO tipoProduto = null;
                    //Enquanto ainda não tivermos lido todos os elementos do dataReader
                    while (dataReader.Read())
                    {
                        //Criamos um novo produto
                        tipoProduto = new TipoProdutoDTO()
                        {
                            //Lemos o valor das colunas do dataReader atual (tupla atual) e passamos como propriedades do novo tipo de roduto
                            TipoProdutoId = Convert.ToInt32(dataReader["TipoProdutoId"]),
                            Descricao = dataReader["Descricao"].ToString(),
                        };
                    }
                    //Retorna a lista de produtos com os valores que estavam salvos no Banco
                    return tipoProduto;
                }
            }
        }
    }
}
