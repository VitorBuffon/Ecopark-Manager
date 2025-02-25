using EcoPark_Manager.Model.Alojamentos;
using EcoPark_Manager.Model.Funcionario;
using EcoPark_Manager.Model.Reservas;
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
    public partial class TelaInicial : Form
    {
        public TelaInicial()
        {
            InitializeComponent();
        }

        private void btnCliente_Click(object sender, EventArgs e)
        {

            // Cria uma instância da tela Cliente
          Cliente formCliente = new Cliente();

            // Exibe a tela Cliente
            formCliente.Show();

            // Libera os recursos da tela atual quando a tela Cliente for fechada
            formCliente.FormClosed += (s, args) => this.Close();

            // Oculta a tela atual
            this.Close();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnEstoque_Click(object sender, EventArgs e)
        {
            Estoques formEstoque = new Estoques();

            // Exibe a tela Cliente
            formEstoque.Show();

            // Libera os recursos da tela atual quando a tela Cliente for fechada
            formEstoque.FormClosed += (s, args) => this.Close();

            // Oculta a tela atual
            this.Close();
        }

        private void btnFuncionario_Click(object sender, EventArgs e)
        {
            // Criar uma instância da tela do funcionário
            EcoPark_Manager.Model.Funcionario.Funcionario funcionarioForm = new EcoPark_Manager.Model.Funcionario.Funcionario();

            // Exibir a tela do funcionário
            funcionarioForm.Show();

            // Fechar a tela atual
            this.Close();
        }

        private void btnReservas_Click(object sender, EventArgs e)
        {
            EcoPark_Manager.Model.Reservas.Reservas reservasForm = new EcoPark_Manager.Model.Reservas.Reservas();

            reservasForm.Show();

            this.Close();
        }

        private void btnAlojamentos_Click(object sender, EventArgs e)
        { 
            CadastroAlojamento formAlojamentos = new CadastroAlojamento();

            formAlojamentos.Show();
        }

        private void btnVenda_Click(object sender, EventArgs e)
        {
            EcoPark_Manager.Model.Vendas.Venda formVenda = new EcoPark_Manager.Model.Vendas.Venda();

            formVenda.Show();
        }
    }
}