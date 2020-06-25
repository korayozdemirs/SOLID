using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Liskovsubstitutionprinciple
{
    public class HpPrinter : BasePrinter, IScaneble
    {
        public override void Print(string value)
        {
            //yazdırma işlemleri
        }

        public void scan(string value)
        {
            throw new NotImplementedException();
        }
    }
}
