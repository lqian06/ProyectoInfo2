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
    public partial class Form3DistSegurTiempCicl : Form
    {
        public Form3DistSegurTiempCicl()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }


        private bool EstructuraCorrecta = false;
        private void TextTiempoCiclo_TextChanged(object sender, EventArgs e)
        {
            if (EstructuraCorrecta)
            {
                return;
            }
            int res;
            try
            {
  
                res =Convert.ToInt32(TextTiempoCiclo.Text);
   

                return;
            }
            catch (FormatException)
            {
                EstructuraCorrecta = true;
                MessageBox.Show ("Escriba un número entero en el tiempo de ciclo");
                TextTiempoCiclo.Text="";
                EstructuraCorrecta = false;
                return;       
            }

        }

        private void TextDistanciaSeguridad_TextChanged(object sender, EventArgs e)
        {

            if (EstructuraCorrecta)
            {
                return;
            }
            int res;
            try
            {
                res = Convert.ToInt32(TextDistanciaSeguridad.Text);
                return;
            }
            catch (FormatException)
            {
                EstructuraCorrecta = true;
                MessageBox.Show("Escriba un número entero para la distancia de seguridad");
                TextDistanciaSeguridad.Text = "";
                EstructuraCorrecta = false;
                return;
            }

  
        }

        private void ClickBotón2(object sender, EventArgs e)
        {
            this.Close();
        }

        public int GetDistancia()
        {
            if (string.IsNullOrEmpty(TextDistanciaSeguridad.Text)) return 0;
            try { return Convert.ToInt32(TextDistanciaSeguridad.Text); }
            catch { return 0; }
        }

        public int GetTiempo()
        {
            if (string.IsNullOrEmpty(TextTiempoCiclo.Text)) return 0;
            try { return Convert.ToInt32(TextTiempoCiclo.Text); }
            catch { return 0; }
        }
    }
}
