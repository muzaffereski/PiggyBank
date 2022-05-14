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
    public partial class CrashedPiggy : Form

    {
        private static readonly double PiggyBankVolume = 50000;

        PiggyBankProperty PBV = new PiggyBankProperty { Dimention = PiggyBankVolume };
        PiggyBank pb = new PiggyBank();


        public string totalmmm { get; set; }


        public CrashedPiggy()
        {
            InitializeComponent();
        }

        private void btnFix_Click(object sender, EventArgs e)
        {
            FixedPiggy fp = new FixedPiggy();
            fp.Show();
            this.Hide();
        }

        private void CrashedPiggy_Load(object sender, EventArgs e)
        {
            lblTotalMoney.Text=totalmmm;
        }
        
    }
}
