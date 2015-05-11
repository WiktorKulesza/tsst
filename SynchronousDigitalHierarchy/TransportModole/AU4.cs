using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TransportModole
{
    class AU4
    {
        string aU4;

        public void createAU4(VC4 vc4)
        {
            aU4 = "P:["+Protect.protect + "], VC-4[" +  vc4.GetMessageVC4() + "]";
        }

        public string GetAU4()
        {
            return aU4;
        }
    }
}
