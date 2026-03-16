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
    public partial class Form1 : Form
    {
        FlightPlan vuelo = new FlightPlan("Prueba 1", 67, 67, 690, 420, 1000);
        //✈️
        public Form1()
        {
            InitializeComponent();
        }

        private void btnLinea_Click(object sender, EventArgs e)
        {
            FormLinea ventana = new FormLinea(vuelo);
            ventana.Show();
        }
    }
}