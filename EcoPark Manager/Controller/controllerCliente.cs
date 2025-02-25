using System;
using System.Data;
using System.Data.SqlClient;

namespace EcoPark_Manager.Controller
{
    public class ControllerCliente
    {
        private readonly Connection connection;

        public ControllerCliente()
        {
            connection = new Connection();
        }

        // Método para cadastrar ou atualizar um cliente
        public void CadastrarCliente(string cliNome, string cliTelefone, string cliEndereco, string cliCpf, string cliRg, DateTime cliDataNasc, string cliGenero, string cliObservacoes)
        {
            bool clienteExiste = VerificarClienteExistente(cliCpf);
            string query;

            if (clienteExiste)
            {
                query = "UPDATE Clientes SET clinome = @Nome, clitelefone = @Telefone, cliendereco = @Endereco, clirg = @Rg, clidatanasc = @DataNasc, cligenero = @Genero, cliobservacoes = @Observacoes WHERE clicpf = @Cpf";
            }
            else
            {
                query = "INSERT INTO Clientes (clinome, clitelefone, cliendereco, clicpf, clirg, clidatanasc, cligenero, cliobservacoes) VALUES (@Nome, @Telefone, @Endereco, @Cpf, @Rg, @DataNasc, @Genero, @Observacoes)";
            }

            using (SqlConnection conn = connection.Connect())
            {
                conn.Open();  // Certifique-se de abrir a conexão

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@Nome", cliNome);
                    cmd.Parameters.AddWithValue("@Telefone", cliTelefone);
                    cmd.Parameters.AddWithValue("@Endereco", cliEndereco);
                    cmd.Parameters.AddWithValue("@Cpf", cliCpf);
                    cmd.Parameters.AddWithValue("@Rg", cliRg);
                    cmd.Parameters.AddWithValue("@DataNasc", cliDataNasc);
                    cmd.Parameters.AddWithValue("@Genero", cliGenero);
                    cmd.Parameters.AddWithValue("@Observacoes", cliObservacoes);

                    cmd.ExecuteNonQuery();  // Executa o comando
                }
            }
        }

        // Método para verificar se um cliente já existe no banco de dados
        private bool VerificarClienteExistente(string cliCpf)
        {
            string query = "SELECT COUNT(*) FROM Clientes WHERE clicpf = @Cpf";

            // Verifica se a conexão está aberta antes de executar o comando
            using (SqlConnection conn = connection.Connect())
            {
                conn.Open(); // Abre a conexão

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@Cpf", cliCpf);
                    int count = (int)cmd.ExecuteScalar(); // Executa o comando
                    return count > 0;
                }
            }
        }

        // Método para excluir um cliente pelo código
        public void ExcluirCliente(int codigoCliente)
        {
            string query = "DELETE FROM Clientes WHERE clicodigo = @Codigo";

            using (SqlConnection conn = connection.Connect())
            {
                conn.Open();  // Certifique-se de abrir a conexão

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@Codigo", codigoCliente);
                    cmd.ExecuteNonQuery();  // Executa o comando de exclusão
                }
            }
        }


        // Método para obter todos os clientes do banco de dados
        public DataTable ObterTodosClientes()
        {
            string query = "SELECT * FROM Clientes";
            DataTable dataTable = new DataTable();

            using (SqlConnection conn = connection.Connect())
            {
                using (SqlDataAdapter dataAdapter = new SqlDataAdapter(query, conn))
                {
                    dataAdapter.Fill(dataTable);
                }
            }

            return dataTable;
        }
    }
}
