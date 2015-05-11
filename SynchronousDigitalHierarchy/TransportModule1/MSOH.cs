using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TransportModole
{
    class MSOH
    {
        private string Msoh;

        public void createMSOH(DataChannel DC)
        {
            Msoh = "P:[ "+ Protect.protect +"], DC:[" + DC.GetDataChannel() + "]";
        }

        public string GetMSOH()
        {
            return Msoh;
        }
    }
}
