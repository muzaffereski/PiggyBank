using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PiggyBank
{
    public  class Coin:Money
    {
        public static readonly double Pi = 3.14;
        public double Radius { get; set; }
        public double Height { get; set; }
        public override double MoneyVolume
        {
            get { return Radius * Pi*Pi*Height; }
        }

    }
}
