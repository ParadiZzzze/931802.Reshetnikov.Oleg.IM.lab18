using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab18
{
    public class AgentQueuePerson
    {
        double Lambda;
        int NumberOfPerson;
        Random rnd = new Random();

        public AgentQueuePerson(double l)
        {
            Lambda = l;
            NumberOfPerson = 0;
        }

        public int NumberOfPerson1 { get => NumberOfPerson; set => NumberOfPerson = value; }

        public double GetNextEvent()
        {
            double A = rnd.NextDouble();
            return (-Math.Log(A) / Lambda);
        }

        public void ProcessEvent(AgentOperator ao)
        {
            if(ao.BusyOperators1<ao.NumberOfOperators1)
            {
                ao.BusyOperators1++;
            }
            else
            {
                NumberOfPerson++;
            }
        }
    }
}
