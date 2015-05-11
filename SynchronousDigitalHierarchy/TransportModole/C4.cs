using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TransportModole
{
    class C4
    {
        string messageC4;
        static int MESSAGELENGTH = 261;

        public void CreateMessageC4(string newMessageC4)
        {
            messageC4 = newMessageC4;
            if (CheckIfMessageNoTooLong() == false)
            {
                //Console.WriteLine("dlugosc wiadomosci" + messageC4.Length);

                for (int i = messageC4.Length; i < MESSAGELENGTH; i++)
                {
                    messageC4 = messageC4 + "#";
                }
                //Console.WriteLine("dlugosc wiadomosci" + messageC4);
            }
            else
            {
                DeleteMessage();
                Console.Write("Too long message");
            }
        }

        public string GetMessage()
        {
            return messageC4;
        }

        public void DeleteMessage()
        {
            messageC4 = null;
        }

        private bool CheckIfMessageNoTooLong()
        {
            if (messageC4.Length > MESSAGELENGTH)
            {
                return true;
            }
            else
                return false;
        }
    }
}
