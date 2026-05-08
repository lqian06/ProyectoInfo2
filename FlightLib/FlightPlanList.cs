using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace FlightLib
{
    public class FlightPlanList
    {
        FlightPlan[] vector = new FlightPlan[100];
        int number = 0;

        public FlightPlanList()
        {
            FlightPlan[] vector = new FlightPlan[100];
            int number = 0;
        }

        public int AddFlightPlan(FlightPlan p)
        {
            if (number == 100)
            {
                return -1;
            }
            else
            {
                vector[number] = p;
                number++;
                return 0;
            }

        }
       
        public int GetNum()
        {
            return number;
        }

        public FlightPlan GetFlightPlan(int i)
        {
            if (i < 0 || i >= number)
            { return null; }

            else
            {
                return vector[i];
            }
        }

        public void Mover(double tiempo)
        {
            int i = 0;
            while (i < number)
            {
                vector[i].Mover(tiempo);
                i++;
            }

        }
        public void EscribeConsola()
        {
            int i = 0;
            while (i < number)
            {
                vector[i].EscribeConsola();
                i++;
            }

        }

        public bool CargarDesdeArchivo(string nombreArchivo)
        {
            try
            {
                StreamReader r = new StreamReader(nombreArchivo);
                string linea = r.ReadLine();

                number = 0;

                while (linea != null && number < 100)
                {
                    string[] datos = linea.Split(' ');

                    if (datos.Length >= 7) // tiene que tener al menos 7 elementos para ser un FlightPlan válido
                    {
                        FlightPlan f = new FlightPlan(datos[0], datos[1], Convert.ToDouble(datos[2]), Convert.ToDouble(datos[3]), Convert.ToDouble(datos[4]), Convert.ToDouble(datos[5]), Convert.ToDouble(datos[6]));
                        vector[number] = f;
                        number++;
                    }
                    linea = r.ReadLine();
                }
                r.Close();
                return true;
            }
            catch (FileNotFoundException)
            {
                Console.WriteLine("No se encontró el archivo");
                return false;
            }
            catch (Exception e)
            {
                Console.WriteLine("Error al cagar");
                return false;
            }
        }

        public void GuardarEnArchivo(string nombreArchivo)
        {
            // El crea o sobrescribe el archivo, si exist
            StreamWriter write = new StreamWriter(nombreArchivo);
            int i = 0;
            while (i < number)
            {
                write.WriteLine(vector[i].Escribirlinea());
                i++;
            }
            write.Close();
        }      

     }
}

