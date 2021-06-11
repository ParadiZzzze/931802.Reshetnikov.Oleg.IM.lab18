using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab18
{
    public class Model
    {
        double NextPerson, NextOperator;
        double Time = 0;
        double T;
        int k;
        int N;
        double Lambda;
        double Mu;
        double Rho;
        int NumberOfOperators;
        double ISD;
        Dictionary<int,double> Freq = new Dictionary<int, double>();
        Dictionary<int, double> Stat;

        public void InitialData(double l,double m,int n,double t,int noo)
        {
            Lambda = l;
            Mu = m;
            Rho = l / m;
            N = n;
            T = t;
            k = 0;
            NumberOfOperators = noo;
            ISD = InitialStationaryDistribution(noo);
            
            
        }
        public AgentQueuePerson InitialAQP()
        {
            AgentQueuePerson AQP = new AgentQueuePerson(Lambda);
            return AQP;
        }
        public AgentOperator InitialAO()
        {
            AgentOperator AO = new AgentOperator(Mu, NumberOfOperators);
            return AO;
        }

        public Dictionary<int,double> Statistics()
        {
            Stat = Freq;
            foreach(int i in Stat.Keys.ToList())
            {
                if (i < NumberOfOperators)
                {
                    Stat[i] = (Math.Pow(Rho, i) / Factorial(i)) * ISD;
                }
                else
                {
                    Stat[i] = (Math.Pow(Rho, i) / (Factorial(i) * Math.Pow(NumberOfOperators, i - NumberOfOperators))) * ISD;
                }
            }
            return Stat;
        }

        public Dictionary<int,double> DistributionAndEmpEmpiricalProbability(AgentOperator ao,AgentQueuePerson aqp)
        {
            while(k<N)
            {
                while(Time<T)
                {
                    NextOperator = ao.GetNextEvent();
                    NextPerson = aqp.GetNextEvent();
                    if(NextPerson<NextOperator)
                    {
                        aqp.ProcessEvent(ao);
                        Time += NextPerson;
                    }
                    else
                    {
                        ao.ProcessEvent(aqp);
                        Time += NextOperator;
                    }
                }
                k++;
                Time = 0;
                try
                {
                    Freq.Add(ao.BusyOperators1 + aqp.NumberOfPerson1, 0);
                }
                catch
                {
                    Console.WriteLine("Элемент уже существует");
                }
                finally
                {
                    Console.WriteLine("Исключение обработано");
                }
                Freq[ao.BusyOperators1 + aqp.NumberOfPerson1]++;
               
            }
            foreach(int i in Freq.Keys.ToList())
            {
                Freq[i] /= N;
            }
            return Freq;
        }


        private double InitialStationaryDistribution(int noo)
        {
            double temp=0;
            for(int i=0;i<noo;i++)
            {
                temp += Math.Pow(Rho, i)/Factorial(i);
            }
            double temp1 = Math.Pow(Rho, (noo + 1)) / Factorial(noo) * (noo - Rho);
            double isd = Math.Pow((temp + temp1), -1);
            return isd;
        }
        private int Factorial(int i)
        {
            int temp = 1;
            for(int j=1;j<=i;j++)
            {
                temp *= j;
            }
            return temp;
        }
    }
}
