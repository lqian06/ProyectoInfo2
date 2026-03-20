using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlightLib
{
    public class FlightPlanList
    {
        FlightPlan[] vector = new FlightPlan[100];
        int number = 0;

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

    }
}
