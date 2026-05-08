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
    public partial class CambiarVelocidadPregunta : Form // Form pregunta al usuario si cambiar velocidad del avión para resolver conflicto
    {
        FlightPlanList planes = new FlightPlanList();
        int velmin = 40;
        int distanciaSegura;
        public CambiarVelocidadPregunta() // inicializa el formulario
        {
            InitializeComponent();
        }

        public void SetPlanes(FlightPlanList lista, int distanciaSeg) // recibe la lista de planes y la distancia segura para el conflicto
        {
            this.planes = lista;
            distanciaSegura = distanciaSeg;
        }

        public FlightPlanList GetPlanes() // devuelve la lista de planes
        {
            return planes;
        }
        public double GetVelocidadSugerida() // devuelve la velocidad sugerida para resolver el conflicto
        {
            return planes.GetFlightPlan(0).GetVelocidad();
        }

        private void button2_Click(object sender, EventArgs e) // si el usuario no quiere cambiar la velocidad, se cierra el formulario
        {
            Close();
        }

        // Variable para indicar si el conflicto se resolvió o no
        private bool conflictoResuelto = false;
        public bool GetConflictoResuelto() // devuelve si el conflicto se resolvió o no
        {
            return conflictoResuelto;
        }

        // Método para cambiar la velocidad del avión y resolver el conflicto
        private void SiCambiarVelBtn_Click(object sender, EventArgs e)
        {
            double velocidadOriginal = planes.GetFlightPlan(0).GetVelocidad();

            while (planes.GetFlightPlan(0).GetVelocidad() > velmin && planes.GetFlightPlan(0).HabraConflicto(planes.GetFlightPlan(1), distanciaSegura))
            {
                planes.GetFlightPlan(0).SetVelocidad(planes.GetFlightPlan(0).GetVelocidad() - 5);
            }

            if (planes.GetFlightPlan(0).HabraConflicto(planes.GetFlightPlan(1), distanciaSegura) == false)
            {
                conflictoResuelto = true;
                MessageBox.Show("Velocidad sugerida: " + planes.GetFlightPlan(0).GetVelocidad() + "\nVelocidad anterior: " + velocidadOriginal + "\nConflicto resuelto.");
                Close();
            }
            else
            {
                conflictoResuelto = false;
                MessageBox.Show("No se pudo resolver. Velocidad mínima (" + velmin + " km/h) alcanzada.");
                Close();
            }




        }

    }
}

