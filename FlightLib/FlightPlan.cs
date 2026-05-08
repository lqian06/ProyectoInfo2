using FlightLib;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlightLib
{
    public class FlightPlan
    {
        // Atributos

        string id; // identificador
        string company; // compañia aerea
        double initialx; // coordenada x de la posición inicial
        double initialy; // coordenada y de la posición inicial
        double finalx; // coordenada x de la posición final
        double finaly; // coordenada y de la posición final
        Position initialPosition;
        Position currentPosition; // posicion actual
        Position finalPosition; // posicion final
        double velocidad;

        // Constructor primeras versiones sin compañia
        public FlightPlan(string id, double cpx, double cpy, double fpx, double fpy, double velocidad)
        {
            this.id = id;
            this.initialPosition = new Position(cpx, cpy);
            this.currentPosition = new Position(cpx, cpy);
            this.finalPosition = new Position(fpx, fpy);
            this.velocidad = velocidad;
        }

        //FlightPlan nuevo más compañía para la Versión 2
        public FlightPlan (string id, string company, double initialx, double initialy, double finalx, double finaly, double velocidad)
        {
            this.id = id;
            this.company= company;
            this.initialPosition = new Position(initialx, initialy);
            this.finalPosition = new Position(finalx, finaly);
            this.velocidad = velocidad;

        }

        //||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||

        public Position GetCurrentPosition()
        {
            return currentPosition;
        }
        public void SetCurrentPosition(double x, double y)
        {
            currentPosition = new Position(x, y);
        }

        public void SetID(string id)
        {
            this.id = id;
        }
        public string GetID()
        {
            return id;
        }

        public void SetVelocidad(double velocidad)
        {
            this.velocidad = velocidad;
        }
        public double GetVelocidad()
        {
            return this.velocidad;
        }

        public Position GetFinalPosition()
        {
            return this.finalPosition;
        }
        public void SetFinalPosition(double x, double y)
        {
            this.finalPosition = new Position(x, y);
        }

        public Position GetInitialPosition()
        {
            return this.initialPosition;
        }
        public void SetInitialPosition(double x, double y)
        {
            this.initialPosition = new Position(x, y);
        }


        //||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||








        public void Mover(double tiempo)
        // Mueve el vuelo a la posición correspondiente a viajar durante el tiempo que se recibe como parámetro
        {
            //Calculamos la distancia recorrida en el tiempo dado
            double distancia = tiempo * this.velocidad / 60;

            //Calculamos las razones trigonométricas
            double hipotenusa = Math.Sqrt((finalPosition.GetX() - currentPosition.GetX()) * (finalPosition.GetX() - currentPosition.GetX()) + (finalPosition.GetY() - currentPosition.GetY()) * (finalPosition.GetY() - currentPosition.GetY()));
            double coseno = (finalPosition.GetX() - currentPosition.GetX()) / hipotenusa;
            double seno = (finalPosition.GetY() - currentPosition.GetY()) / hipotenusa;

            //Caculamos la nueva posición del vuelo
            double x = currentPosition.GetX() + distancia * coseno;
            double y = currentPosition.GetY() + distancia * seno;

            Position nextPosition = new Position(x, y);

            // Modificar MoverVuelo para que no se pase del destino
            if (currentPosition.Distancia(nextPosition) < hipotenusa)
            {
                currentPosition = nextPosition;
            }
            else
            {
                currentPosition = finalPosition;
            }

        }

        // Hacer un metodo que diga si un vuelo ha llegado a su destino
        public bool HasArrived()
        {
            bool resultado = false;
            if ((Math.Abs(currentPosition.GetX() - initialPosition.GetX()) >= Math.Abs(finalPosition.GetX() - initialPosition.GetX())) && (Math.Abs(currentPosition.GetY() - initialPosition.GetY()) >= Math.Abs(finalPosition.GetY() - initialPosition.GetY())))
            {
                resultado = true;
            }
            return resultado;
        }

        // Hacer que el programa principal lea datos de dos vuelos y una distancia de seguidad y detecte el conflicto cuándo los vuelos están mas cerca de esa distancia
        public bool Conflicto(FlightPlan b, double distanciaSeguridad)
        {
            bool conclicto = false;

            if (this.currentPosition.Distancia(b.currentPosition) < distanciaSeguridad)
            {
                conclicto = true;
            }

            return conclicto;
        }

        public void EscribeConsola()
        // escribe en consola los datos del plan de vuelo
        {
            Console.WriteLine("******************************");
            Console.WriteLine("Datos del vuelo: ");
            Console.WriteLine("Identificador: {0}", id);
            Console.WriteLine("Velocidad: {0:F2}", velocidad);
            Console.WriteLine("Posición actual: ({0:F2}, {1:F2})", currentPosition.GetX(), currentPosition.GetY());
            if (this.HasArrived())
            {
                Console.WriteLine("Ha llegado al destino");
            }
            Console.WriteLine("******************************");
        }

        public void Restart()
        {
            this.SetCurrentPosition(initialPosition.GetX(), initialPosition.GetY());
        }

        public double Distancia(FlightPlan b)
        {
            double d = Math.Sqrt((b.GetCurrentPosition().GetX() - this.GetCurrentPosition().GetX()) * (b.GetCurrentPosition().GetX() - this.GetCurrentPosition().GetX()) + (b.GetCurrentPosition().GetY() - this.GetCurrentPosition().GetY()) * (b.GetCurrentPosition().GetY() - this.GetCurrentPosition().GetY()));
            return d;
        }

        public double DistanciaMinima(FlightPlan b)
        {
            double tiempoMinimo;
            double distanciaMinima;

            double velocidadA = velocidad / 60;
            double velocidadB = b.GetVelocidad() / 60;

            double hipotenusaA = Math.Sqrt((finalPosition.GetX() - initialPosition.GetX()) * (finalPosition.GetX() - initialPosition.GetX()) + (finalPosition.GetY() - initialPosition.GetY()) * (finalPosition.GetY() - initialPosition.GetY()));
            double hipotenusaB = Math.Sqrt((b.GetFinalPosition().GetX() - b.GetInitialPosition().GetX()) * (b.GetFinalPosition().GetX() - b.GetInitialPosition().GetX()) + (b.GetFinalPosition().GetY() - b.GetInitialPosition().GetY()) * (b.GetFinalPosition().GetY() - b.GetInitialPosition().GetY()));

            double cosenoA = (finalPosition.GetX() - initialPosition.GetX()) / hipotenusaA;
            double senoA = (finalPosition.GetY() - initialPosition.GetY()) / hipotenusaA;
            double cosenoB = (b.GetFinalPosition().GetX() - b.GetInitialPosition().GetX()) / hipotenusaB;
            double senoB = (b.GetFinalPosition().GetY() - b.GetInitialPosition().GetY()) / hipotenusaB;

            tiempoMinimo = -((initialPosition.GetX() - b.GetInitialPosition().GetX()) * (velocidadA * cosenoA - velocidadB * cosenoB) + (initialPosition.GetY() - b.GetInitialPosition().GetY()) * (velocidadA * senoA - velocidadB * senoB)) / ((velocidadA * cosenoA - velocidadB * cosenoB) * (velocidadA * cosenoA - velocidadB * cosenoB) + (velocidadA * senoA - velocidadB * senoB) * (velocidadA * senoA - velocidadB * senoB));

            double posAX = initialPosition.GetX() + velocidadA * cosenoA * tiempoMinimo;
            double posAY = initialPosition.GetY() + velocidadA * senoA * tiempoMinimo;
            double posBX = b.GetInitialPosition().GetX() + velocidadB * cosenoB * tiempoMinimo;
            double posBY = b.GetInitialPosition().GetY() + velocidadB * senoB * tiempoMinimo;

            distanciaMinima = Math.Sqrt((posAX - posBX) * (posAX - posBX) + (posAY - posBY) * (posAY - posBY));

            return distanciaMinima;

        }

        public bool HabraConflicto(FlightPlan b, int distSeguridad)
        {
            if (this.DistanciaMinima(b) <= distSeguridad)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool SugerirVelocidadParaEvitarColision(FlightPlan b, double distanciaSeguridad, out double vSugerida)
        {
            double vOriginal = this.velocidad;
            double vPrueba = this.velocidad * 0.9;
            vSugerida = -1;

            while (vPrueba > 10)
            {
                this.velocidad = vPrueba;
                if (this.DistanciaMinima(b) > distanciaSeguridad)
                {
                    vSugerida = vPrueba;
                    this.velocidad = vOriginal;
                    return true;
                }
                vPrueba *= 0.95;
            }
            this.velocidad = vOriginal;
            return false;
        }

        // TWC 

        public bool areaSegura(FlightPlan b, double distanciaSeguridad)
        {

            Position posicionSegura1 = new Position(70, 70);
            Position posicionSegura2 = new Position(120, 120);
            Position posicionSegura3 = new Position(70, 120);
            Position posicionSegura4 = new Position(120, 70);

            if (distanciaSeguridad < posicionSegura1.GetX() && distanciaSeguridad < posicionSegura1.GetY() && distanciaSeguridad < posicionSegura2.GetX() && distanciaSeguridad < posicionSegura2.GetY() && distanciaSeguridad < posicionSegura3.GetX() && distanciaSeguridad < posicionSegura3.GetY() && distanciaSeguridad < posicionSegura4.GetX() && distanciaSeguridad < posicionSegura4.GetY())

            {
                return true;

            }
              
            else
            {
                return false;
            }
        }

        //Leer fichero
        public static List<FlightPlan> LeerFlightPlanFichero(string NombreFichero)
        {
            StreamReader R = new StreamReader(NombreFichero);
            List<FlightPlan> FlightPlans = new List<FlightPlan>();

            string linea = R.ReadLine();
            int i = 0;
            while (linea != null)
            {
                string[] trozos =linea.Split(' ');
                FlightPlan f = new FlightPlan(trozos[0], trozos[1], Convert.ToDouble(trozos[2]), Convert.ToDouble(trozos[3]), Convert.ToDouble(trozos[4]), Convert.ToDouble(trozos[5]), Convert.ToDouble(trozos[6]));
                FlightPlans.Add(f);
                linea = R.ReadLine();
                i++;
            }
            R.Close();
            return FlightPlans;
        }

        //Escribir fichero
        static void EscribirFlightPlanFichero(List<FlightPlan> lista, string nombreFichero)
        {
            StreamWriter W = new StreamWriter(nombreFichero);
            int i = 0;
            while (i < lista.Count)
            {
                FlightPlan f = lista[i];
                W.WriteLine("{0} {1} {2} {3} {4} {5} {6}", f.id, f.company, f.initialx, f.initialy, f.finalx, f.finaly, f.velocidad);
                i++;
            }
            W.Close();

        }
    }
}
