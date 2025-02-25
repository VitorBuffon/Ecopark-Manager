using System;
using System.Data.SqlClient;

namespace EcoPark_Manager.Controller
{
    internal class Connection
    {
        static string Server = "DESKTOP-32I0DSS";
        static string Database = "ecopark";

        string connString = $"Data Source={Server};Initial Catalog={Database};Integrated Security=True;";

        public SqlConnection Connect()
        {
            try
            {
                SqlConnection conn = new SqlConnection(connString);
                // Remove a abertura aqui, e deixe a abertura ocorrer no controller.
                Console.WriteLine("Conexão estabelecida (não aberta automaticamente)!");
                return conn;
            }
            catch (SqlException e)
            {
                Console.WriteLine("Erro ao conectar ao banco de dados: " + e.Message);
                throw;
            }
        }


        public void Disconnect(SqlConnection conn)
        {
            try
            {
                conn.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine("Erro ao desconectar do banco de dados: " + e.Message);
               
            }
        }
    }
}
