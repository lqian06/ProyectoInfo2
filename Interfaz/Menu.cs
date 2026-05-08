using FlightLib;
using System;
using System.Windows.Forms;

namespace Interfaz
{
    public partial class Menu : Form // Formulario del menú principal
    {
        // lista gloval
        FlightPlanList planes = new FlightPlanList();

        // Datos del form3
        int distanciaSeguridad = 0;
        int tiempoCiclo = 0;

        public Menu() // Iniciar el formulario
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

        private void Menu_Load(object sender, EventArgs e) { } // Cargar el menú
        private void tRESToolStripMenuItem_Click(object sender, EventArgs e) // Botón para mostrar la línea de tiempo
        {
            FlightPlan v1 = planes.GetFlightPlan(0);
            FlightPlan v2 = planes.GetFlightPlan(1);

            if (v1 == null || v2 == null)
            {
                MessageBox.Show("Error: No hay datos de vuelos. Entra en el botón Planes de vuelo y crea uno");
                return;
            }

            FormLinea ventana = new FormLinea();
            ventana.SetVuelos(v1, v2, distanciaSeguridad, tiempoCiclo);
            ventana.Show();
        }
        private void menúToolStripMenuItem_Click(object sender, EventArgs e) { } // Botón para mostrar la cuadrícula

        private void BtnConflicto_Click(object sender, EventArgs e) // Botón para mostrar si habrá un conflicto entre los vuelos
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
            else
            {
                MessageBox.Show("Error: No hay datos de vuelos.");
            }
        }

        private void ImportarFlightPlan_Click(object sender, EventArgs e) // Botón para importar o exportar un fichero con los datos de los vuelos
        {

            Importar__exportar_fichero form4 = new Importar__exportar_fichero();
            form4.SetLista(planes);
            form4.ShowDialog();

        }
    }
}