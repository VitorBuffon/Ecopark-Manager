using System;
using System.Data;
using System.Data.SqlClient;

namespace EcoPark_Manager.Controller
{
    public class ControllerFornecedor
    {
        private readonly Connection connection;

        public ControllerFornecedor()
        {
            connection = new Connection();
        }

        public void CadastrarFornecedor(string nomeFornecedor, string cidade, string cpf, string cnpj, string endereco, string numeroContato, string observacao, bool isCpf)
        {
            if (VerificarFornecedorExistente(cpf, cnpj))
            {
                throw new Exception("O fornecedor já está cadastrado.");
            }

            string query = "INSERT INTO fornecedor (fornnome, forncidade, fornendereco, fornnumero, fornobservacao, forntipodocumento, forncpf, forncnpj) " +
                           "VALUES (@Nome, @Cidade, @Endereco, @NumeroContato, @Observacao, @TipoDocumento, @Cpf, @Cnpj)";

            using (SqlConnection conn = connection.Connect())
            {
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@Nome", nomeFornecedor);
                    cmd.Parameters.AddWithValue("@Cidade", cidade);
                    cmd.Parameters.AddWithValue("@Endereco", endereco);
                    cmd.Parameters.AddWithValue("@NumeroContato", numeroContato);
                    cmd.Parameters.AddWithValue("@Observacao", observacao);
                    cmd.Parameters.AddWithValue("@TipoDocumento", isCpf ? "CPF" : "CNPJ");
                    cmd.Parameters.AddWithValue("@Cpf", isCpf ? cpf : (object)DBNull.Value);
                    cmd.Parameters.AddWithValue("@Cnpj", !isCpf ? cnpj : (object)DBNull.Value);

                    cmd.ExecuteNonQuery();
                }
            }
        }

        public DataTable ObterTodosFornecedores()
        {
            string query = "SELECT forncodigo, fornnome FROM fornecedor";
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

        private bool VerificarFornecedorExistente(string cpf, string cnpj)
        {
            string query = "SELECT COUNT(*) FROM fornecedor WHERE forncpf = @Cpf OR forncnpj = @Cnpj";

            using (SqlConnection conn = connection.Connect())
            {
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@Cpf", string.IsNullOrEmpty(cpf) ? (object)DBNull.Value : cpf);
                    cmd.Parameters.AddWithValue("@Cnpj", string.IsNullOrEmpty(cnpj) ? (object)DBNull.Value : cnpj);
                    int count = (int)cmd.ExecuteScalar();
                    return count > 0;
                }
            }
        }
    }
}
