using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PiggyBank
{
    public partial class Splash : Form
    {
        public Splash()
        {
            InitializeComponent();
        }
        int circlePercentage = 0;
        private void guna2CircleProgressBar1_ValueChanged(object sender, EventArgs e)
        {
         

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            circlePercentage += 1;
            guna2CircleProgressBar1.Value = circlePercentage;
            if (guna2CircleProgressBar1.Value==100)
            {
                timer1.Stop();
                circlePercentage = 0;
                PiggyBank pg = new PiggyBank();
                pg.Show();
                this.Hide();
            }

        }

        private void Splash_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }
    }
}
