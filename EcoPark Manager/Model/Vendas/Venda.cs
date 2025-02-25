using EcoPark_Manager.Controller;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace EcoPark_Manager.Model.Vendas
{
    public partial class Venda : Form
    {
        private ControllerProduto _controllerProduto;
        private ControllerVenda _controllerVenda;
        private List<ItemPedido> _itensPedido;

        public class ItemPedido
        {
            public int CodigoProduto { get; set; } // Código do produto
            public string NomeProduto { get; set; } // Nome do produto
            public int Quantidade { get; set; } // Quantidade do produto no pedido
            public decimal PrecoUnitario { get; set; } // Preço unitário do produto
            public decimal Subtotal { get; set; } // Total para esse item (Quantidade * Preço Unitário)
        }



        public Venda()
        {
            InitializeComponent();
            _controllerProduto = new ControllerProduto();
            _controllerVenda = new ControllerVenda();
            _itensPedido = new List<ItemPedido>();

            ConfigurarListView();
            CarregarProdutos();

            tboxValorTotal.Enabled = false;
            btnFinalizarVenda.Enabled = false;
            tboxDesconto.Enabled = false;
            tboxValorFinal.Enabled = false;
            btnAplicarDesc.Enabled = false;
        }

        private void ConfigurarListView()
        {
            ListItensPedido.Columns.Add("Produto", 150);
            ListItensPedido.Columns.Add("Quantidade", 100);
            ListItensPedido.Columns.Add("Preço Unitário", 100);
            ListItensPedido.Columns.Add("Subtotal", 100);
        }

        private void CarregarProdutos()
        {
            try
            {
                DataTable produtos = _controllerProduto.ObterTodosProdutos();
                cboxProduto.DisplayMember = "prodNome"; // Supondo que essa é a coluna de nome do produto
                cboxProduto.ValueMember = "prodCodigo"; // Supondo que essa é a coluna do código do produto
                cboxProduto.DataSource = produtos;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao carregar produtos: {ex.Message}");
            }
        }

        private void AtualizarListView()
        {
            ListItensPedido.Items.Clear();

            foreach (var item in _itensPedido)
            {
                var listViewItem = new ListViewItem(item.NomeProduto);
                listViewItem.SubItems.Add(item.Quantidade.ToString());
                listViewItem.SubItems.Add(item.PrecoUnitario.ToString("C"));
                listViewItem.SubItems.Add(item.Subtotal.ToString("C"));

                ListItensPedido.Items.Add(listViewItem);
            }
        }

        private void AtualizarTotais()
        {
            decimal desconto = decimal.TryParse(tboxDesconto.Text, out var d) ? d : 0;
            decimal valorTotal = _controllerVenda.CalcularValorTotal(_itensPedido);
            decimal valorFinal = valorTotal - desconto;

            tboxValorTotal.Text = valorTotal.ToString("C");
            tboxValorFinal.Text = valorFinal.ToString("C");
        }

        private void btnAdicionar_Click_1(object sender, EventArgs e)
        {
            if (cboxProduto.SelectedItem == null || !int.TryParse(numericQuantidade.Value.ToString(), out int quantidade))
            {
                MessageBox.Show("Preencha todos os campos corretamente.");
                return;
            }

            var produtoSelecionado = (DataRowView)cboxProduto.SelectedItem;
            int produtoCodigo = Convert.ToInt32(produtoSelecionado["prodCodigo"]);
            string nomeProduto = produtoSelecionado["prodNome"].ToString();

            // Use o ControllerProduto para obter o preço
            decimal precoUnitario = _controllerProduto.ObterPrecoProduto(produtoCodigo);
            decimal subtotal = precoUnitario * quantidade;

            var itemPedido = new ItemPedido
            {
                CodigoProduto = produtoCodigo, // Defina o código do produto aqui
                NomeProduto = nomeProduto,
                Quantidade = quantidade,
                PrecoUnitario = precoUnitario,
                Subtotal = subtotal
            };

            _itensPedido.Add(itemPedido);
            AtualizarListView();
            AtualizarTotais();
        }

        private void btnFinalizarPedido_Click_1(object sender, EventArgs e)
        {
            tboxDesconto.Enabled = true;
            btnFinalizarVenda.Enabled = true;
            btnAplicarDesc.Enabled = true;

            btnAdicionar.Enabled = false;
            btnFinalizarPedido.Enabled = false;
        }

        private void btnCancelar_Click_1(object sender, EventArgs e)
        {
            _itensPedido.Clear();

            AtualizarListView();
            AtualizarTotais();

            tboxValorTotal.Text = "0,00";
            tboxValorFinal.Text = "0,00";
            tboxDesconto.Text = "0,00";
            tboxValorFinal.Text = "0,00";

            tboxValorTotal.Enabled = false;
            btnFinalizarVenda.Enabled = false;
            btnAplicarDesc.Enabled = false;
            tboxDesconto.Enabled = false;
            tboxValorFinal.Enabled = false;

            btnAdicionar.Enabled = true;
            btnFinalizarPedido.Enabled = true;

            cboxProduto.SelectedIndex = -1;
            numericQuantidade.Value = 1;

            MessageBox.Show("Venda cancelada com sucesso.");
        }

        private void btnAplicarDesc_Click(object sender, EventArgs e)
        {
            try
            {
                // Remove "R$" e formata a string para um número válido
                string descontoTexto = tboxDesconto.Text.Replace("R$", "").Trim();
                string valorFinalTexto = tboxValorFinal.Text.Replace("R$", "").Trim();

                // Verifica se os valores de desconto e valor final são válidos
                if (decimal.TryParse(descontoTexto, out decimal desconto) && decimal.TryParse(valorFinalTexto, out decimal valorFinalAtual))
                {
                    // O desconto deve ser positivo e menor ou igual ao valor final atual
                    if (desconto >= 0 && desconto <= valorFinalAtual)
                    {
                        // Subtrai o desconto do valor final
                        decimal valorComDesconto = valorFinalAtual - desconto;

                        // Atualiza o campo com o novo valor final com desconto aplicado
                        tboxValorFinal.Text = valorComDesconto.ToString("C");

                        // Limpa o campo de desconto para evitar aplicações múltiplas acidentais
                        tboxDesconto.Text = "0,00";
                    }
                    else
                    {
                        MessageBox.Show("O desconto deve ser maior que zero e menor ou igual ao valor final.");
                    }
                }
                else
                {
                    MessageBox.Show("Insira valores válidos para o desconto e o valor final.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro ao aplicar o desconto: " + ex.Message);
            }
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnFinalizarVenda_Click_1(object sender, EventArgs e)
        {
            try
            {
                decimal desconto = decimal.TryParse(tboxDesconto.Text, out var d) ? d : 0;

                _controllerVenda.FinalizarVenda(_itensPedido, desconto);

                MessageBox.Show("Venda finalizada com sucesso.");

                _itensPedido.Clear();
                AtualizarListView();
                AtualizarTotais();

                tboxValorTotal.Text = "0,00";
                tboxValorFinal.Text = "0,00";
                tboxDesconto.Text = "0,00";
                tboxValorFinal.Text = "0,00";

                tboxValorTotal.Enabled = false;
                btnFinalizarVenda.Enabled = false;
                btnAplicarDesc.Enabled = false;
                tboxDesconto.Enabled = false;
                tboxValorFinal.Enabled = false;

                btnAdicionar.Enabled = true;
                btnFinalizarPedido.Enabled = true;

                cboxProduto.SelectedIndex = -1;
                numericQuantidade.Value = 1;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao finalizar venda: {ex.Message}");
            }
        }
    }
}
