using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab18
{
    public class AgentOperator
    {
        double Mu;
        int BusyOperators;
        int NumberOfOperators;
        Random rnd = new Random();

        public AgentOperator(double m,int noo)
        {
            Mu = m;
            NumberOfOperators = noo;
        }

        public int BusyOperators1 { get => BusyOperators; set => BusyOperators = value; }
        public int NumberOfOperators1 { get => NumberOfOperators;}

        public double GetNextEvent()
        {
            if(BusyOperators>0)
            {
                double A = rnd.NextDouble();
                double temp = A * BusyOperators;
                return (-Math.Log(temp) / Mu);
            }
            else { return Double.PositiveInfinity; }
        }

        public void ProcessEvent(AgentQueuePerson aqp)
        {
            if(aqp.NumberOfPerson1 == 0)
            {
                BusyOperators--;
            }
            else
            {
                aqp.NumberOfPerson1--;
            }
        }
    }
}
