using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlightLib
{
    public class FlightPlan
    {
        // Atributos

        string id; // identificador
        Position initialPosition;
        Position currentPosition; // posicion actual
        Position finalPosition; // posicion final
        double velocidad;

        // Constructures
        public FlightPlan(string id, double cpx, double cpy, double fpx, double fpy, double velocidad)
        {
            this.id = id;
            this.initialPosition = new Position(cpx, cpy);
            this.currentPosition = new Position(cpx, cpy);
            this.finalPosition = new Position(fpx, fpy);
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


    }
}
