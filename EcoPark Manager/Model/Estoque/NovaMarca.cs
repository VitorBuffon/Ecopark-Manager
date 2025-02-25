using System;
using System.Data;
using System.Windows.Forms;
using EcoPark_Manager.Controller; 

namespace EcoPark_Manager.Model.Estoque
{
    public partial class NovaMarca : Form
    {
        private readonly ControllerMarca _controllerMarca;

        public event Action MarcaCadastrada;

        public NovaMarca()
        {
            InitializeComponent();
            _controllerMarca = new ControllerMarca(); 
        }

        private void btnGravarMarca_Click(object sender, EventArgs e)
        {
            string nomeMarca = tboxNomeMarca.Text.Trim();

            if (string.IsNullOrEmpty(nomeMarca))
            {
                MessageBox.Show("Por favor, insira o nome da marca.");
                return;
            }

            try
            {
                _controllerMarca.CadastrarMarca(nomeMarca);
                MessageBox.Show("Marca gravada com sucesso!");

                MarcaCadastrada?.Invoke();

                LimparCampos();
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao gravar a marca: {ex.Message}");
            }
        }

        private void btnCleanMarca_Click(object sender, EventArgs e)
        {
            LimparCampos();
        }

        private void btnVoltarMarca_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tboxNomeMarca_TextChanged(object sender, EventArgs e)
        {
            // Lógica adicional, se necessário
        }

        private void LimparCampos()
        {
            tboxNomeMarca.Text = string.Empty;
        }
    }
}
