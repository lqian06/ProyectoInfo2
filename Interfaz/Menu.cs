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
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void Botón2_Click(object sender, EventArgs e)
        {
           
        }

        private void tRESToolStripMenuItem_Click(object sender, EventArgs e)
        {
   
        }

        private void uNOToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form3DistSegurTiempCicl form3 = new Form3DistSegurTiempCicl();
            form3.Show();
        }
        private void menúToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        //NO BORRAR HASTA QUE SEPA DONDE TENGO QUE PONER ESTO, LOS DATOS PARA DIBUJAR LA LINEA AAAAAAAAAA 
        // Datos de los dos vuelos para la simulación
        FlightPlan vuelo1 = new FlightPlan("I have nothing but my sorrow and I want nothing more. It has been, it still is, faithful to me.\r\n\r\nWhy should I begrudge it, since during the hours when my soul crushed the depths of my heart, it was seated there beside me?\r\n\r\nO sorrow, I have ended, you see, by respecting you, because I am certain you will never leave me.\r\n\r\nAh! I realize it: your beauty lies in the force of your being. You are like those who never left the sad fireside corner of my poor black heart.\r\n\r\nO my sorrow, you are better than a well-beloved: because I know that on the day of my final agony, you will be there, lying in my sheets, O sorrow, so that you might once again attempt to enter my heart. \r\n \r\n \r\nI'm lost in your world\r\nLooking for a purpose that belongs to me only\r\nMay the lilies bloom for me\r\nDo you hear the lilies speak?\r\nThe leaves kissing the bees\r\nThe soil covering up all the sorrow\r\nAll the seeds I sowed\r\nIn a garden can't be claimed by me\r\nDo you hear the lilies speak?\r\nI gave it my all\r\nIsn't it supposed to be sunny now?\r\nBut my rain won't stop\r\nMy rain won't stop\r\nThe hell I saw, voices I heard\r\nThe dreams that I lost changed nothing at all\r\nI'm still my insufferable self\r\nSetting my hair on fire\r\nGiving you warmth\r\nHoping you'd rеalize I want you by my side\r\nMay the liliеs bloom for me\r\nThought I would be satisfied\r\nSeeing you content at the other side\r\nBut somehow I thought these crazy thoughts\r\nThat I deserve to be loved\r\nI deserve to know love\r\nWe deserve to live in love\r\nI wish there's no end\r\nI wish there's no end to our time together\r\nThe lilies wilted\r\nWaving down into my coffin\r\nGoodbye, my youth expensed\r\nGoodbye, my innocence\r\nShould I be mad? Should I be glad?\r\nAm I enough?\r\nHow can I be enough so I'm proud of myself?\r\nReaching my goals\r\nDistracting my feelings changed nothing at all\r\nI'm still my insatiable self\r\nIsn't it better to be dumb?\r\nTo be ignorant? Not knowing there is liberty\r\nIn this world not meant for me\r\nMay the lilies bloom for me", 50, 50, 600, 400, 1200);
        FlightPlan vuelo2 = new FlightPlan("PUTO RAYANER", 50, 400, 600, 50, 1100);

        private void botón4ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormLinea ventana = new FormLinea(vuelo1, vuelo2);
            ventana.Show();
        }

        private void Menu_Load(object sender, EventArgs e)
        {

        }
    }
}
