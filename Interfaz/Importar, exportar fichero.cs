using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FlightLib;

namespace Interfaz
{
    public partial class Importar__exportar_fichero : Form
    {
        public Importar__exportar_fichero()
        {
            InitializeComponent();
        }

        private void ImportarFlightPlanTextBox_TextChanged(object sender, EventArgs e)
        {
            List<FlightPlan> f = FlightPlan.LeerFlightPlanFichero(ImportarFlightPlanTextBox.Text);

            try
            {
                if (f != null && f.Count > 0)
                {
                    MessageBox.Show("Se ha cargado correctamente los datos");
                }

            }
            catch (FileNotFoundException)
            {
                MessageBox.Show("No hay ningún archivo encontrado");
            }
            catch (FormatException)
            {
                MessageBox.Show("El formato del archivo no es correcto");
            }
        }
           
        private void ExportarFlightPlanTextBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
