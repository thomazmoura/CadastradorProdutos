#region Importações do sistema
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
#endregion
#region Importações da solução
using SysShop.DTO;
using System.Data.Common;
using System.Data;
#endregion

namespace SysShop.DAL
{
    /// <summary> Classe responsável por fazer o intermédio entre os produtos salvos na fonte de dados e o sistema </summary>
    public class ProdutoDAL
    {
        /// <summary> Acessa a lista de produtos salvos no sistema </summary>
        /// <returns> A lista de produtos salvos no sistema </returns>
        public IEnumerable<ProdutoDTO> GetProdutos()
        {
            //Definimos a query que iremos executar
            string sqlString = "SELECT * FROM Produto";

            //Cria-se uma instância da classe de conexão
            var conector = new ConectorDAL();
            //Abrimos uma nova conexão com o banco de dados utilizando o conector
            using (var conexao = conector.GetConexaoAberta())
            {
                //Executamos a query e salvamos o resultado
                using (var dataReader = conector.ExecutarConsulta(conexao, sqlString.ToString()))
                {

                    //Criamos uma nova lista de produtos que receberá o resultado da consulta
                    var produtos = new List<ProdutoDTO>();
                    //Enquanto ainda não tivermos lido todos os elementos do dataReader
                    while (dataReader.Read())
                    {
                        //Criamos um novo produto
                        var produto = new ProdutoDTO()
                        {
                            //Lemos o valor das colunas do dataReader atual (tupla atual) e passamos como propriedades do novo produto
                            ProdutoId = Convert.ToInt32(dataReader["ProdutoId"]),
                            Nome = dataReader["Nome"].ToString(),
                            Descricao = dataReader["Descricao"].ToString(),
                            Preco = Convert.ToDecimal(dataReader["Preco"]),
                            TipoProdutoId = Convert.ToInt32(dataReader["TipoProdutoId"])
                        };
                        //Acrescenta o produto novo à lista
                        produtos.Add(produto);
                    }
                    //Retorna a lista de produtos com os valores que estavam salvos no Banco
                    return produtos;
                }
            }
        }

        /// <summary> Acrescenta um produto à lista de produtos salvos no sistema </summary>
        /// <param name="produto"> O produto salvo no sistema </param>
        public void AcrescentarProduto(ProdutoDTO produto)
        {
            //Criamos um StringBuilder para construir nossa query (consulta SQL)
            StringBuilder sqlStringBuilder = new StringBuilder();

            //Criamos a transacao propriamente dita
            sqlStringBuilder.AppendLine("INSERT INTO Produto (");
            sqlStringBuilder.AppendLine("  Nome,");
            sqlStringBuilder.AppendLine("  Descricao,");
            sqlStringBuilder.AppendLine("  Preco,");
            sqlStringBuilder.AppendLine("  TipoProdutoId");
            sqlStringBuilder.AppendLine(")");
            sqlStringBuilder.AppendLine("VALUES (");
            sqlStringBuilder.AppendLine("  @Nome,");
            sqlStringBuilder.AppendLine("  @Descricao,");
            sqlStringBuilder.AppendLine("  @Preco,");
            sqlStringBuilder.AppendLine("  @TipoProdutoId");
            sqlStringBuilder.AppendLine(")");

            //Cria-se uma instância da classe de conexão para poder executar a transacao
            var conector = new ConectorDAL();
            
            //Criamos uma lista de parâmetros SQL para serem enviados junto com a transação - por razões de segurança é nesses parâmetros que inseriremos os valores
            List<DbParameter> sqlParametros = new List<DbParameter>();

            //Acrescentamos cada um dos parâmetros listados na consulta à lista
            sqlParametros.Add(conector.CriarParametro("@Nome", produto.Nome));
            sqlParametros.Add(conector.CriarParametro("@Descricao", produto.Descricao));
            sqlParametros.Add(conector.CriarParametro("@Preco", produto.Preco));
            sqlParametros.Add(conector.CriarParametro("@TipoProdutoId", produto.TipoProdutoId));

            //Abrimos uma nova conexão com o banco de dados utilizando o conector
            using (var conexao = conector.GetConexaoAberta())
            {
                //Executamos a transacao propriamente dita no banco de dados
                conector.ExecutarTransacao(conexao, sqlStringBuilder.ToString(), CommandType.Text, sqlParametros);
            }
        }

        /// <summary> Atualiza os dados do banco de dados de um produto com base na versão atualizada desse mesmo produto. </summary>
        /// <param name="produto"></param>
        public void EditarProduto(ProdutoDTO produto)
        {
            //Criamos um StringBuilder para construir nossa query (consulta SQL)
            StringBuilder sqlStringBuilder = new StringBuilder();

            //Criamos a transacao propriamente dita
            sqlStringBuilder.AppendLine("UPDATE Produto");
            sqlStringBuilder.AppendLine("SET");
            sqlStringBuilder.AppendLine("  Nome = @Nome,");
            sqlStringBuilder.AppendLine("  Descricao = @Descricao,");
            sqlStringBuilder.AppendLine("  Preco = @Preco,");
            sqlStringBuilder.AppendLine("  TipoProdutoId = @TipoProdutoId");
            sqlStringBuilder.AppendLine("WHERE");
            sqlStringBuilder.AppendLine("  ProdutoId = @ProdutoId");

            //Cria-se uma instância da classe de conexão para poder executar a transacao
            var conector = new ConectorDAL();

            //Criamos uma lista de parâmetros SQL para serem enviados junto com a transação - por razões de segurança é nesses parâmetros que inseriremos os valores
            List<DbParameter> sqlParametros = new List<DbParameter>();

            //Acrescentamos cada um dos parâmetros listados na consulta à lista
            sqlParametros.Add(conector.CriarParametro("@Nome", produto.Nome));
            sqlParametros.Add(conector.CriarParametro("@Descricao", produto.Descricao));
            sqlParametros.Add(conector.CriarParametro("@Preco", produto.Preco));
            sqlParametros.Add(conector.CriarParametro("@TipoProdutoId", produto.TipoProdutoId));
            sqlParametros.Add(conector.CriarParametro("@ProdutoId", produto.ProdutoId));

            //Abrimos uma nova conexão com o banco de dados utilizando o conector
            using (var conexao = conector.GetConexaoAberta())
            {
                //Executamos a transacao propriamente dita no banco de dados
                conector.ExecutarTransacao(conexao, sqlStringBuilder.ToString(), CommandType.Text, sqlParametros);
            }
        }

        /// <summary> Deleta um produto do banco de dados. </summary>
        /// <param name="produto"> O produto a ser excluído do banco de dados. </param>
        public void DeletarProduto(ProdutoDTO produto)
        {
            //Criamos um StringBuilder para construir nossa query (consulta SQL)
            StringBuilder sqlStringBuilder = new StringBuilder();

            //Criamos a transacao propriamente dita
            sqlStringBuilder.AppendLine("DELETE Produto");
            sqlStringBuilder.AppendLine("WHERE");
            sqlStringBuilder.AppendLine("  ProdutoId = @ProdutoId");

            //Cria-se uma instância da classe de conexão para poder executar a transacao
            var conector = new ConectorDAL();

            //Criamos uma lista de parâmetros SQL para serem enviados junto com a transação - por razões de segurança é nesses parâmetros que inseriremos os valores
            List<DbParameter> sqlParametros = new List<DbParameter>();

            //Acrescentamos cada um dos parâmetros listados na consulta à lista
            sqlParametros.Add(conector.CriarParametro("@ProdutoId", produto.ProdutoId));

            //Abrimos uma nova conexão com o banco de dados utilizando o conector
            using (var conexao = conector.GetConexaoAberta())
            {
                //Executamos a transacao propriamente dita no banco de dados
                conector.ExecutarTransacao(conexao, sqlStringBuilder.ToString(), CommandType.Text, sqlParametros);
            }
        }
    }
}
