using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EcoPark_Manager.Model
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string usuario = txtUsuario.Text;
            string senha = txtSenha.Text;

            // Verificar se o usuário e a senha estão corretos
            if (VerificarCredenciais(usuario, senha))
            {
                // Esconde a tela atual
                this.Hide();

                // Cria uma nova instância da tela Inicial
                TelaInicial telaInicial = new TelaInicial();

                // Exibe a tela Inicial
                telaInicial.Show();
            }
            else
            {
                this.Hide();

                // Cria uma nova instância da tela Inicial
                TelaInicial telaInicial = new TelaInicial();

                // Exibe a tela Inicial
                telaInicial.Show();
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private bool VerificarCredenciais(string usuario, string senha)
        {
            // Lógica para verificar se o usuário e a senha estão corretos
            // Aqui você deve substituir esta lógica pela que você utiliza em seu sistema
            // Por exemplo, pode ser uma consulta ao banco de dados para verificar se o usuário e senha existem e são válidos.

            // Aqui, vamos apenas usar um exemplo simples com valores fixos para demonstração:
            return (usuario == "admin" && senha == "123");
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }
    }
}
