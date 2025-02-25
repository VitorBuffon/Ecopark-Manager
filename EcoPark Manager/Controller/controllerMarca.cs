using System;
using System.Data;
using System.Data.SqlClient;

namespace EcoPark_Manager.Controller
{
    public class ControllerMarca
    {
        private readonly Connection connection;

        public ControllerMarca()
        {
            connection = new Connection();
        }

        public void CadastrarMarca(string nomeMarca)
        {
            if (VerificarMarcaExistente(nomeMarca))
            {
                throw new Exception("A marca já está cadastrada.");
            }

            string query = "INSERT INTO marca (marcanome) VALUES (@Nome)";

            using (SqlConnection conn = connection.Connect())
            {
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@Nome", nomeMarca);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        private bool VerificarMarcaExistente(string nomeMarca)
        {
            string query = "SELECT COUNT(*) FROM marca WHERE marcanome = @Nome";

            using (SqlConnection conn = connection.Connect())
            {
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@Nome", nomeMarca);
                    int count = (int)cmd.ExecuteScalar();
                    return count > 0;
                }
            }
        }

        public void AtualizarMarca(int codigoMarca, string nomeMarca)
        {
            string query = "UPDATE marca SET marcanome = @Nome WHERE marcodigo = @Codigo";

            using (SqlConnection conn = connection.Connect())
            {
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@Nome", nomeMarca);
                    cmd.Parameters.AddWithValue("@Codigo", codigoMarca);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public void ExcluirMarca(int codigoMarca)
        {
            string query = "DELETE FROM marca WHERE marcodigo = @Codigo";

            using (SqlConnection conn = connection.Connect())
            {
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@Codigo", codigoMarca);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public DataTable ObterTodasMarcas()
        {
            string query = "SELECT * FROM marca";
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

        public DataTable ObterMarcaPorNome(string nomeMarca)
        {
            string query = "SELECT * FROM marca WHERE marcanome = @Nome";
            DataTable dataTable = new DataTable();

            using (SqlConnection conn = connection.Connect())
            {
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@Nome", nomeMarca);
                    using (SqlDataAdapter dataAdapter = new SqlDataAdapter(cmd))
                    {
                        dataAdapter.Fill(dataTable);
                    }
                }
            }

            return dataTable;
        }
    }
}
