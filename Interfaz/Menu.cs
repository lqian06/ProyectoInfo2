using FlightLib;
using System;
using System.Windows.Forms;

namespace Interfaz
{
    public partial class Menu : Form
    {
        // lista gloval
        FlightPlanList planes = new FlightPlanList();
        
        // Datos del form3
        int distanciaSeguridad = 0;
        int tiempoCiclo = 0;

        public Menu()
        {
            InitializeComponent();
        }

        //Añadir datos de vuelo de los FlightPlans
        private void Botón2_Click(object sender, EventArgs e)
        {
            MenuAñadirPlan Form2 = new MenuAñadirPlan();
            Form2.ShowDialog();
            if (Form2.HayLista() == 0)
            {
                this.planes = Form2.GetLista();
                MessageBox.Show("Planes de vuelo cargados correctamente");
            }
        }

        //Distancias de seguridad y tiempo de ciclo
        private void uNOToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormDistSegurTiempCicl form3 = new FormDistSegurTiempCicl();

            form3.ShowDialog();

            this.distanciaSeguridad = form3.GetDistancia();
            this.tiempoCiclo = form3.GetTiempo();

            if (distanciaSeguridad > 0)
            {
                MessageBox.Show("Configuración guardada en el Menú.");
            }
        }

        //arte
        private void botón4ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        //¿¿Esto qué hace??
        private void Menu_Load(object sender, EventArgs e) { }
        private void tRESToolStripMenuItem_Click(object sender, EventArgs e) {
            FlightPlan v1 = planes.GetFlightPlan(0);
            FlightPlan v2 = planes.GetFlightPlan(1);

            if (v1 == null || v2 == null)
            {
                MessageBox.Show("Error: No hay datos de vuelos. Entra en el botón DOS y dale a Guardar.");
                return;
            }

            FormLinea ventana = new FormLinea();
            ventana.SetVuelos(v1, v2, distanciaSeguridad, tiempoCiclo);
            ventana.Show();
        }
        private void menúToolStripMenuItem_Click(object sender, EventArgs e) { }

        private void BtnConflicto_Click(object sender, EventArgs e)
        {
            if (planes.GetNum() >= 2)
            {
                if (planes.GetFlightPlan(0).HabraConflicto(planes.GetFlightPlan(1), distanciaSeguridad))
                {
                    MessageBox.Show("¡Alerta! Habrá un conflicto entre los vuelos.");
                }
                else
                {
                    MessageBox.Show("No habrá ningún conflicto entre los vuelos.");
                }
            }
            else {
                    MessageBox.Show("Error: No hay datos de vuelos.");
            }
        }
    }
}