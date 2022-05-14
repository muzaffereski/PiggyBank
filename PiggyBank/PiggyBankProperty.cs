using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PiggyBank
{
    public class PiggyBankProperty
    {
        public List<Money> Moneys { get; set; }= new List<Money>();
        public double Dimention { get; set; }

        
        public double ShakedVolume()
        {
            Random random = new Random();
            return (random.NextDouble() * (500) + 125) / 100;
        }
        public double MoneysTotalVolume()
        {
            double Result = 0;
            foreach (Money money in Moneys)
            {
                Result += money.MoneyVolume;
            }
            return Result;
        }
        public decimal  MoneysTotal()
        {
            decimal Result = 0;
            foreach (Money money in Moneys)
            {
                Result += money.Value;
            }
            return Result;
        }
        public void Shaked()
        {
            foreach (Money money in Moneys)
            {
                money.ExtraVolumeRate = 1.25;
            }
        }

        

        public void MoneyAdd(Money money)
        {
            if (Dimention>(MoneysTotalVolume()+ money.LastVolume))
            {
                money.ExtraVolumeRate= ShakedVolume();
                Moneys.Add(money);
                
                
            }
            else
            {
                throw new Exception("its full!");
            }
        }
        public string Crash()
        {
            string Result = string.Empty;
            decimal totalMoney=0; 
   
            foreach (Money  money in Moneys)
            {
                totalMoney += money.Value;                
            }
            
            Result += "Total: " + totalMoney + " Dollar";

            Moneys.Clear();

            return Result;
        }
        

    }
    
}
