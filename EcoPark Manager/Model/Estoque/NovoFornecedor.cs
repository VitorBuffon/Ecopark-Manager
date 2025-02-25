using System;
using System.Windows.Forms;
using EcoPark_Manager.Controller; // Certifique-se de incluir o namespace da ControllerFornecedor

namespace EcoPark_Manager.Model.Estoque
{
    public partial class NovoFornecedor : Form
    {
        public delegate void FornecedorCadastradaHandler();
        public event FornecedorCadastradaHandler FornecedorCadastrado;
        private readonly ControllerFornecedor _controllerFornecedor;

        public NovoFornecedor()
        {
            InitializeComponent();
            _controllerFornecedor = new ControllerFornecedor(); // Inicializa a ControllerFornecedor
            ConfigurarMascaras(); // Configura a máscara ao iniciar
        }

        private void ConfigurarMascaras()
        {
            if (cboxCpfForn.Checked)
            {
                MasCpfCnpjForn.Mask = "000.000.000-00";
            }
            else if (cboxCnpjForn.Checked)
            {
                MasCpfCnpjForn.Mask = "00.000.000/0000-00";
            }
            else
            {
                MasCpfCnpjForn.Mask = ""; // Nenhuma máscara, caso nenhum esteja selecionado
            }

            MasNumeroContato.Mask = "(00) 00000-0000";
        }

        private void cboxCpfForn_CheckedChanged(object sender, EventArgs e)
        {
            cboxCnpjForn.Checked = !cboxCpfForn.Checked;
            ConfigurarMascaras();
        }

        private void cboxCnpjForn_CheckedChanged(object sender, EventArgs e)
        {
            cboxCpfForn.Checked = !cboxCnpjForn.Checked;
            ConfigurarMascaras();
        }

        private void btnCleanForn_Click(object sender, EventArgs e)
        {
            LimparCampos();
        }

        private void btnVoltarForn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void LimparCampos()
        {
            tboxNomeForn.Text = string.Empty;
            tboxCidadeForn.Text = string.Empty;
            MasCpfCnpjForn.Text = string.Empty;
            tboxEnderecoForn.Text = string.Empty;
            MasNumeroContato.Text = string.Empty;
            tboxObsForn.Text = string.Empty;
            cboxCpfForn.Checked = false;
            cboxCnpjForn.Checked = false;
        }

        private void btnGravarForn_Click(object sender, EventArgs e)
        {
            string nomeFornecedor = tboxNomeForn.Text.Trim();
            string cidade = tboxCidadeForn.Text.Trim();
            string cpfCnpj = MasCpfCnpjForn.Text.Trim();
            string endereco = tboxEnderecoForn.Text.Trim();
            string numeroContato = MasNumeroContato.Text.Trim(); // Obtém o número formatado
            string observacao = tboxObsForn.Text.Trim();
            bool isCpf = cboxCpfForn.Checked;

            if (string.IsNullOrEmpty(nomeFornecedor) || string.IsNullOrEmpty(cidade) ||
                string.IsNullOrEmpty(cpfCnpj) || string.IsNullOrEmpty(endereco) ||
                string.IsNullOrEmpty(numeroContato))
            {
                MessageBox.Show("Por favor, preencha todos os campos obrigatórios.");
                return;
            }

            string cpf = isCpf ? cpfCnpj : string.Empty;
            string cnpj = !isCpf ? cpfCnpj : string.Empty;

            try
            {
                _controllerFornecedor.CadastrarFornecedor(nomeFornecedor, cidade, cpf, cnpj, endereco, numeroContato, observacao, isCpf);
                MessageBox.Show("Fornecedor gravado com sucesso!");
                LimparCampos();

                FornecedorCadastrado?.Invoke();
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao gravar o fornecedor: {ex.Message}");
            }
        }

    }
}
