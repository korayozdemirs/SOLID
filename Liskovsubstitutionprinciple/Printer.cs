using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Liskovsubstitutionprinciple
{
    public class Printer
    {
        readonly BasePrinter canonPrinter = new CanonPrinter();
        readonly BasePrinter hpPrinter = new HpPrinter();
        public void Scan(string value )
        {
            //canonPrinter.Scan(value);
            //hpPrinter.sc(value);
        }
    }
}
