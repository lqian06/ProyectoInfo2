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

 
           
        private void ExportarFlightPlanTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void bttnImportarFlightPlan_Click(object sender, EventArgs e)
        {
            FlightPlanList flightPlanList = new FlightPlanList();

            try
            {
                if (flightPlanList.CargarDesdeArchivo(ImportarFlightPlanTextBox.Text))
                {
                    MessageBox.Show("Archivo cargado correctamente");
                }
                else
                {
                    MessageBox.Show("No se ha podido cargar el archivo");

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
    }
}
