using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.Common;
using System.Configuration;

namespace SysShop.DAL
{
    /// <summary> Classe que serve como base para conexão de todas as demais classes da camada DAL. Fornece acesso à string de conexão do sistema, à conexão com o banco de dados e à consultas ao banco. </summary>
    public class ConectorDAL
    {
        //Valores possíveis para providers
        private const string SQLServerInvariant = "System.Data.SqlClient";
        private const string OracleInvariant = "System.Data.OracleClient";
        private const string MySQLInvariant = "System.Data.MySqlClient";

        /// <summary> Definição do ProviderFactory que utilizaremos. </summary>
        public DbProviderFactory SysShopProviderFactory
        {
            get
            {
                return DbProviderFactories.GetFactory(SQLServerInvariant);
            }
        }

        /// <summary> Definição da sring de conexão que será utilizada. </summary>
        public string SysShopStringConnection
        {
            get { return ConfigurationManager.ConnectionStrings["SYS_SHOP_DB"].ConnectionString; }
        }

        /// <summary> Cria uma conexão com o banco de dados do sistema e a abre </summary>
        /// <returns> Uma conexão aberta com o banco de dados definido no app.config/web.config </returns>
        public DbConnection GetConexaoAberta()
        {
            var conexao = SysShopProviderFactory.CreateConnection();

            //Define a string de conexão que iremos utilizar
            conexao.ConnectionString = SysShopStringConnection;

            //Abre a conexão
            conexao.Open();

            return conexao;
        }

        /// <summary> Cria um novo parâmetro SQL do tipo definido no banco de dados do sistema. </summary>
        /// <param name="nomeParametro"> O nome do parâmetro terá. </param>
        /// <param name="valorParametro"> O valor do parâmetro. </param>
        /// <returns> Um parâmetro do tipo definido pelo banco de dados do sistema e com os valores e nome informados. </returns>
        public DbParameter CriarParametro(string nomeParametro, object valorParametro)
        {
            var parametro = SysShopProviderFactory.CreateParameter();
            parametro.ParameterName = nomeParametro;
            parametro.Value = valorParametro;

            return parametro;
        }

        /// <summary> Método mais completo para a execução de queries no nosso banco de dados. </summary>
        /// <param name="conexao"> A conexão que será utilizada para interagir com o banco. </param>
        /// <param name="consulta"> A consulta (query) que queremos executar em nosso banco de dados. </param>
        /// <param name="tipo"> O tipo de query que queremos executar (por exemplo, text ou stored procedure. </param>
        /// <param name="parametros"> A lista de parâmetros SQL que queremos acresentar à consulta. </param>
        /// <returns> Um DataReader com o resultado da pesquisa. </returns>
        public DbDataReader ExecutarConsulta(DbConnection conexao, string consulta, CommandType tipo, IList<DbParameter> parametros){
            DbDataReader dataReader = null;

            //Cria o comando (transação) que iremos executar
            using (var comando = conexao.CreateCommand() ) {

                //Defina o texto da query em si como sendo a consulta que foi passada como argumento
                comando.CommandText = consulta;
                //Define o tipo de consulta
                comando.CommandType = tipo;
                //Define o tempo limite em segundos que a transação pode ser gerada sem gerar um erro
                comando.CommandTimeout = 120;

                //Verifica se há algum parâmetro SQL 
                if (parametros.Count > 0)
                {
                    foreach (var parametro in parametros)
                    {
                        if (parametro.Value == null)
                        {
                            parametro.Value = DBNull.Value;
                        }
                        comando.Parameters.Add(parametro);
                    }
                }
                
                //Alimenta o dataReader com os dados da execução do comando
                dataReader = comando.ExecuteReader();
            
                //Retorna o dataReader resultante do comando
                return dataReader;
            }
        }

        /// <summary> Sobrecarga mais simples para a execução de queries no nosso banco de dados. Não recebe parâmetros. </summary>
        /// <param name="conexao"> A conexão que será utilizada para interagir com o banco. </param>
        /// <param name="consulta"> A consulta (query) que queremos executar em nosso banco de dados. </param>
        /// <param name="tipo"> O tipo de query que queremos executar (por exemplo, text ou stored procedure). Por padrão recebe CommandType.Text </param>
        /// <returns> Um DataReader com o resultado da pesquisa. </returns>
        public DbDataReader ExecutarConsulta(DbConnection conexao, string consulta, CommandType tipo = CommandType.Text)
        {
            DbDataReader dataReader = null;

            //Cria o comando (transação) que iremos executar
            using (var comando = conexao.CreateCommand())
            {

                //Defina o texto da query em si como sendo a consulta que foi passada como argumento
                comando.CommandText = consulta;
                //Define o tipo de consulta
                comando.CommandType = tipo;
                //Define o tempo limite em segundos que a transação pode ser gerada sem gerar um erro
                comando.CommandTimeout = 120;

                //Alimenta o dataReader com os dados da execução do comando
                dataReader = comando.ExecuteReader();

                //Retorna o dataReader resultante
                return dataReader;
            }
        }

        /// <summary> Método completo para transações (INSERT, UPDATE, DELETE) com o banco de dados. </summary>
        /// <param name="conexao"> A conexão que será utilizada para interagir com o banco. </param>
        /// <param name="consulta"> A consulta (query) que queremos executar em nosso banco de dados. </param>
        /// <param name="tipo"> O tipo de query que queremos executar (por exemplo, text ou stored procedure. </param>
        /// <param name="parametros"> A lista de parâmetros SQL que queremos acresentar à consulta. </param>
        public void ExecutarTransacao(DbConnection conexao, string consulta, CommandType tipo, IList<DbParameter> parametros)
        {
            //Cria o comando (transação) que iremos executar
            using (var comando = conexao.CreateCommand())
            {

                //Defina o texto da query em si como sendo a consulta que foi passada como argumento
                comando.CommandText = consulta;
                //Define o tipo de consulta
                comando.CommandType = tipo;
                //Define o tempo limite em segundos que a transação pode ser gerada sem gerar um erro
                comando.CommandTimeout = 120;

                //Verifica se há algum parâmetro SQL 
                if (parametros.Count > 0)
                {
                    foreach (var parametro in parametros)
                    {
                        if (parametro.Value == null)
                        {
                            parametro.Value = DBNull.Value;
                        }
                        comando.Parameters.Add(parametro);
                    }
                }

                //Executa a transação no banco
                comando.ExecuteNonQuery();
            }
        }
    }
}
