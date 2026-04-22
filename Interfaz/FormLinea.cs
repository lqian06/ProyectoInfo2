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

        // Iniciar el formulario.
        public FormLinea()
        {
            InitializeComponent();
        }


        // Variables globales
        FlightPlanList ListaVuelos = new FlightPlanList();
        int radio = 10;
        int distSeguridad;
        int tCiclo;
        int segundos;
        string idA, idB;
        Position inicioA, inicioB, currentA, currentB, finalA, finalB, currentA1, currentB1;
        double velocityA, velocidadB;


        // Función para establecer los vuelos, la distancia de seguridad y el tiempo de ciclo
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


        // Función para dibujar los vuelos, las líneas de trayectoria y los círculos de seguridad
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
                    e.Graphics.DrawLine(lapiz, (int)inicio.GetX(), (int)inicio.GetY(), (int)fin.GetX(), (int)fin.GetY());
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
                    if (ListaVuelos.GetFlightPlan(i).Distancia(distancias.GetFlightPlan(k)) > (distSeguridad * 2))
                    {
                        Pen lapizSeguro = new Pen(Color.FromArgb(100, Color.Orange), 1);
                        e.Graphics.DrawEllipse(lapizSeguro, (int)actual.GetX() - distSeguridad, (int)actual.GetY() - distSeguridad, distSeguridad * 2, distSeguridad * 2);
                        lapizSeguro.Dispose();
                    }
                    else
                    {
                        SolidBrush pintarcirculo = new SolidBrush(Color.Red);
                        e.Graphics.FillEllipse(pintarcirculo, (float)actual.GetX() - distSeguridad, (float)actual.GetY() - distSeguridad, distSeguridad * 2, distSeguridad * 2);
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


        // Función para mostrar la distancia entre los vuelos al hacer click en el grid
        private void GridDatosVuelos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            MessageBox.Show("La distancia entre los vuelos es: " + ListaVuelos.GetFlightPlan(0).Distancia(ListaVuelos.GetFlightPlan(1)), "metros.");
        }


        // Función para mostrar los detalles del vuelo al hacer click en el panel
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


        // Función para mover los vuelos cada segundo
        private void timer1_Tick(object sender, EventArgs e)
        {
            segundos++;
            if (ListaVuelos.GetFlightPlan(0).HabraConflicto(ListaVuelos.GetFlightPlan(1), distSeguridad) == true)
            {
                ChocaLabel.Text = "Choca";
            }
            else
            {
                ChocaLabel.Text = "No choca";
            }
            bool[] llegadas = new bool[ListaVuelos.GetNum()];
            llegadas[0] = ListaVuelos.GetFlightPlan(0).HasArrived();
            llegadas[1] = ListaVuelos.GetFlightPlan(1).HasArrived();

            if ((llegadas[0] == false) || (llegadas[1] == false))
            {
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
                GridDatosVuelos[3, 2].Value = ListaVuelos.GetFlightPlan(1).GetCurrentPosition().GetX() + "," + ListaVuelos.GetFlightPlan(1).GetCurrentPosition().GetY();
            }
        }


        // Botón iniciar simulación
        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Interval = 1000;
            timer1.Start();
        }


        // para papu :v
        private void btnParar_Click(object sender, EventArgs e)
        {
            timer1.Stop();
        }


        //Botón de pausa
        private void button5_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            segundos = 0;

            for (int i = 0; i < ListaVuelos.GetNum(); i++)
            {
                FlightPlan vuelo = ListaVuelos.GetFlightPlan(i);
                Position inicio = vuelo.GetInitialPosition();

                vuelo.SetCurrentPosition(inicio.GetX(), inicio.GetY());

            }
            if (GridDatosVuelos.ColumnCount > 0 && GridDatosVuelos.RowCount > 0)
            {
                GridDatosVuelos[3, 1].Value = ListaVuelos.GetFlightPlan(0).GetCurrentPosition().GetX() + "," + ListaVuelos.GetFlightPlan(0).GetCurrentPosition().GetY();
                GridDatosVuelos[3, 2].Value = ListaVuelos.GetFlightPlan(1).GetCurrentPosition().GetX() + "," + ListaVuelos.GetFlightPlan(1).GetCurrentPosition().GetY();
            }
            panel1.Invalidate();
        }


        // Botón añadir 1 ciclo
        private void button2_Click(object sender, EventArgs e)
        {
            timer1.Stop();

            for (int i = 0; i < ListaVuelos.GetNum(); i++)
            {
                ListaVuelos.GetFlightPlan(i).Mover(tCiclo);
            }
            panel1.Invalidate();

            if (GridDatosVuelos.ColumnCount > 0 && GridDatosVuelos.RowCount > 0)
            {
                GridDatosVuelos[3, 1].Value = ListaVuelos.GetFlightPlan(0).GetCurrentPosition().GetX() + "," + ListaVuelos.GetFlightPlan(0).GetCurrentPosition().GetY();
                GridDatosVuelos[3, 2].Value = ListaVuelos.GetFlightPlan(1).GetCurrentPosition().GetX() + "," + ListaVuelos.GetFlightPlan(1).GetCurrentPosition().GetY();
            }

        }


        

        // Función para mostrar los conflictos entre vuelos al cargar el formulario
        private void FormLinea_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < ListaVuelos.GetNum(); i++)
            {
                Position inicio = ListaVuelos.GetFlightPlan(i).GetInitialPosition();
                Position fin = ListaVuelos.GetFlightPlan(i).GetFinalPosition();
                Position actual = inicio;

            }

            /*bool conflicto = ListaVuelos.GetFlightPlan(0).HabraConflicto(ListaVuelos.GetFlightPlan(1), distSeguridad);
            if (conflicto)
            {
                CambiarVelocidadPregunta formPregunta = new CambiarVelocidadPregunta();
                formPregunta.SetPlanes(ListaVuelos, distSeguridad);
                formPregunta.ShowDialog();
                ListaVuelos = formPregunta.GetPlanes();
                SetVuelos(ListaVuelos.GetFlightPlan(0), ListaVuelos.GetFlightPlan(1), distSeguridad, tCiclo);
                if (GridDatosVuelos.ColumnCount > 0 && GridDatosVuelos.RowCount > 0)
                {
                    GridDatosVuelos[5, 1].Value = ListaVuelos.GetFlightPlan(0).GetVelocidad();
                    GridDatosVuelos[5, 2].Value = ListaVuelos.GetFlightPlan(1).GetVelocidad();
                }
                
            }*/
            
            panel1.Invalidate();

            //arreglar conflicto
            FlightPlan v1 = ListaVuelos.GetFlightPlan(0);
            FlightPlan v2 = ListaVuelos.GetFlightPlan(1);

            double sugerencia;
            if (v1.SugerirVelocidadParaEvitarColision(v2, distSeguridad, out sugerencia))
            {
                CambiarVelocidadPregunta formPregunta = new CambiarVelocidadPregunta();

                if (formPregunta.ShowDialog() == DialogResult.OK)
                {
                    v1.SetVelocidad(sugerencia);

                    if (GridDatosVuelos.ColumnCount > 0)
                        GridDatosVuelos[5, 1].Value = v1.GetVelocidad();

                    MessageBox.Show("Velocidad modificada automáticamente para evitar colisión.");
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



        //Botón de reiniciar simulación
        private void RestartSimBtn_Click(object sender, EventArgs e)
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


        // Botón para cambiar la velocidad de los vuelos en el momento
        private void CambiarVelBtn_Click(object sender, EventArgs e)
        {
            ChangeVelocity formChanging = new ChangeVelocity();
            formChanging.SetPlanes(ListaVuelos);
            formChanging.ShowDialog();
            ListaVuelos = formChanging.GetPlanes();
            SetVuelos(ListaVuelos.GetFlightPlan(0), ListaVuelos.GetFlightPlan(1), distSeguridad, tCiclo);

            try
            {

                timer1.Stop();
                segundos = 0;

                if (GridDatosVuelos.ColumnCount > 0 && GridDatosVuelos.RowCount > 0)
                {
                    GridDatosVuelos[5, 1].Value = ListaVuelos.GetFlightPlan(0).GetVelocidad();
                    GridDatosVuelos[5, 2].Value = ListaVuelos.GetFlightPlan(1).GetVelocidad();
                }
                MessageBox.Show("Velocidades cambiadas");
                for (int i = 0; i < ListaVuelos.GetNum(); i++)
                {
                    FlightPlan vuelo = ListaVuelos.GetFlightPlan(i);
                    Position inicio = vuelo.GetInitialPosition();
                    vuelo.SetCurrentPosition(inicio.GetX(), inicio.GetY());
                }
                panel1.Invalidate();
            }
            catch (FormatException)
            {
                MessageBox.Show("Por favor, ingrese un número válido para la velocidad.");
            }
        }
    }
}