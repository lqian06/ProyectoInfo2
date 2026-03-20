using FlightLib;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Interfaz
{
    public partial class FormLinea : Form
    {
        FlightPlanList ListaVuelos = new FlightPlanList();
        int radio = 10;
        int distSeguridad;
        int tCiclo;
        int segundos;
        string idA, idB;
        Position inicioA, inicioB, currentA, currentB, finalA, finalB, currentA1, currentB1;
        double velocityA, velocidadB;

        public FormLinea()
        {
            InitializeComponent();
        }
        public void SetVuelos(FlightPlan v1, FlightPlan v2, int ds, int tc)
        {
            ListaVuelos.AddFlightPlan(v1);
            ListaVuelos.AddFlightPlan(v2);
            this.distSeguridad = ds;
            this.tCiclo = tc;

            idA = v1.GetID();
            inicioA = v1.GetInitialPosition();
            currentA = v1.GetCurrentPosition();
            finalA = v1.GetFinalPosition();
            velocityA= v1.GetVelocidad();

            idB = v2.GetID();
            inicioB = v2.GetInitialPosition();
            currentB = v2.GetCurrentPosition();
            finalB = v2.GetFinalPosition();
            velocidadB= v2.GetVelocidad();
        }

        private void GridDatosVuelos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            MessageBox.Show("La distancia entre los vuelos es: " + ListaVuelos.GetFlightPlan(0).Distancia(ListaVuelos.GetFlightPlan(1)), "metros.");

        }

        private void button4_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            segundos = 0;

            for (int i = 0; i < ListaVuelos.GetNum(); i++)
            {
                FlightPlan vuelo = ListaVuelos.GetFlightPlan(i);
                Position inicio = vuelo.GetInitialPosition();

                vuelo.SetCurrentPosition(inicio.GetX(), inicio.GetY());

            }
            panel1.Invalidate();
        }

        // botones - iniciar simulación
        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Interval = 1000;
            timer1.Start();
        }

        // 1 ciclo
        private void button2_Click(object sender, EventArgs e)
        {
            timer1.Stop();

            for (int i = 0; i < ListaVuelos.GetNum(); i++)
            {
                ListaVuelos.GetFlightPlan(i).Mover(tCiclo);
            }
            panel1.Invalidate();
        }

        // para papu
        private void button3_Click(object sender, EventArgs e)
        {
            timer1.Stop();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            segundos++;
            bool[] llegadas = new bool[ListaVuelos.GetNum()];
            llegadas[0] = ListaVuelos.GetFlightPlan(0).HasArrived();
            llegadas[1] = ListaVuelos.GetFlightPlan(1).HasArrived();

            if ((llegadas[0] == false) || (llegadas[1] == false)) {
                for (int i = 0; i < ListaVuelos.GetNum(); i++)
                {
                    if (ListaVuelos.GetFlightPlan(i).HasArrived() != true)
                    { 
                        ListaVuelos.GetFlightPlan(i).Mover(tCiclo);
                    }
                }
                panel1.Invalidate();

            }
            else
            {
                timer1.Stop();
            }

            if (GridDatosVuelos.ColumnCount > 0 && GridDatosVuelos.RowCount > 0)
            {
                GridDatosVuelos[3, 1].Value = ListaVuelos.GetFlightPlan(0).GetCurrentPosition().GetX() + "," + ListaVuelos.GetFlightPlan(0).GetCurrentPosition().GetY();
                GridDatosVuelos[3, 2].Value = ListaVuelos.GetFlightPlan(1).GetCurrentPosition().GetX()+ "," + ListaVuelos.GetFlightPlan(1).GetCurrentPosition().GetY();
            }

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            
            for (int i = 0; i < ListaVuelos.GetNum(); i++)
            {
                
                Position inicio = ListaVuelos.GetFlightPlan(i).GetInitialPosition();
                Position fin = ListaVuelos.GetFlightPlan(i).GetFinalPosition();
                Position actual = ListaVuelos.GetFlightPlan(i).GetCurrentPosition();
                
                
                //Línea
                using (Pen lapiz = new Pen(Color.Black, 2))
                {
                    e.Graphics.DrawLine(lapiz, (int)inicio.GetX(), (int)inicio.GetY(), (int)actual.GetX(), (int)actual.GetY());
                }

                //Círculo
                FlightPlanList distancias = new FlightPlanList();
                for (int j = 0; j < ListaVuelos.GetNum(); j++)
                {
                    if (ListaVuelos.GetFlightPlan(j) != ListaVuelos.GetFlightPlan(i))
                    {
                        distancias.AddFlightPlan(ListaVuelos.GetFlightPlan(j));
                    }
                }
                for (int k = 0; k < distancias.GetNum(); k++)
                {
                    if (ListaVuelos.GetFlightPlan(i).Distancia(distancias.GetFlightPlan(k)) > (distSeguridad*2))
                    {
                        Pen lapizSeguro = new Pen(Color.FromArgb(100, Color.Orange), 1);
                        e.Graphics.DrawEllipse(lapizSeguro, (int)actual.GetX() - distSeguridad, (int)actual.GetY() - distSeguridad, distSeguridad * 2, distSeguridad * 2);
                        lapizSeguro.Dispose();
                    }
                    else
                    {
                        SolidBrush pintarcirculo = new SolidBrush(Color.Red);
                        e.Graphics.FillEllipse(pintarcirculo, (float)actual.GetX()-distSeguridad, (float)actual.GetY()-distSeguridad,distSeguridad*2,distSeguridad*2);
                        pintarcirculo.Dispose();
                    }
                }


                // Avión
                string iconoAvion = "\u2708";
                using (Font fuenteAvion = new Font("Arial", 14, FontStyle.Bold))
                {
                    e.Graphics.DrawString(iconoAvion, fuenteAvion, Brushes.Black, (float)actual.GetX() - 11, (float)actual.GetY() - 11);
                }
            }
        }

        private void FormLinea_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < ListaVuelos.GetNum(); i++)
            {
                Position inicio = ListaVuelos.GetFlightPlan(i).GetInitialPosition();
                Position fin = ListaVuelos.GetFlightPlan(i).GetFinalPosition();
                Position actual = inicio;

                FlightPlanList noPlan = new FlightPlanList();

                for (int j = 0; j < ListaVuelos.GetNum(); j++)
                {
                    if (ListaVuelos.GetFlightPlan(i) != ListaVuelos.GetFlightPlan(j))
                    {
                        noPlan.AddFlightPlan(ListaVuelos.GetFlightPlan(j));
                    }
                }

                for (int k = 0; k < noPlan.GetNum(); k++)
                {
                    if (ListaVuelos.GetFlightPlan(i).DistanciaMínima(noPlan.GetFlightPlan(k)) <= distSeguridad)
                    {
                        MessageBox.Show("El vuelo " + ListaVuelos.GetFlightPlan(i).GetID() + " tendrá conflicto con el vuelo " + noPlan.GetFlightPlan(k).GetID() + ".");
                    }
                }

                panel1.Invalidate();
            }
        }

        
        private void panel1_MouseClick(object sender, MouseEventArgs e)
        {
            for (int i = 0; i < ListaVuelos.GetNum(); i++)
            {
                Position actual = ListaVuelos.GetFlightPlan(i).GetCurrentPosition();
                Position inicio = ListaVuelos.GetFlightPlan(i).GetInitialPosition();
                Position destino = ListaVuelos.GetFlightPlan(i).GetFinalPosition();

                double dx = e.X - actual.GetX();
                double dy = e.Y - actual.GetY();
                double distanciaAlClic = Math.Sqrt((dx * dx) + (dy * dy));

                if (distanciaAlClic < (radio + 5))
                {
                    timer1.Stop();
                    string estadoVuelo = Convert.ToString(ListaVuelos.GetFlightPlan(i).HasArrived());
                    MessageBox.Show("Detalles del vuelo:\r\nID: " + ListaVuelos.GetFlightPlan(i).GetID() + "\r\nVelocidad: "
                        + ListaVuelos.GetFlightPlan(i).GetVelocidad() + "km/h\r\nPosición Actual: [" + actual.GetX() + "," + actual.GetY()
                        + "]\r\nOrigen: [" + inicio.GetX() + "," + inicio.GetY() + "]\r\nDestino: [" + destino.GetX() + "," + destino.GetY()
                        + "]\r\nEstado: " + estadoVuelo + "\r\nDistancia al destino: " + actual.Distancia(destino));
                }
            }
        }

        private void GridDatosVuelos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void BtnInfoVuelos_Click(object sender, EventArgs e)
        {
            //Para el grid
            GridDatosVuelos.ColumnCount = 6;        //El número de fila y columna hacemos una función para que cuente los datos y que vaya creciendo a medida que se añaden vuelos, pero por ahora lo dejamos así
            GridDatosVuelos.RowCount = 10;
            GridDatosVuelos.ColumnHeadersVisible = false;
            GridDatosVuelos.RowHeadersVisible = false;

            GridDatosVuelos[1, 0].Value = "ID";
            GridDatosVuelos[2, 0].Value = "InitialPosition";
            GridDatosVuelos[3, 0].Value = "CurrentPosition";
            GridDatosVuelos[4, 0].Value = "FinalPosition";
            GridDatosVuelos[5, 0].Value = "Velocidad";

            GridDatosVuelos[0, 1].Value = "Vuelo A";
            GridDatosVuelos[0, 2].Value = "Vuelo B";

            GridDatosVuelos[1, 1].Value = idA;
            GridDatosVuelos[2, 1].Value = inicioA.GetX() + "," + inicioA.GetY();
            GridDatosVuelos[3, 1].Value = ListaVuelos.GetFlightPlan(0).GetCurrentPosition().GetX()+ "," + ListaVuelos.GetFlightPlan(0).GetCurrentPosition().GetY();
            GridDatosVuelos[4, 1].Value = finalA.GetX() + "," + finalA.GetY();
            GridDatosVuelos[5, 1].Value = velocityA;

            GridDatosVuelos[1, 2].Value = idB;
            GridDatosVuelos[2, 2].Value = inicioB.GetX() + "," + inicioB.GetY();
            GridDatosVuelos[3, 2].Value = ListaVuelos.GetFlightPlan(1).GetCurrentPosition().GetX() + "," + ListaVuelos.GetFlightPlan(1).GetCurrentPosition().GetY();
            GridDatosVuelos[4, 2].Value = finalB.GetX() + "," + finalB.GetY();
            GridDatosVuelos[5, 2].Value = velocidadB;
        }
    }
    
}