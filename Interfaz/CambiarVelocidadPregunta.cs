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
    public partial class CambiarVelocidadPregunta : Form
    {
        FlightPlanList planes = new FlightPlanList();
        int velmin = 40;
        int distanciaSegura;
        public CambiarVelocidadPregunta()
        {
            InitializeComponent();
        }

        public void SetPlanes(FlightPlanList lista, int distanciaSeg)
        {
            this.planes = lista;
            distanciaSegura = distanciaSeg;
        }

        public FlightPlanList GetPlanes()
        {
            return planes;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void SiCambiarVelBtn_Click(object sender, EventArgs e)
        {
            while (planes.GetFlightPlan(0).GetVelocidad() > velmin && planes.GetFlightPlan(0).HabraConflicto(planes.GetFlightPlan(1), distanciaSegura) == true)
            {
                planes.GetFlightPlan(0).SetVelocidad(planes.GetFlightPlan(0).GetVelocidad() - 5);
            }
            Close();
        }
    }
}
