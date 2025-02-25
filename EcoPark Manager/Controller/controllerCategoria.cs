using System;
using System.Data;
using System.Data.SqlClient;

namespace EcoPark_Manager.Controller
{
    public class ControllerCategoria
    {
        private readonly Connection connection;

        public ControllerCategoria()
        {
            connection = new Connection();
        }

        public void CadastrarCategoria(string nomeCategoria)
        {
            if (VerificarCategoriaExistente(nomeCategoria))
            {
                throw new Exception("A categoria já está cadastrada.");
            }

            string query = "INSERT INTO categoria (catenome) VALUES (@Nome)";

            using (SqlConnection conn = connection.Connect())
            {
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@Nome", nomeCategoria);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public DataTable ObterTodasCategorias()
        {
            string query = "SELECT * FROM categoria";
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


        private bool VerificarCategoriaExistente(string nomeCategoria)
        {
            string query = "SELECT COUNT(*) FROM categoria WHERE catenome = @Nome";

            using (SqlConnection conn = connection.Connect())
            {
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@Nome", nomeCategoria);
                    int count = (int)cmd.ExecuteScalar();
                    return count > 0;
                }
            }
        }
    }
}
