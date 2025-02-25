using System;
using System.Data;
using System.Data.SqlClient;

namespace EcoPark_Manager.Controller
{
    public class ControllerAlojamento
    {
        private readonly Connection connection;

        public ControllerAlojamento()
        {
            connection = new Connection();
        }

        public DataTable ObterAlojamentos()
        {
            string query = "SELECT alonumero, alotipo, alostatus, aloobservacao FROM Alojamento";
            DataTable dataTable = new DataTable();

            using (SqlConnection conn = connection.Connect())
            {
                conn.Open(); // Abrir a conexão

                using (SqlDataAdapter dataAdapter = new SqlDataAdapter(query, conn))
                {
                    dataAdapter.Fill(dataTable);
                }
            }

            return dataTable;
        }

        public bool VerificarExistenciaAlojamento(string tipo, string numero)
        {
            string query = "SELECT COUNT(*) FROM Alojamento WHERE alotipo = @tipo AND alonumero = @numero";

            using (SqlConnection conn = connection.Connect())
            {
                conn.Open(); // Abrir a conexão

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@tipo", tipo);
                    cmd.Parameters.AddWithValue("@numero", numero);

                    int count = (int)cmd.ExecuteScalar();
                    return count > 0;
                }
            }
        }

        public void CadastrarAlojamento(string tipo, string numero, string status, string observacao)
        {
            if (VerificarExistenciaAlojamento(tipo, numero))
            {
                throw new Exception("O alojamento já está cadastrado.");
            }

            string query = "INSERT INTO Alojamento (alotipo, alonumero, alostatus, aloobservacao) VALUES (@tipo, @numero, @status, @observacao)";

            using (SqlConnection conn = connection.Connect())
            {
                conn.Open(); // Abrir a conexão

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@tipo", tipo);
                    cmd.Parameters.AddWithValue("@numero", numero);
                    cmd.Parameters.AddWithValue("@status", status);
                    cmd.Parameters.AddWithValue("@observacao", observacao);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public void AtualizarAlojamento(string tipo, string numero, string status, string observacao)
        {
            string query = "UPDATE Alojamento SET alostatus = @status, aloobservacao = @observacao WHERE alotipo = @tipo AND alonumero = @numero";

            using (SqlConnection conn = connection.Connect())
            {
                conn.Open(); // Abrir a conexão

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@tipo", tipo);
                    cmd.Parameters.AddWithValue("@numero", numero);
                    cmd.Parameters.AddWithValue("@status", status);
                    cmd.Parameters.AddWithValue("@observacao", observacao);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public void ExcluirAlojamento(string tipo, string numero)
        {
            string query = "DELETE FROM Alojamento WHERE alotipo = @tipo AND alonumero = @numero";

            using (SqlConnection conn = connection.Connect())
            {
                conn.Open(); // Abrir a conexão

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@tipo", tipo);
                    cmd.Parameters.AddWithValue("@numero", numero);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public DataTable ObterAlugueis()
        {
            string query = "SELECT numero, tipo, dataInicio, dataFim, nomeCliente FROM Alugueis";
            DataTable dataTable = new DataTable();

            using (SqlConnection conn = connection.Connect())
            {
                conn.Open(); // Abrir a conexão

                using (SqlDataAdapter dataAdapter = new SqlDataAdapter(query, conn))
                {
                    dataAdapter.Fill(dataTable);
                }
            }

            return dataTable;
        }

        public void AlugarAlojamento(string tipo, string numero, DateTime dataInicio, DateTime dataFim, string nomeCliente)
        {
            string query = "INSERT INTO Alugueis (tipo, numero, dataInicio, dataFim, nomeCliente) VALUES (@tipo, @numero, @dataInicio, @dataFim, @nomeCliente)";

            using (SqlConnection conn = connection.Connect())
            {
                conn.Open(); // Abrir a conexão

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@tipo", tipo);
                    cmd.Parameters.AddWithValue("@numero", numero);
                    cmd.Parameters.AddWithValue("@dataInicio", dataInicio);
                    cmd.Parameters.AddWithValue("@dataFim", dataFim);
                    cmd.Parameters.AddWithValue("@nomeCliente", nomeCliente);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public void CancelarAluguel(string tipo, string numero)
        {
            string query = "DELETE FROM Alugueis WHERE tipo = @tipo AND numero = @numero";

            using (SqlConnection conn = connection.Connect())
            {
                conn.Open(); // Abrir a conexão

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@tipo", tipo);
                    cmd.Parameters.AddWithValue("@numero", numero);
                    cmd.ExecuteNonQuery();
                }
            }
        }
    }
}
