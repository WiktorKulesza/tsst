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

        private void createAU4(VC4 vc4)
        {
            aU4 = Protect.protectAU4 + vc4.GetMessageVC4();
        }
    }
}
