using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TransportModole
{
    class STM1
    {
        private string stm1;
        private string stm1ToSend;
        public void CreateSTM1(MSOH msoh, AU4 au4)
        {
            stm1 = "MSOH:[" + msoh.GetMSOH() + "], RSOH:[" + RSOH.Rsoh + "], AU-4:[" + au4.GetAU4() + "]";
        }

        public string PrepareToSend()
        {
            return stm1ToSend = "STM-1:[" + stm1 + "]";
            
        }

        public string GetSTM1()
        {
            return stm1;
        }

        public string GetSTM1fromSendedContainer( string message)
        {
            string readedMessage;
            string[] messageTable;
            string[] messageSplit  = new string[2];

            messageSplit[0] = "STM-1:[";
            messageSplit[1] = "]]]]";

            messageTable = message.Split(messageSplit, StringSplitOptions.None);


            return readedMessage = messageSplit[0];
            
        }
    }
}