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
    public partial class FormLinea : Form
    {
        List<FlightPlan> listaVuelos = new List<FlightPlan>();
        int radio = 10;
        Timer timer = new Timer();


        public FormLinea(FlightPlan vuelo1, FlightPlan vuelo2)
        {
            InitializeComponent();
            listaVuelos.Add(vuelo1);
            listaVuelos.Add(vuelo2);

            this.DoubleBuffered = true;
            this.Paint += FormLinea_Paint;
            this.MouseClick += FormLinea_MouseClick;

            timer.Interval = 100;
            timer.Tick += Timer_Tick;
        }
        private void Timer_Tick(object sender, EventArgs e)
        {
            double tiempo = timer.Interval / 1000.0;
            foreach (FlightPlan vueloX in listaVuelos)
            {
                vueloX.Mover(tiempo);
            }

            this.Invalidate();
        }


        //INFORMACION AL CLICKAR
        private void FormLinea_MouseClick(object sender, MouseEventArgs e)
        {
            foreach (FlightPlan vueloX in listaVuelos)
            {
                Position actual = vueloX.GetCurrentPosition();
                Position inicio = vueloX.GetInitialPosition();
                Position destino = vueloX.GetFinalPosition();

                // Cálculo de distancia para el clic
                double dx = e.X - actual.GetX();
                double dy = e.Y - actual.GetY();
                double distanciaAlClic = Math.Sqrt(dx * dx + dy * dy);

                if (distanciaAlClic <= radio + 5)
                {
                    timer.Stop();

                    string estadoVuelo = vueloX.HasArrived() ? "¡HA LLEGADO!" : "En trayecto";

                    string info = $"DETALLES DEL VUELO\n\n" +
                                  $"ID: {vueloX.GetID()}\n" +
                                  $"Velocidad: {vueloX.GetVelocidad():F2} km/h\n" +
                                  $"Posición Actual: ({actual.GetX():F2}, {actual.GetY():F2})\n" +
                                  $"Destino: ({destino.GetX()}, {destino.GetY()})\n" +
                                  $"Origen: ({inicio.GetX()}, {inicio.GetY()})\n" +
                                  $"Estado: {estadoVuelo}\n\n" +
                                  $"Distancia al destino: {actual.Distancia(destino):F2} unidades";

                    MessageBox.Show(info, $"Radar - {vueloX.GetID()}", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    break;
                }
            }
        }


        // botones - iniciar simulación
        private void button1_Click(object sender, EventArgs e)
        {
            timer.Start();
        }

        // 1 ciclo
        private void button2_Click(object sender, EventArgs e)
        {
            timer.Stop();
            foreach (FlightPlan v in listaVuelos)
            {
                v.Mover(0.5);
            }
            this.Invalidate();
        }

        // para papu
        private void button3_Click(object sender, EventArgs e)
        {
            timer.Stop();

        }


        //Arte
        private void FormLinea_Paint(object sender, PaintEventArgs e)
        {
            foreach (FlightPlan vueloActual in listaVuelos)
            {
                Position inicio = vueloActual.GetInitialPosition();
                Position fin = vueloActual.GetFinalPosition();
                Position actual = vueloActual.GetCurrentPosition();

                // Línea
                using (Pen lapiz = new Pen(Color.Black, 2))
                {
                    e.Graphics.DrawLine(lapiz, (int)inicio.GetX(), (int)inicio.GetY(), (int)fin.GetX(), (int)fin.GetY());
                }

                // Círculo
                using (Pen lapizRadar = new Pen(Color.Red, 2))
                {
                    e.Graphics.DrawEllipse(lapizRadar, (int)actual.GetX() - radio, (int)actual.GetY() - radio, radio * 2, radio * 2);
                }

                // Avión
                string iconoAvion = "\u2708";
                using (Font fuenteAvion = new Font("Arial", 14, FontStyle.Bold))
                {
                    e.Graphics.DrawString(iconoAvion, fuenteAvion, Brushes.Black, (float)actual.GetX() - 11, (float)actual.GetY() - 11);
                }
            }
        }
    }
}