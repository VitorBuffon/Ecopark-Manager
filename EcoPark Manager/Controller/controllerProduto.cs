using System;
using System.Data;
using System.Data.SqlClient;

namespace EcoPark_Manager.Controller
{
    public class ControllerProduto
    {
        private readonly Connection _connection;

        public ControllerProduto()
        {
            _connection = new Connection();
        }

        public void CadastrarProduto(string prodNome, int prodCateCodigo, int prodMarcCodigo, int prodFornCodigo, string prodUnidadeMedida, int prodQuantidade, DateTime prodDataValidade, string prodLote, decimal prodPreco, string prodObservacao)
        {
            bool produtoExiste = VerificarProdutoExistente(prodNome, prodDataValidade);
            string query;
            if (produtoExiste)
            {
                query = "UPDATE produto SET prodquantidade = prodquantidade + @Quantidade WHERE prodnome = @Nome AND proddatavalidade = @DataValidade";
            }
            else
            {
                query = "INSERT INTO produto (prodnome, prodcatecodigo, prodmarccodigo, prodforncodigo, produnidademedida, prodquantidade, proddatavalidade, prodlote, prodpreco, prodobservacao) VALUES (@Nome, @CateCodigo, @MarcaCodigo, @FornCodigo, @UnidadeMedida, @Quantidade, @DataValidade, @Lote, @Preco, @Observacao)";
            }

            using (SqlConnection conn = _connection.Connect())
            {
                conn.Open(); // Aqui você abre a conexão
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@Nome", prodNome);
                    cmd.Parameters.AddWithValue("@CateCodigo", prodCateCodigo);
                    cmd.Parameters.AddWithValue("@MarcaCodigo", prodMarcCodigo);
                    cmd.Parameters.AddWithValue("@FornCodigo", prodFornCodigo);
                    cmd.Parameters.AddWithValue("@UnidadeMedida", prodUnidadeMedida);
                    cmd.Parameters.AddWithValue("@Quantidade", prodQuantidade);
                    cmd.Parameters.AddWithValue("@DataValidade", prodDataValidade);
                    cmd.Parameters.AddWithValue("@Lote", prodLote);
                    cmd.Parameters.AddWithValue("@Preco", prodPreco);
                    cmd.Parameters.AddWithValue("@Observacao", prodObservacao);

                    cmd.ExecuteNonQuery();
                }
            }
        }


        private bool VerificarProdutoExistente(string prodNome, DateTime prodDataValidade)
        {
            string query = "SELECT COUNT(*) FROM produto WHERE prodnome = @Nome AND proddatavalidade = @DataValidade";

            using (SqlConnection conn = _connection.Connect())
            {
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@Nome", prodNome);
                    cmd.Parameters.AddWithValue("@DataValidade", prodDataValidade);
                    conn.Open(); 
                    int count = (int)cmd.ExecuteScalar();
                    return count > 0;
                }
            }
        }

        public void ExcluirProduto(int prodCodigo)
        {
            string query = "DELETE FROM produto WHERE prodcodigo = @Codigo";

            using (SqlConnection conn = _connection.Connect())
            {
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@Codigo", prodCodigo);
                    conn.Open(); // Abra a conexão antes de executar o comando
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public decimal ObterPrecoProduto(int produtoCodigo)
        {
            string query = "SELECT prodpreco FROM produto WHERE prodcodigo = @Codigo";

            using (SqlConnection conn = _connection.Connect())
            {
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@Codigo", produtoCodigo);
                    conn.Open(); // Abre a conexão antes de executar o comando
                    return (decimal)cmd.ExecuteScalar();
                }
            }
        }


        public DataTable ObterTodosProdutos()
        {
            string query = "SELECT * FROM produto";
            DataTable dataTable = new DataTable();

            using (SqlConnection conn = _connection.Connect())
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
