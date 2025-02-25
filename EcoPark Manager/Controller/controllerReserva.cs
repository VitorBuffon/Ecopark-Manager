using System;
using System.Data.SqlClient;

namespace EcoPark_Manager.Controller
{
    public class ControllerReserva
    {
        private readonly Connection connection;

        public ControllerReserva()
        {
            connection = new Connection();
        }

        // Método para cadastrar nova reserva sem necessidade de informar o status
        public void CadastrarReserva(int clicodigo, int alocodigo, DateTime dataInicio, DateTime dataFim, decimal valor, string observacao)
        {
            // Definir o status inicial como "ocupado"
            string status = "ocupado";

            string query = "INSERT INTO Reserva (clicodigo, alocodigo, resdata_inicio, resdata_fim, resvalor, reservastatus, reservaobservacao) " +
                           "VALUES (@CliCodigo, @AloCodigo, @DataInicio, @DataFim, @Valor, @Status, @Observacao)";

            using (SqlConnection conn = connection.Connect())
            {
                conn.Open();

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@CliCodigo", clicodigo);
                    cmd.Parameters.AddWithValue("@AloCodigo", alocodigo);
                    cmd.Parameters.AddWithValue("@DataInicio", dataInicio);
                    cmd.Parameters.AddWithValue("@DataFim", dataFim);
                    cmd.Parameters.AddWithValue("@Valor", valor);
                    cmd.Parameters.AddWithValue("@Status", status);
                    cmd.Parameters.AddWithValue("@Observacao", observacao);

                    cmd.ExecuteNonQuery();
                }
            }
        }

        // Método para verificar a disponibilidade do alojamento
        public bool VerificarDisponibilidade(int alocodigo, DateTime dataInicio, DateTime dataFim)
        {
            string query = "SELECT COUNT(*) FROM Reserva " +
                           "WHERE alocodigo = @AloCodigo " +
                           "AND (resdata_inicio <= @DataFim AND resdata_fim >= @DataInicio)";

            using (SqlConnection conn = connection.Connect())
            {
                conn.Open();

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@AloCodigo", alocodigo);
                    cmd.Parameters.AddWithValue("@DataInicio", dataInicio);
                    cmd.Parameters.AddWithValue("@DataFim", dataFim);

                    int count = (int)cmd.ExecuteScalar();
                    return count == 0; // Se count for 0, o alojamento está disponível
                }
            }
        }

        // Método para atualizar o status das reservas automaticamente
        public void AtualizarStatusReservas()
        {
            string query = "UPDATE Reserva SET reservastatus = 'disponível' WHERE resdata_fim < GETDATE() AND reservastatus = 'ocupado'";

            using (SqlConnection conn = connection.Connect())
            {
                conn.Open();

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.ExecuteNonQuery(); // Atualiza o status de todas as reservas expiradas para "disponível"
                }
            }
        }
    }
}
