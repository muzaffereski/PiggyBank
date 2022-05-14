using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PiggyBank
{
    public partial class PiggyBank : Form
    {

        private static readonly double PiggyBankVolume = 50000;

        PiggyBankProperty PBV = new PiggyBankProperty { Dimention = PiggyBankVolume };

        public PiggyBank()
        {
            InitializeComponent();
        }

        


        public static List<Coin> CoinMoney = new List<Coin>()

        {
            new Coin{MoneyName=MoneyName.OneCent,Value=0.01m,Radius=16.5/2, Height=1.35 },
            new Coin{MoneyName=MoneyName.FiveCent,Value=0.05m,Radius=17.5/2, Height=1.65 },
            new Coin{MoneyName=MoneyName.TenCent,Value=0.1m,Radius=18.5/2, Height=1.65 },
            new Coin{MoneyName=MoneyName.TwentyFiveCent,Value=0.25m,Radius=20.5/2, Height=1.65 },
            new Coin{MoneyName=MoneyName.FiftyCent,Value=0.5m,Radius=23.85/2, Height=1.9 },
            new Coin{MoneyName=MoneyName.OneDollar,Value=1,Radius=26.15/2, Height=1.9 },
        };

        public static List<Banknote> BanknoteMoney = new List<Banknote>()
        {
            new Banknote {MoneyName=MoneyName.FiveDollar,Value=5,Width=130, Height=64},
            new Banknote {MoneyName=MoneyName.TenDollar,Value=10,Width=136, Height=64},
            new Banknote {MoneyName=MoneyName.TwentyDollar,Value=20,Width=142, Height=68},
            new Banknote {MoneyName=MoneyName.FiftyDollar,Value=50,Width=148, Height=68},
            new Banknote {MoneyName=MoneyName.OneHundredDollar,Value=100,Width=154, Height=72},
            new Banknote {MoneyName=MoneyName.FiveHundredDollar,Value=500,Width=160, Height=72},
        };

        private void PiggyBank_Load(object sender, EventArgs e)
        {
            foreach (Coin item in CoinMoney)
            {
                guna2ComboBox2.Items.Add(item);
            }

            foreach (Banknote item in BanknoteMoney)
            {
                guna2ComboBox1.Items.Add(item);
            }

            

            Updated();
            this.FormBorderStyle = FormBorderStyle.FixedToolWindow;
        }

        private static void ShakeMetot(PiggyBank form)
        {
            var original = form.Location;
            var rnd = new Random(1337);
            const int shake_amplitude = 8;
            for (int i = 0; i < 10; i++)
            {
                form.Location = new Point(original.X + rnd.Next(-shake_amplitude, shake_amplitude), original.Y + rnd.Next(-shake_amplitude, shake_amplitude));
                System.Threading.Thread.Sleep(20);
                form.Location = original;
            }
        }
       


        
        private void Updated()
        {
            label2.Text ="Total Volume:    "+ string.Format("{0:0}", PBV.MoneysTotalVolume()) + "  mm3";
            label3.Text = "total Money:" + string.Format("{0:F2}", PBV.MoneysTotal());

        }

        private void btnCoin_Click(object sender, EventArgs e)
        {
            Money AddedCoin = (Coin)guna2ComboBox2.SelectedItem;

            if (AddedCoin != null)
            {
                try
                {
                    
                    PBV.MoneyAdd(AddedCoin);
                    
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            Updated();
            


        }

        private void btnBanknote_Click(object sender, EventArgs e)
        {

            Money AddedBanknote = (Banknote)guna2ComboBox1.SelectedItem;

            if (AddedBanknote != null)
            {
                try
                {
                    PBV.MoneyAdd(AddedBanknote);

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            Updated();
         

        }

        

        private void btnShake_Click(object sender, EventArgs e)
        {
            SoundPlayer splayer = new SoundPlayer(@"C:\Users\lenovo\source\repos\PiggyBank\PiggyBank\Sounds\mixkit-clinking-coins-1993.wav");
            splayer.Play();
            ShakeMetot(this);
            PBV.Shaked();
            Updated();
            

        }
        private void btnCrash_Click(object sender, EventArgs e)
        {
            SoundPlayer spCrash = new SoundPlayer(@"C:\Users\lenovo\source\repos\PiggyBank\PiggyBank\Sounds\mixkit-metal-bar-movement-hits-3138.wav");
            spCrash.Play();
            
            CrashedPiggy cp = new CrashedPiggy();
            cp.totalmmm = label3.Text;
            
            cp.Show();
            this.Hide();
            Updated();
        }
       

    }
}
