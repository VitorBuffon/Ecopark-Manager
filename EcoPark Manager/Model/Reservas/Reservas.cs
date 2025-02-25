using EcoPark_Manager.Model.Alojamentos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EcoPark_Manager.Model.Reservas
{
    public partial class Reservas : Form
    {
        public Reservas()
        {
            InitializeComponent();
        }

        private void Reservas_Load(object sender, EventArgs e)
        {
            this.reservaTableAdapter.Fill(this.ecoparkDataSet2.Reserva);

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnNovaRes_Click(object sender, EventArgs e)
        {
            NovaReserva formReservas = new NovaReserva();

            formReservas.Show();
        }

        private void btnConsultarAloj_Click(object sender, EventArgs e)
        {

        }

        private void btnConsultarRes_Click(object sender, EventArgs e)
        {

        }

        private void btnSairRes_Click(object sender, EventArgs e)
        {
            this.Hide();

            // Exibe a tela principal 
            TelaInicial formTelaInicial = new TelaInicial();
            formTelaInicial.Show();

            // Fecha a tela de reservas
            this.Close();
        }

    }
}
