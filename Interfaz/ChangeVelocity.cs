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
    public partial class ChangeVelocity : Form
    {
        FlightPlanList Lista;
        public ChangeVelocity()
        {
            InitializeComponent();
        }

        public void SetPlanes(FlightPlanList fpl)
        {
            this.Lista = fpl;
        }

        public FlightPlanList GetPlanes()
        {
            return Lista;
        }

        private void ChangeVelBtn_Click(object sender, EventArgs e)
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
    }
}
