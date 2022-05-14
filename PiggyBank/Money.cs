using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PiggyBank
{
    public class Money
    {
        public MoneyName MoneyName { get; set; }

        public decimal Value { get; set; }
        public Decimal MoneyDimention { get; set; }
        public double ExtraVolumeRate { get; set; }
        public double LastVolume
        { 
            get 
            { 
                    return MoneyVolume * ExtraVolumeRate; 
            }
        }
        public virtual double MoneyVolume
        {
            get
            {
                return 0;
            }
        }
        public override string ToString()
        {
            return MoneyName + " ";
        }



    }
}
