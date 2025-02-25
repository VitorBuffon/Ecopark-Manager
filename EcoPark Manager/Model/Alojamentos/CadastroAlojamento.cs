using System;
using System.Data;
using System.Windows.Forms;
using EcoPark_Manager.Controller;

namespace EcoPark_Manager.Model.Alojamentos
{
    public partial class CadastroAlojamento : Form
    {
        private readonly ControllerAlojamento controllerAlojamentos;

        public CadastroAlojamento()
        {
            InitializeComponent();
            controllerAlojamentos = new ControllerAlojamento();
        }

        private void CadastroAlojamento_Load(object sender, EventArgs e)
        {
            // Inicializa os itens nos ComboBoxes
            cboxTipoAloj.Items.Add("Chale");
            cboxTipoAloj.Items.Add("Quiosque");
            cboxTipoAloj.Items.Add("Pia");

            cboxStatusAloj.Items.Add("Disponível");
            cboxStatusAloj.Items.Add("Indisponível");

            // Configura as colunas do DataGridView
            ConfigurarDataGridView();

            // Atualiza a lista de alojamentos
            AtualizarListaAlojamentos();
        }

        private void ConfigurarDataGridView()
        {
            dgvAlojamentos.AutoGenerateColumns = false;

            // Limpar colunas existentes
            dgvAlojamentos.Columns.Clear();

            // Adicionar as colunas
            dgvAlojamentos.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "alonumero",
                HeaderText = "Número",
                DataPropertyName = "alonumero",
                AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
            });

            dgvAlojamentos.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "alotipo",
                HeaderText = "Tipo",
                DataPropertyName = "alotipo",
                AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
            });

            dgvAlojamentos.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "alostatus",
                HeaderText = "Status",
                DataPropertyName = "alostatus",
                AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
            });

            dgvAlojamentos.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "aloobservacao",
                HeaderText = "Observação",
                DataPropertyName = "aloobservacao",
                AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
            });

            DataGridViewButtonColumn editColumn = new DataGridViewButtonColumn
            {
                Name = "editColumn",
                HeaderText = "Editar",
                Text = "Editar",
                UseColumnTextForButtonValue = true,
                AutoSizeMode = DataGridViewAutoSizeColumnMode.None,
                Width = 75
            };
            dgvAlojamentos.Columns.Add(editColumn);

            DataGridViewButtonColumn deleteColumn = new DataGridViewButtonColumn
            {
                Name = "deleteColumn",
                HeaderText = "Excluir",
                Text = "Excluir",
                UseColumnTextForButtonValue = true,
                AutoSizeMode = DataGridViewAutoSizeColumnMode.None,
                Width = 75
            };
            dgvAlojamentos.Columns.Add(deleteColumn);

            // Ajustar o DataGridView para se ajustar ao tamanho da tela
            dgvAlojamentos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void AtualizarListaAlojamentos()
        {
            DataTable dataTable = controllerAlojamentos.ObterAlojamentos();
            dgvAlojamentos.DataSource = dataTable;
        }

        private void btnGravarAloj_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(cboxTipoAloj.Text) ||
                string.IsNullOrWhiteSpace(txtNumeroAloj.Text) ||
                string.IsNullOrWhiteSpace(cboxStatusAloj.Text))
            {
                MessageBox.Show("Por favor, preencha todos os campos obrigatórios.", "Erro de validação", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string tipo = cboxTipoAloj.Text;
            string numero = txtNumeroAloj.Text;
            string status = cboxStatusAloj.Text;
            string observacao = txtObsAloj.Text;

            bool alojamentoExistente = controllerAlojamentos.VerificarExistenciaAlojamento(tipo, numero);

            if (alojamentoExistente)
            {
                DialogResult result = MessageBox.Show($"O alojamento {tipo} com número {numero} já existe. Deseja editar?", "Confirmação de Edição", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    controllerAlojamentos.AtualizarAlojamento(tipo, numero, status, observacao);
                    MessageBox.Show("Alojamento atualizado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                controllerAlojamentos.CadastrarAlojamento(tipo, numero, status, observacao);
                MessageBox.Show("Alojamento cadastrado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            AtualizarListaAlojamentos();
            LimparCampos();
        }

        private void btnLimparAloj_Click(object sender, EventArgs e)
        {
            LimparCampos();
        }

        private void LimparCampos()
        {
            txtNumeroAloj.Text = string.Empty;
            txtObsAloj.Text = string.Empty;
            cboxTipoAloj.SelectedIndex = -1;
            cboxStatusAloj.SelectedIndex = -1;
        }

        private void btnVoltarCadastroAloj_Click(object sender, EventArgs e)
        {
            this.Hide();
            TelaInicial formTelaInicial = new TelaInicial();
            formTelaInicial.Show();
            this.Close();
        }

        private void dgvAlojamentos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                if (dgvAlojamentos.Columns[e.ColumnIndex] is DataGridViewButtonColumn buttonColumn)
                {
                    if (buttonColumn.Name == "editColumn")
                    {
                        DataGridViewRow row = dgvAlojamentos.Rows[e.RowIndex];
                        cboxTipoAloj.Text = row.Cells["alotipo"].Value.ToString();
                        txtNumeroAloj.Text = row.Cells["alonumero"].Value.ToString();
                        cboxStatusAloj.Text = row.Cells["alostatus"].Value.ToString();
                        txtObsAloj.Text = row.Cells["aloobservacao"].Value.ToString();
                    }
                    else if (buttonColumn.Name == "deleteColumn")
                    {
                        string numero = dgvAlojamentos.Rows[e.RowIndex].Cells["alonumero"].Value.ToString();
                        string tipo = dgvAlojamentos.Rows[e.RowIndex].Cells["alotipo"].Value.ToString();

                        DialogResult result = MessageBox.Show($"Tem certeza que deseja excluir o alojamento número {numero}?", "Confirmar Exclusão", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                        if (result == DialogResult.Yes)
                        {
                            controllerAlojamentos.ExcluirAlojamento(tipo, numero);
                            MessageBox.Show("Alojamento excluído com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            AtualizarListaAlojamentos();
                        }
                    }
                }
            }
        }
    }
}
