using FlightLib;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Interfaz
{
    public partial class ChangeVelocity : Form // Formulario para cambiar la velocidad de los aviones
    {
        FlightPlanList Lista;
        public ChangeVelocity() //  Constructor del formulario
        {
            InitializeComponent();
        }

        public void SetPlanes(FlightPlanList fpl) // Se le asigna la lista de aviones al formulario
        {
            this.Lista = fpl;
        }

        public FlightPlanList GetPlanes() // Se obtiene la lista de aviones del formulario
        {
            return Lista;
        }

        private void ChangeVelBtn_Click(object sender, EventArgs e) // Botón para cambiar la velocidad de los aviones
        {
            try
            {
                Lista.GetFlightPlan(0).SetVelocidad(Convert.ToDouble(textBox1.Text));
                Lista.GetFlightPlan(1).SetVelocidad(Convert.ToDouble(textBox2.Text));
                Close();
            }
            catch
            {
                MessageBox.Show("Introduce un número válido");
            }
        }

        private void ChangeVelocity_Load(object sender, EventArgs e) // Al cargar el formulario se muestran las velocidades actuales de los aviones
        {
            textBox1.Text = Convert.ToString(Lista.GetFlightPlan(0).GetVelocidad());
            textBox2.Text = Convert.ToString(Lista.GetFlightPlan(1).GetVelocidad());
        }
    }
}
