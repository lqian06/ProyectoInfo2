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
        FlightPlan vuelo;
        int radio = 10;
        Timer timer = new Timer();

        public FormLinea(FlightPlan vuelo)
        {
            InitializeComponent();
            this.vuelo = vuelo;

            this.Paint += FormLinea_Paint;

            timer.Interval = 100;
            timer.Tick += Timer_Tick;
            timer.Start();
        }
        private void Timer_Tick(object sender, EventArgs e)
        {
            double tiempo = timer.Interval / 1000.0;

            vuelo.Mover(tiempo);

            this.Invalidate();
        }



        //Arte
        private void FormLinea_Paint(object sender, PaintEventArgs e)
        {
            Position inicio = vuelo.GetInitialPosition();
            Position fin = vuelo.GetFinalPosition();
            Position actual = vuelo.GetCurrentPosition();

            using (Pen lapiz = new Pen(Color.Black, 2))
            {
                e.Graphics.DrawLine(
                    lapiz,
                    (int)inicio.GetX(),
                    (int)inicio.GetY(),
                    (int)fin.GetX(),
                    (int)fin.GetY()
                );
            }

            using (Pen lapizCirculo = new Pen(Color.Red, 2))
            {
                e.Graphics.DrawEllipse(
                    lapizCirculo,
                    (int)actual.GetX() - radio,
                    (int)actual.GetY() - radio,
                    radio * 2,
                    radio * 2
                );
            }
        }
    }
}