using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TransportModole
{
    class VC4
    {
        string messageVC4;

        public void CreateMessageVC4(C4 c4)
        {
            messageVC4 = "POH:[" + POH.poh + "], c-4:[" + c4.GetMessage() + "]";
        }
        public string GetMessageVC4()
        {
            return messageVC4;
        }
    }
}