using EcoPark_Manager.Model;
using System;
using System.Data;
using System.Data.SqlClient;

namespace EcoPark_Manager.Controller
{
    public class ControllerFuncionario
    {
        private readonly Connection connection;

        public ControllerFuncionario()
        {
            connection = new Connection();
        }

        public void CadastrarFuncionario(string funcNome, string funcTelefone, string funcEndereco, string funcCpf, string funcRg, DateTime funcDataAdmissao, DateTime funcDesligamento, string funcGenero, string funcCargo, decimal funcSalario, string funcObservacoes)
        {
            bool funcionarioExiste = VerificarFuncionarioExistente(funcCpf);
            string query;
            if (funcionarioExiste)
            {
                query = "UPDATE Funcionarios SET funcNome = @Nome, funcTelefone = @Telefone, funcEndereco = @Endereco, funcRg = @Rg, funcDataAdmissao = @DataAdmissao, funcDesligamento = @Desligamento, funcGenero = @Genero, funcCargo = @Cargo, funcSalario = @Salario, funcObservacoes = @Observacoes WHERE funcCpf = @Cpf";
            }
            else
            {
                query = "INSERT INTO Funcionarios (funcNome, funcTelefone, funcEndereco, funcCpf, funcRg, funcDataAdmissao, funcDesligamento, funcGenero, funcCargo, funcSalario, funcObservacoes) VALUES (@Nome, @Telefone, @Endereco, @Cpf, @Rg, @DataAdmissao, @Desligamento, @Genero, @Cargo, @Salario, @Observacoes)";
            }

            using (SqlConnection conn = connection.Connect())
            {
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@Nome", funcNome);
                    cmd.Parameters.AddWithValue("@Telefone", funcTelefone);
                    cmd.Parameters.AddWithValue("@Endereco", funcEndereco);
                    cmd.Parameters.AddWithValue("@Cpf", funcCpf);
                    cmd.Parameters.AddWithValue("@Rg", funcRg);
                    cmd.Parameters.AddWithValue("@DataAdmissao", funcDataAdmissao);
                    cmd.Parameters.AddWithValue("@Desligamento", funcDesligamento == DateTime.MinValue ? DBNull.Value : (object)funcDesligamento);
                    cmd.Parameters.AddWithValue("@Genero", funcGenero);
                    cmd.Parameters.AddWithValue("@Cargo", funcCargo);
                    cmd.Parameters.AddWithValue("@Salario", funcSalario);
                    cmd.Parameters.AddWithValue("@Observacoes", funcObservacoes);

                    cmd.ExecuteNonQuery();
                }
            }
        }

        private bool VerificarFuncionarioExistente(string funcCpf)
        {
            string query = "SELECT COUNT(*) FROM Funcionarios WHERE funcCpf = @Cpf";

            using (SqlConnection conn = connection.Connect())
            {
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@Cpf", funcCpf);
                    int count = (int)cmd.ExecuteScalar();
                    return count > 0;
                }
            }
        }

        public void ExcluirFuncionario(int codigoFuncionario)
        {
            string query = "DELETE FROM Funcionarios WHERE funcCodigo = @Codigo";

            using (SqlConnection conn = connection.Connect())
            {
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@Codigo", codigoFuncionario);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public DataTable ObterTodosFuncionarios()
        {
            string query = "SELECT * FROM Funcionarios";
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
