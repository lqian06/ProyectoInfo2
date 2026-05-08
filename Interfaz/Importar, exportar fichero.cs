using FlightLib;
using Interfaz;
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

namespace Interfaz
{
    public partial class Importar__exportar_fichero : Form
    {
        public Importar__exportar_fichero()
        {
            InitializeComponent();
        }

       

        //Comprueba que se han cargado los datos
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

        //Cogemos los datos del menú de los FlightPlans
        FlightPlanList lista;

        public void SetLista(FlightPlanList lista)
        {
            this.lista = lista;
        }
        private void bttnExportarFlightPlan_Click(object sender, EventArgs e)
        {
            try
            {
                FlightPlan v1 = lista.GetFlightPlan(0);
                FlightPlan v2 = lista.GetFlightPlan(1);

                if (v1 == null || v2 == null)
                {
                    MessageBox.Show("Parámetros no definidos, seleccione en el menú para rellenar los campos");
                }
                else
                {
                    lista.GuardarEnArchivo(ExportarFlightPlanTextBox.Text);
                    MessageBox.Show("Archivo guardado correctamente.");
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("El formato del archivo no es correcto");
            }
        }
    }
}

