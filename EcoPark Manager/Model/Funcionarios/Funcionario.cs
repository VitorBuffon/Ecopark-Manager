using EcoPark_Manager.Controller;
using System;
using System.Data;
using System.Windows.Forms;

namespace EcoPark_Manager.Model.Funcionario
{
    public partial class Funcionario : Form
    {
        private readonly ControllerFuncionario controllerFuncionario;

        public Funcionario()
        {
            InitializeComponent();
            ConfigurarMascaras();
            ConfigurarComboBoxGenero();
            BloquearCampos();
            controllerFuncionario = new ControllerFuncionario();
        }

        private void Funcionario_Load(object sender, EventArgs e)
        {
            AtualizarDataGridView();
        }

        private void ConfigurarMascaras()
        {
            txtCpfFunc.Mask = "000.000.000-00";
            txtTelFunc.Mask = "(00) 00000-0000";
            txtSalFunc.Mask = "00,000";
            txtSalFunc.TextMaskFormat = MaskFormat.IncludePromptAndLiterals;
        }

        private void ConfigurarComboBoxGenero()
        {
            cboxGenFunc.Items.AddRange(new string[] { "M", "F" });
        }

        private void checkDeslFunc_CheckedChanged(object sender, EventArgs e)
        {
            if (checkDeslFunc.Checked)
            {
                dataDeslFunc.Enabled = true;
            }
            else
            {
                dataDeslFunc.Enabled = false;
                dataDeslFunc.Value = DateTime.Now;
            }
        }

        private void btnNovoFunc_Click(object sender, EventArgs e)
        {
            LimparCampos();
            HabilitarCampos();
        }

        private void btnGravarFunc_Click(object sender, EventArgs e)
        {
            if (!CamposPreenchidos())
            {
                MessageBox.Show("Por favor, preencha todos os campos obrigatórios.", "Erro de validação", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string nome = txtNameFunc.Text;
            string telefone = txtTelFunc.Text;
            string endereco = txtAddressFunc.Text;
            string cpf = txtCpfFunc.Text;
            string rg = txtRgFunc.Text;
            DateTime dataAdmissao = dataAdmFunc.Value;
            DateTime dataDesligamento = checkDeslFunc.Checked ? dataDeslFunc.Value : DateTime.MinValue;
            string genero = cboxGenFunc.Text;
            string cargo = txtCargoFunc.Text;

            // Validar e converter o salário
            decimal salario;
            if (!decimal.TryParse(txtSalFunc.Text,
                System.Globalization.NumberStyles.Currency,
                System.Globalization.CultureInfo.CurrentCulture,
                out salario))
            {
                MessageBox.Show("Por favor, insira um valor válido para o salário.", "Erro de validação", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string observacoes = txtObsFunc.Text;

            try
            {
                controllerFuncionario.CadastrarFuncionario(nome, telefone, endereco, cpf, rg, dataAdmissao, dataDesligamento, genero, cargo, salario, observacoes);
                MessageBox.Show("Funcionário cadastrado com sucesso!", "Cadastro realizado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LimparCampos();
                BloquearCampos();
                AtualizarDataGridView();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ocorreu um erro ao cadastrar o funcionário: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCleanFunc_Click(object sender, EventArgs e)
        {
            LimparCampos();
        }

        private void btnCancFunc_Click(object sender, EventArgs e)
        {
            BloquearCampos();
            LimparCampos();
        }

        private void btnVoltarFunc_Click(object sender, EventArgs e)
        {
            this.Hide();
            TelaInicial formTelaInicial = new TelaInicial();
            formTelaInicial.Show();
            this.Close();
        }

        private bool CamposPreenchidos()
        {
            return !string.IsNullOrWhiteSpace(txtNameFunc.Text) &&
                   !string.IsNullOrWhiteSpace(txtAddressFunc.Text) &&
                   !string.IsNullOrWhiteSpace(txtCpfFunc.Text) &&
                   !string.IsNullOrWhiteSpace(txtRgFunc.Text) &&
                   !string.IsNullOrWhiteSpace(txtCargoFunc.Text) &&
                   !string.IsNullOrWhiteSpace(txtSalFunc.Text) &&
                   !string.IsNullOrWhiteSpace(cboxGenFunc.Text) &&
                   !string.IsNullOrWhiteSpace(txtTelFunc.Text);
        }

        private void LimparCampos()
        {
            txtNameFunc.Text = string.Empty;
            txtAddressFunc.Text = string.Empty;
            txtCpfFunc.Text = string.Empty;
            txtRgFunc.Text = string.Empty;
            txtCargoFunc.Text = string.Empty;
            txtSalFunc.Text = string.Empty;
            cboxGenFunc.SelectedIndex = -1;
            txtTelFunc.Text = string.Empty;
            dataAdmFunc.Value = DateTime.Now;
            dataDeslFunc.Value = DateTime.Now;
            checkDeslFunc.Checked = false;
            txtObsFunc.Text = string.Empty;
        }

        private void HabilitarCampos()
        {
            txtNameFunc.Enabled = true;
            txtAddressFunc.Enabled = true;
            txtCpfFunc.Enabled = true;
            txtRgFunc.Enabled = true;
            txtCargoFunc.Enabled = true;
            txtSalFunc.Enabled = true;
            cboxGenFunc.Enabled = true;
            txtTelFunc.Enabled = true;
            dataAdmFunc.Enabled = true;
            checkDeslFunc.Enabled = true;
            txtObsFunc.Enabled = true;
        }

        private void BloquearCampos()
        {
            txtNameFunc.Enabled = false;
            txtAddressFunc.Enabled = false;
            txtCpfFunc.Enabled = false;
            txtRgFunc.Enabled = false;
            txtCargoFunc.Enabled = false;
            txtSalFunc.Enabled = false;
            cboxGenFunc.Enabled = false;
            txtTelFunc.Enabled = false;
            dataAdmFunc.Enabled = false;
            checkDeslFunc.Enabled = false;
            dataDeslFunc.Enabled = false;
            txtObsFunc.Enabled = false;
        }

        private void AtualizarDataGridView()
        {
            try
            {
                // Aqui você precisa obter os dados do banco de dados e atribuí-los ao DataGridView
                dataGridView1.DataSource = controllerFuncionario.ObterTodosFuncionarios();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao atualizar DataGridView: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dataGridView1.Columns["Excluir"].Index && e.RowIndex >= 0)
            {
                int codigoFuncionario = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells["codigo"].Value);
                DialogResult result = MessageBox.Show("Tem certeza de que deseja excluir o funcionário selecionado?", "Confirmar Exclusão", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    controllerFuncionario.ExcluirFuncionario(codigoFuncionario);
                    AtualizarDataGridView();
                    MessageBox.Show("Funcionário excluído com sucesso!", "Exclusão realizada", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }

            if (e.RowIndex >= 0 && e.ColumnIndex == dataGridView1.Columns["Editar"].Index)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                // Implemente o método PreencherCamposComDadosFuncionario(row) se necessário
                HabilitarCampos();
            }
        }

        private void checkDeslFunc_CheckedChanged_1(object sender, EventArgs e)
        {
            dataDeslFunc.Enabled = checkDeslFunc.Checked;
        }
    }
}
