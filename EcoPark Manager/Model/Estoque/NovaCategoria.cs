using System;
using System.Windows.Forms;
using EcoPark_Manager.Controller;  // Certifique-se de que o namespace esteja correto

namespace EcoPark_Manager.Model.Estoque
{
    public partial class NovaCategoria : Form
    {
        private readonly ControllerCategoria controllerCategoria;

        public NovaCategoria()
        {
            InitializeComponent();
            controllerCategoria = new ControllerCategoria(); // Inicializa o controlador
        }

        private void btnCleanCate_Click(object sender, EventArgs e)
        {
            LimparCampos();
        }

        private void btnVoltarCate_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void LimparCampos()
        {
            tboxNomeCate.Text = string.Empty;
        }

        public delegate void CategoriaCadastradaHandler();
        public event CategoriaCadastradaHandler CategoriaCadastrada;

        private void btnGravarCate_Click(object sender, EventArgs e)
        {
            string nomeCategoria = tboxNomeCate.Text.Trim();

            if (string.IsNullOrEmpty(nomeCategoria))
            {
                MessageBox.Show("O nome da categoria não pode estar vazio.");
                return;
            }

            try
            {
                controllerCategoria.CadastrarCategoria(nomeCategoria);
                CategoriaCadastrada?.Invoke(); // Notifica que a categoria foi cadastrada
                MessageBox.Show("Categoria gravada com sucesso!");
                LimparCampos();
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao gravar a categoria: {ex.Message}");
            }
        }


    }
}
