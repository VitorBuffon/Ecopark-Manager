using System;
using System.Data;
using System.Windows.Forms;
using EcoPark_Manager.Controller;

namespace EcoPark_Manager.Model
{
    public partial class Cliente : Form
    {
        private readonly ControllerCliente controllerCliente;

        public Cliente()
        {
            InitializeComponent();
            controllerCliente = new ControllerCliente();
            ConfigurarDataGridView();
            BloquearCampos();
        }

        private void Cliente_Load(object sender, EventArgs e)
        {
            ConfigurarComboBoxGenero();
            ConfigurarMascaras();
            AtualizarDataGridView();
        }

        private void AtualizarDataGridView()
        {
            try
            {
                DataTable dataTable = controllerCliente.ObterTodosClientes();
                dataGridView1.DataSource = dataTable;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao atualizar DataGridView: " + ex.Message);
            }
        }

        private void ConfigurarDataGridView()
        {
            dataGridView1.CellDoubleClick += dataGridView1_CellDoubleClick;
            dataGridView1.AllowUserToAddRows = false;
            ConfigurarColunasDataGridView();
        }

        private void ConfigurarColunasDataGridView()
        {
            if (!dataGridView1.Columns.Contains("Excluir"))
            {
                DataGridViewButtonColumn btnColumnExcluir = new DataGridViewButtonColumn();
                btnColumnExcluir.Name = "Excluir";
                btnColumnExcluir.HeaderText = "Excluir";
                btnColumnExcluir.Text = "Excluir";
                btnColumnExcluir.UseColumnTextForButtonValue = true;
                dataGridView1.Columns.Add(btnColumnExcluir);
            }

            if (!dataGridView1.Columns.Contains("Editar"))
            {
                DataGridViewButtonColumn btnColumnEditar = new DataGridViewButtonColumn();
                btnColumnEditar.Name = "Editar";
                btnColumnEditar.HeaderText = "Editar";
                btnColumnEditar.Text = "Editar";
                btnColumnEditar.UseColumnTextForButtonValue = true;
                dataGridView1.Columns.Add(btnColumnEditar);
            }
        }

        private void ConfigurarComboBoxGenero()
        {
            cboxGenCli.DropDownStyle = ComboBoxStyle.DropDownList;
            cboxGenCli.Items.AddRange(new string[] { "M", "F" });
        }

        private void ConfigurarMascaras()
        {
            txtTelCli.Mask = "(00) 00000 - 0000";
            txtCpfCli.Mask = "000.000.000-00";
        }

        private void btnNovoCli_Click(object sender, EventArgs e)
        {
            LimparCampos();
            HabilitarCampos();
        }

        private void btnGravarCli_Click(object sender, EventArgs e)
        {
            if (!CamposPreenchidos())
            {
                MessageBox.Show("Por favor, preencha todos os campos obrigatórios.", "Erro de validação", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            controllerCliente.CadastrarCliente(txtNameCli.Text, txtTelCli.Text, txtAddressCli.Text,
                                               txtCpfCli.Text, txtRgCli.Text, dataNascCli.Value,
                                               cboxGenCli.Text, txtObsCli.Text);

            MessageBox.Show("Cliente cadastrado ou atualizado com sucesso!", "Cadastro realizado", MessageBoxButtons.OK, MessageBoxIcon.Information);

            LimparCampos();
            BloquearCampos();
            AtualizarDataGridView();
        }

        private bool CamposPreenchidos()
        {
            return !string.IsNullOrWhiteSpace(txtNameCli.Text) &&
                   !string.IsNullOrWhiteSpace(txtAddressCli.Text) &&
                   !string.IsNullOrWhiteSpace(txtCpfCli.Text) &&
                   !string.IsNullOrWhiteSpace(txtRgCli.Text) &&
                   !string.IsNullOrWhiteSpace(txtTelCli.Text) &&
                   !string.IsNullOrWhiteSpace(cboxGenCli.Text) &&
                   dataNascCli.Value != DateTime.MinValue;
        }

        private void btnCleanCli_Click(object sender, EventArgs e)
        {
            LimparCampos();
        }

        private void btnCancCli_Click(object sender, EventArgs e)
        {
            BloquearCampos();
            LimparCampos();
        }

        private void btnVoltarCli_Click(object sender, EventArgs e)
        {
            this.Hide();
            TelaInicial formTelaInicial = new TelaInicial();
            formTelaInicial.Show();
            this.Close();
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                HabilitarCampos();

                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                PreencherCamposComDadosCliente(row);
            }
        }

        private void PreencherCamposComDadosCliente(DataGridViewRow row)
        {
            txtNameCli.Text = row.Cells["clinome"].Value.ToString();
            txtAddressCli.Text = row.Cells["cliendereco"].Value.ToString();
            txtCpfCli.Text = row.Cells["clicpf"].Value.ToString();
            txtRgCli.Text = row.Cells["clirg"].Value.ToString();
            txtTelCli.Text = row.Cells["clitelefone"].Value.ToString();
            dataNascCli.Value = Convert.ToDateTime(row.Cells["clidatanasc"].Value);
            cboxGenCli.Text = row.Cells["cligenero"].Value.ToString();
            txtObsCli.Text = row.Cells["cliobservacoes"].Value.ToString();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dataGridView1.Columns["Excluir"].Index && e.RowIndex >= 0)
            {
                int codigoCliente = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells["codigo"].Value);
                DialogResult result = MessageBox.Show("Tem certeza de que deseja excluir o cliente selecionado?", "Confirmar Exclusão", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    controllerCliente.ExcluirCliente(codigoCliente);
                    AtualizarDataGridView();
                    MessageBox.Show("Cliente excluído com sucesso!", "Exclusão realizada", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }

            if (e.RowIndex >= 0 && e.ColumnIndex == dataGridView1.Columns["Editar"].Index)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                PreencherCamposComDadosCliente(row);
                HabilitarCampos();
            }
        }

        private void LimparCampos()
        {
            txtNameCli.Text = string.Empty;
            txtAddressCli.Text = string.Empty;
            txtCpfCli.Text = string.Empty;
            txtRgCli.Text = string.Empty;
            txtTelCli.Text = string.Empty;
            cboxGenCli.SelectedIndex = -1;
            dataNascCli.Value = DateTime.Now;
            txtObsCli.Text = string.Empty;
        }

        private void BloquearCampos()
        {
            txtNameCli.Enabled = false;
            txtAddressCli.Enabled = false;
            txtCpfCli.Enabled = false;
            txtRgCli.Enabled = false;
            txtTelCli.Enabled = false;
            cboxGenCli.Enabled = false;
            dataNascCli.Enabled = false;
            txtObsCli.Enabled = false;
        }

        private void HabilitarCampos()
        {
            txtNameCli.Enabled = true;
            txtAddressCli.Enabled = true;
            txtCpfCli.Enabled = true;
            txtRgCli.Enabled = true;
            txtTelCli.Enabled = true;
            cboxGenCli.Enabled = true;
            dataNascCli.Enabled = true;
            txtObsCli.Enabled = true;
        }
    }
}
