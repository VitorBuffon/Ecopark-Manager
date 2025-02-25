using EcoPark_Manager.Controller;
using EcoPark_Manager.Model.Estoque;
using System;
using System.Data;
using System.Windows.Forms;

namespace EcoPark_Manager.Model
{
    public partial class Estoques : Form
    {
        private readonly ControllerCategoria _controllerCategoria;
        private readonly ControllerMarca _controllerMarca;
        private readonly ControllerFornecedor _controllerFornecedor;
        private readonly ControllerProduto _controllerProduto;

        public Estoques()
        {
            InitializeComponent();
            _controllerCategoria = new ControllerCategoria();
            _controllerMarca = new ControllerMarca();
            _controllerFornecedor = new ControllerFornecedor();
            _controllerProduto = new ControllerProduto();
            BloquearCampos();
        }

        private void Estoque_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'bancoProduto.Produto'. Você pode movê-la ou removê-la conforme necessário.
            this.produtoTableAdapter.Fill(this.bancoProduto.Produto);
            CarregarCategorias();
            CarregarMarcas();
            CarregarFornecedores();
            InicializarUnidadesDeMedida();
            AtualizarVisibilidadeDataValidade();
        }

        private void InicializarUnidadesDeMedida()
        {
            cboxUniMedProd.Items.Add("Unidade (un)");
            cboxUniMedProd.Items.Add("Pacote (pct)");
            cboxUniMedProd.Items.Add("Caixa (cx)");
            cboxUniMedProd.Items.Add("Quilograma (kg)");
            cboxUniMedProd.Items.Add("Litro (lt)");
            cboxUniMedProd.Items.Add("Gramas (g)");
            cboxUniMedProd.Items.Add("Mililitros (ml)");
        }

        private void CarregarCategorias()
        {
            try
            {
                DataTable categorias = _controllerCategoria.ObterTodasCategorias();
                cboxCateProd.DisplayMember = "catenome";
                cboxCateProd.ValueMember = "catecodigo";
                cboxCateProd.DataSource = categorias;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao carregar categorias: {ex.Message}");
            }
        }

        private void CarregarMarcas()
        {
            try
            {
                DataTable marcas = _controllerMarca.ObterTodasMarcas();
                cboxMarcProd.DisplayMember = "marcanome";
                cboxMarcProd.ValueMember = "marcacodigo"; // Supondo que exista uma coluna com esse nome para o código da marca
                cboxMarcProd.DataSource = marcas;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao carregar marcas: {ex.Message}");
            }
        }

        private void btnNovoForn_Click(object sender, EventArgs e)
        {
            NovoFornecedor formNovoFornecedor = new NovoFornecedor();
            formNovoFornecedor.FornecedorCadastrado += CarregarFornecedores;
            formNovoFornecedor.ShowDialog();
        }

        private void CarregarFornecedores()
        {
            try
            {
                DataTable fornecedores = _controllerFornecedor.ObterTodosFornecedores();
                cboxFornProd.DisplayMember = "fornnome";
                cboxFornProd.ValueMember = "forncodigo";
                cboxFornProd.DataSource = fornecedores;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao carregar fornecedores: {ex.Message}");
            }
        }

        private void BloquearCampos()
        {
            tboxNameProd.Enabled = false;
            cboxCateProd.Enabled = false;
            cboxUniMedProd.Enabled = false;
            numericQuantProd.Enabled = false;
            cboxFornProd.Enabled = false;
            cboxMarcProd.Enabled = false;
            dateTimeValidade.Enabled = false;
            checkBoxItemPerecivel.Enabled = false;
            tBoxPrecoProd.Enabled = false;
            tboxObsProd.Enabled = false;
            btnNovaCate.Enabled = false;
            btnNovoForn.Enabled = false;
            btnNovaMarc.Enabled = false;
        }

        private void HabilitarCampos()
        {
            tboxNameProd.Enabled = true;
            cboxCateProd.Enabled = true;
            cboxUniMedProd.Enabled = true;
            numericQuantProd.Enabled = true;
            cboxFornProd.Enabled = true;
            cboxMarcProd.Enabled = true;
            checkBoxItemPerecivel.Enabled = true;
            tBoxPrecoProd.Enabled = true;
            tboxObsProd.Enabled = true;
            AtualizarVisibilidadeDataValidade();
            btnNovaCate.Enabled = true;
            btnNovoForn.Enabled = true;
            btnNovaMarc.Enabled = true;
        }

        private void LimparCampos()
        {
            tboxNameProd.Text = string.Empty;
            cboxCateProd.SelectedIndex = -1;
            cboxUniMedProd.SelectedIndex = -1;
            numericQuantProd.Value = 0;
            cboxFornProd.SelectedIndex = -1;
            cboxMarcProd.SelectedIndex = -1;
            dateTimeValidade.Value = DateTime.Now;
            checkBoxItemPerecivel.Checked = false;
            tBoxPrecoProd.Text = string.Empty;
            tboxObsProd.Text = string.Empty;
            AtualizarVisibilidadeDataValidade();
        }

        private void btnNovoProd_Click(object sender, EventArgs e)
        {
            HabilitarCampos();
        }

        private void checkBoxItemPerecivel_CheckedChanged(object sender, EventArgs e)
        {
            AtualizarVisibilidadeDataValidade();
        }

        private void AtualizarVisibilidadeDataValidade()
        {
            bool isPerecivel = checkBoxItemPerecivel.Checked;
            dateTimeValidade.Enabled = isPerecivel;
            lblDataValidade.Visible = isPerecivel; // Torna a label visível apenas se o item for perecível
            dateTimeValidade.Visible = isPerecivel; // Torna o DateTimePicker visível apenas se o item for perecível
        }

        private void btnNovaCate_Click(object sender, EventArgs e)
        {
            NovaCategoria formNovaCategoria = new NovaCategoria();
            formNovaCategoria.CategoriaCadastrada += CarregarCategorias;
            formNovaCategoria.ShowDialog();
        }

        private void btnNovaMarc_Click(object sender, EventArgs e)
        {
            NovaMarca formNovaMarca = new NovaMarca();
            formNovaMarca.MarcaCadastrada += CarregarMarcas;
            formNovaMarca.ShowDialog();
        }

        private void btnCleanProd_Click(object sender, EventArgs e)
        {
            LimparCampos();
        }

        private void btnCancProd_Click(object sender, EventArgs e)
        {
            LimparCampos();
            BloquearCampos();
        }

        private void btnVoltarProd_Click(object sender, EventArgs e)
        {
            Hide();
            TelaInicial formTelaInicial = new TelaInicial();
            formTelaInicial.Show();
            Close();
        }

        private void dgvProd_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnGravarProd_Click(object sender, EventArgs e)
        {
            try
            {
                if (CamposObrigatoriosPreenchidos())
                {
                    string prodNome = tboxNameProd.Text;
                    int prodCateCodigo = (int)cboxCateProd.SelectedValue;
                    int prodMarcCodigo = (int)cboxMarcProd.SelectedValue;
                    int prodFornCodigo = (int)cboxFornProd.SelectedValue;
                    string prodUnidadeMedida = cboxUniMedProd.SelectedItem.ToString();
                    int prodQuantidade = (int)numericQuantProd.Value;
                    DateTime prodDataValidade = dateTimeValidade.Value;
                    string prodLote = Guid.NewGuid().ToString();
                    decimal prodPreco = decimal.Parse(tBoxPrecoProd.Text);
                    string prodObservacao = tboxObsProd.Text;

                    _controllerProduto.CadastrarProduto(prodNome, prodCateCodigo, prodMarcCodigo, prodFornCodigo, prodUnidadeMedida, prodQuantidade, prodDataValidade, prodLote, prodPreco, prodObservacao);

                    MessageBox.Show("Produto cadastrado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LimparCampos();
                    BloquearCampos();
                    CarregarProdutos();
                }
                else
                {
                    MessageBox.Show("Por favor, preencha todos os campos obrigatórios.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao cadastrar o produto: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CarregarProdutos()
        {
            try
            {
                DataTable produtos = _controllerProduto.ObterTodosProdutos();
                dgvProd.DataSource = produtos;

                if (dgvProd.Columns.Count == 0)
                {
                    dgvProd.Columns.Add("prodNome", "Nome");
                    dgvProd.Columns.Add("prodCateCodigo", "Categoria");
                    dgvProd.Columns.Add("prodMarcaCodigo", "Marca");
                    dgvProd.Columns.Add("prodFornCodigo", "Fornecedor");
                    dgvProd.Columns.Add("prodUnidadeMedida", "Unidade de Medida");
                    dgvProd.Columns.Add("prodQuantidade", "Quantidade");
                    dgvProd.Columns.Add("prodDataValidade", "Data de Validade");
                    dgvProd.Columns.Add("prodLote", "Lote");
                    dgvProd.Columns.Add("prodPreco", "Preço");
                    dgvProd.Columns.Add("prodObservacao", "Observação");
                }

                foreach (DataGridViewColumn column in dgvProd.Columns)
                {
                    switch (column.Name)
                    {
                        case "prodNome":
                            column.HeaderText = "Nome";
                            break;
                        case "prodCategoria":
                            column.HeaderText = "Categoria";
                            break;
                        case "prodMarca":
                            column.HeaderText = "Marca";
                            break;
                        case "prodFornecedor":
                            column.HeaderText = "Fornecedor";
                            break;
                        case "prodUnidadeMedida":
                            column.HeaderText = "Unidade de Medida";
                            break;
                        case "prodQuantidade":
                            column.HeaderText = "Quantidade";
                            break;
                        case "prodDataValidade":
                            column.HeaderText = "Data de Validade";
                            break;
                        case "prodLote":
                            column.HeaderText = "Lote";
                            break;
                        case "prodPreco":
                            column.HeaderText = "Preço";
                            break;
                        case "prodObservacao":
                            column.HeaderText = "Observação";
                            break;
                        default:
                            break;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao carregar produtos: {ex.Message}");
            }
        }

        private bool CamposObrigatoriosPreenchidos()
        {
            return !string.IsNullOrEmpty(tboxNameProd.Text) &&
                   cboxCateProd.SelectedIndex != -1 &&
                   cboxUniMedProd.SelectedIndex != -1 &&
                   numericQuantProd.Value > 0 &&
                   cboxFornProd.SelectedIndex != -1 &&
                   cboxMarcProd.SelectedIndex != -1 &&
                   !string.IsNullOrEmpty(tBoxPrecoProd.Text);
        }
    }
}
