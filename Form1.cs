using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab18
{
    
    public partial class Form1 : Form
    {
        Model md = new Model();
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            md.InitialData((double)edLambda.Value, (double)edMu.Value, (int)edNumber.Value, (double)edT.Value,(int)edOperators.Value);
            Dictionary<int, double> Freq = md.DistributionAndEmpEmpiricalProbability(md.InitialAO(),md.InitialAQP());
            Dictionary<int, double> Stat = md.Statistics();

            foreach(int i in Freq.Keys)
            {
                chart1.Series[0].Points.AddXY(i, Freq[i]);
            }
            foreach(int i in Stat.Keys)
            {
                chart2.Series[0].Points.AddXY(i, Stat[i]);
            }
        }
    }
}
