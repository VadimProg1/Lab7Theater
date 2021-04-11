using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Theater7lab
{
    public partial class Form1 : Form
    {
        Theater theater = new Theater();

        private void start_button_Click(object sender, EventArgs e)
        {
            chart1.Series[0].Points.Clear();

            theater.actorsPopularity = Convert.ToInt32(numeric_actorsPopularity.Value);
            theater.theaterFinancingPerMonth = Convert.ToInt32(numeric_financingPerMonth.Value);
            theater.partOfActorsWhoWorksForMinSalary = Convert.ToInt32(numeric_partActorsMinSalary.Value);

            numeric_actorsPopularity.Enabled = false;
            numeric_financingPerMonth.Enabled = false;
            numeric_partActorsMinSalary.Enabled = false;
            start_button.Enabled = false;
            timer1.Interval = 2000;
            timer1.Start();
        }

        private void stop_button_Click(object sender, EventArgs e)
        {
            if (timer1.Enabled)
            {
                timer1.Stop();
                theater.Reset();
                chart1.Series[0].Points.Clear();
                numeric_actorsPopularity.Enabled = true;
                numeric_financingPerMonth.Enabled = true;
                numeric_partActorsMinSalary.Enabled = true;
                start_button.Enabled = true;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (timer1.Enabled)
            {
                theater.MonthStep();
                chart1.Series[0].Points.AddXY(theater.month, theater.amountOfPlays);
            }
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
