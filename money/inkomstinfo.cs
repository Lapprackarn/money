using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace money
{
    class inkomstinfo
    {
        public string Namn;
        public int Inkomst;
        public int Timmar;
        public string ShowInkomstInfo()
        {
            return Namn + " med inkomst: " + Inkomst;
        }
        public string GetNamn()
        {
            return namn;
        }
        
    }
}
