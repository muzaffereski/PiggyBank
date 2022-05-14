using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PiggyBank
{
    public class Banknote:Money
    {
        private static readonly double Thickness = 0.25;
        public double Height { get; set; }
        public double Width { get; set; }
        public override double MoneyVolume
        {
            get { return Height*(Width/4)*Thickness*4; }
        }
    }
}
