using EcoPark_Manager.Model.Vendas;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using static EcoPark_Manager.Model.Vendas.Venda;

namespace EcoPark_Manager.Controller
{
    public class ControllerVenda
    {
        private readonly Connection _connection;

        public ControllerVenda()
        {
            _connection = new Connection();
        }

        public DataTable ObterTodosProdutos()
        {
            var dataTable = new DataTable();

            string query = "SELECT prodCodigo, prodNome FROM Produto";

            using (SqlConnection conn = _connection.Connect())
            {
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    try
                    {
                        conn.Open();
                        using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                        {
                            adapter.Fill(dataTable);
                        }
                    }
                    catch (Exception ex)
                    {
                        throw new Exception("Erro ao obter produtos", ex);
                    }
                }
            }

            return dataTable;
        }

        public decimal CalcularValorTotal(List<EcoPark_Manager.Model.Vendas.Venda.ItemPedido> itensPedido)
        {
            return itensPedido.Sum(i => i.Subtotal);
        }

        public void FinalizarVenda(List<EcoPark_Manager.Model.Vendas.Venda.ItemPedido> itensPedido, decimal desconto)
        {
            using (SqlConnection conn = _connection.Connect())
            {
                // Abre a conexão
                conn.Open();

                // Inicia a transação
                var transaction = conn.BeginTransaction();

                try
                {
                    var total = CalcularValorTotal(itensPedido);
                    var valorFinal = total - desconto;

                    // Inserir a venda na tabela Venda
                    string queryVenda = "INSERT INTO Venda (vendtotal, venddesconto, vendvalorfinal) VALUES (@vendtotal, @venddesconto, @vendvalorfinal); SELECT SCOPE_IDENTITY()";
                    int vendcodigo;
                    using (SqlCommand cmdVenda = new SqlCommand(queryVenda, conn, transaction))
                    {
                        cmdVenda.Parameters.AddWithValue("@vendtotal", total);
                        cmdVenda.Parameters.AddWithValue("@venddesconto", desconto);
                        cmdVenda.Parameters.AddWithValue("@vendvalorfinal", valorFinal);

                        vendcodigo = Convert.ToInt32(cmdVenda.ExecuteScalar());
                    }

                    // Inserir os itens na tabela ItensVenda
                    foreach (var item in itensPedido)
                    {
                        string queryItem = "INSERT INTO ItensVenda (vendcodigo, prodcodigo, vitemquantidade, vitemprecounitario, vitemsubtotal) VALUES (@vendcodigo, @prodcodigo, @vitemquantidade, @vitemprecounitario, @vitemsubtotal)";
                        using (SqlCommand cmdItem = new SqlCommand(queryItem, conn, transaction))
                        {
                            cmdItem.Parameters.AddWithValue("@vendcodigo", vendcodigo);
                            cmdItem.Parameters.AddWithValue("@prodcodigo", item.CodigoProduto); // Use o código do produto
                            cmdItem.Parameters.AddWithValue("@vitemquantidade", item.Quantidade);
                            cmdItem.Parameters.AddWithValue("@vitemprecounitario", item.PrecoUnitario);
                            cmdItem.Parameters.AddWithValue("@vitemsubtotal", item.Subtotal);

                            cmdItem.ExecuteNonQuery();
                        }

                        // Atualizar a quantidade em estoque
                        string queryAtualizarEstoque = "UPDATE Produto SET prodquantidade = prodquantidade - @vitemquantidade WHERE prodcodigo = @prodcodigo";
                        using (SqlCommand cmdEstoque = new SqlCommand(queryAtualizarEstoque, conn, transaction))
                        {
                            cmdEstoque.Parameters.AddWithValue("@vitemquantidade", item.Quantidade);
                            cmdEstoque.Parameters.AddWithValue("@prodcodigo", item.CodigoProduto); // Use o código do produto

                            cmdEstoque.ExecuteNonQuery();
                        }
                    }

                    // Commit da transação
                    transaction.Commit();
                }
                catch (Exception ex)
                {
                    // Rollback da transação em caso de erro
                    try
                    {
                        transaction.Rollback();
                    }
                    catch (Exception rollbackEx)
                    {
                        throw new Exception("Erro ao reverter a transação", rollbackEx);
                    }

                    throw new Exception("Erro ao finalizar venda", ex);
                }
            }
        }
    }
}