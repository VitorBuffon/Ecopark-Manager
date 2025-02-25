using EcoPark_Manager.Controller;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace EcoPark_Manager.Model.Reservas
{
    public partial class NovaReserva : Form
    {
        private ControllerReserva controllerReserva;
        private ControllerCliente controllerCliente;

        public NovaReserva()
        {
            InitializeComponent();
            controllerReserva = new ControllerReserva();
            controllerCliente = new ControllerCliente();
        }

        private void NovaReserva_Load(object sender, EventArgs e)
        {
            cboxTipoAloj.Items.Add("Chale");
            cboxTipoAloj.Items.Add("Quiosque");
            cboxTipoAloj.Items.Add("Pia");
        }


        private void btnNovoCliente_Click(object sender, EventArgs e)
        {
            Cliente formCliente = new Cliente();
            formCliente.Show();
        }

        private void btnVerificarDisponibilidade_Click(object sender, EventArgs e)
        {
            int alocodigo = Convert.ToInt32(tboxNumAloj.Text);
            DateTime dataInicio = dtpDataInicio.Value;
            DateTime dataFim = dtpDataFim.Value;

            bool disponivel = controllerReserva.VerificarDisponibilidade(alocodigo, dataInicio, dataFim);

            if (disponivel)
            {
                MessageBox.Show("Alojamento disponível!");
            }
            else
            {
                MessageBox.Show("Alojamento indisponível nas datas selecionadas.");
            }
        }

        private void btnGravar_Click(object sender, EventArgs e)
        {
            try
            {
                int clicodigo = Convert.ToInt32(cboxCliAloj.SelectedValue);
                int alocodigo = Convert.ToInt32(tboxNumAloj.Text);
                DateTime dataInicio = dtpDataInicio.Value;
                DateTime dataFim = dtpDataFim.Value;
                decimal valor = Convert.ToDecimal(txtValor.Text);
                string observacao = txtObservacoes.Text;

                controllerReserva.CadastrarReserva(clicodigo, alocodigo, dataInicio, dataFim, valor, observacao);

                MessageBox.Show("Reserva cadastrada com sucesso!");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao cadastrar reserva: {ex.Message}");
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
