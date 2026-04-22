using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FlightLib;

namespace Interfaz
{
    public partial class Grid : Form
    {
        public Grid()
        {
            InitializeComponent();
        }

        public void CargarDatos(FlightPlanList ListaVuelos, string idA, string idB)
        {
            GridDatosVuelos.ColumnCount = 6;
            GridDatosVuelos.RowCount = 10;
            GridDatosVuelos.ColumnHeadersVisible = false;
            GridDatosVuelos.RowHeadersVisible = false;

            // Encabezados
            GridDatosVuelos[1, 0].Value = "ID";
            GridDatosVuelos[2, 0].Value = "InitialPosition";
            GridDatosVuelos[3, 0].Value = "CurrentPosition";
            GridDatosVuelos[4, 0].Value = "FinalPosition";
            GridDatosVuelos[5, 0].Value = "Velocidad";

            GridDatosVuelos[0, 1].Value = "Vuelo A";
            GridDatosVuelos[0, 2].Value = "Vuelo B";

            // Datos Vuelo A
            var v1 = ListaVuelos.GetFlightPlan(0);
            GridDatosVuelos[1, 1].Value = idA;
            GridDatosVuelos[2, 1].Value = v1.GetInitialPosition().GetX() + "," + v1.GetInitialPosition().GetY();
            GridDatosVuelos[3, 1].Value = v1.GetCurrentPosition().GetX() + "," + v1.GetCurrentPosition().GetY();
            GridDatosVuelos[4, 1].Value = v1.GetFinalPosition().GetX() + "," + v1.GetFinalPosition().GetY();
            GridDatosVuelos[5, 1].Value = v1.GetVelocidad();

            // Datos Vuelo B
            var v2 = ListaVuelos.GetFlightPlan(1);
            GridDatosVuelos[1, 2].Value = idB;
            GridDatosVuelos[2, 2].Value = v2.GetInitialPosition().GetX() + "," + v2.GetInitialPosition().GetY();
            GridDatosVuelos[3, 2].Value = v2.GetCurrentPosition().GetX() + "," + v2.GetCurrentPosition().GetY();
            GridDatosVuelos[4, 2].Value = v2.GetFinalPosition().GetX() + "," + v2.GetFinalPosition().GetY();
            GridDatosVuelos[5, 2].Value = v2.GetVelocidad();
        }

        public void ActualizarValores(FlightPlanList ListaVuelos, string idA, string idB)
        {
            if (ListaVuelos.GetNum() < 2) return;

            var v1 = ListaVuelos.GetFlightPlan(0);
            var v2 = ListaVuelos.GetFlightPlan(1);

            // Vuelo A
            GridDatosVuelos[1, 1].Value = idA;
            GridDatosVuelos[2, 1].Value = v1.GetInitialPosition().GetX() + "," + v1.GetInitialPosition().GetY();
            GridDatosVuelos[3, 1].Value = v1.GetCurrentPosition().GetX() + "," + v1.GetCurrentPosition().GetY();
            GridDatosVuelos[4, 1].Value = v1.GetFinalPosition().GetX() + "," + v1.GetFinalPosition().GetY();
            GridDatosVuelos[5, 1].Value = v1.GetVelocidad();

            // Vuelo B
            GridDatosVuelos[1, 2].Value = idB;
            GridDatosVuelos[2, 2].Value = v2.GetInitialPosition().GetX() + "," + v2.GetInitialPosition().GetY();
            GridDatosVuelos[3, 2].Value = v2.GetCurrentPosition().GetX() + "," + v2.GetCurrentPosition().GetY();
            GridDatosVuelos[4, 2].Value = v2.GetFinalPosition().GetX() + "," + v2.GetFinalPosition().GetY();
            GridDatosVuelos[5, 2].Value = v2.GetVelocidad();
        }
    }
}
