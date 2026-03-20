using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FlightLib;

namespace Interfaz
{
    public partial class MenuAñadirPlan : Form
    {
        string ida, idb;
        double velocidada, velocidadb;
        int xia, xib;
        int yia, yib;
        int xfa, xfb;
        int yfa, yfb;

        FlightPlan plan_a;
        FlightPlan plan_b;

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        FlightPlanList lista = new FlightPlanList();

        public MenuAñadirPlan()
        {
            InitializeComponent();
        }

        public int HayLista()
        {
            if (lista != null)
            {
                return 0;
            }
            else
            {
                return -1;
            }
        }

        public FlightPlanList GetLista()
        {
            return lista;
        }


        public FlightPlan GetPlan(int i)
        {
            return lista.GetFlightPlan(i);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                
                string ida = textBox1.Text;
                int velocidada = Convert.ToInt32(textBox2.Text);
                int xia = Convert.ToInt32(textBox3.Text);
                int yia = Convert.ToInt32(textBox4.Text);
                int xfa = Convert.ToInt32(textBox5.Text);
                int yfa = Convert.ToInt32(textBox6.Text);

                string idb = textBox7.Text;
                int velocidadb = Convert.ToInt32(textBox8.Text);
                int xib = Convert.ToInt32(textBox9.Text);
                int yib = Convert.ToInt32(textBox10.Text);
                int xfb = Convert.ToInt32(textBox11.Text);
                int yfb = Convert.ToInt32(textBox12.Text);

                //CAMBIAR CUANDO TOQUE ENTREGA BUENA ************************************************************************************
                this.plan_a = new FlightPlan(ida, xia, yia, xfa, yfa, velocidada);
                this.plan_b = new FlightPlan(idb, xib, yib, xfb, yfb, velocidadb);
                int añadida = lista.AddFlightPlan(plan_a);
                int añadidb = lista.AddFlightPlan(plan_b);

                if (añadida == 0 && añadidb == 0)
                {
                    MessageBox.Show("Se ha creado los planes de vuelo correctamente.");
                }
                else
                {
                    MessageBox.Show("Ha habido un problema al guardar algun flight plan.");
                }

                Close();
            }
            catch (FormatException)
            {
                MessageBox.Show("Error de formato");
            }
        }
    }
}