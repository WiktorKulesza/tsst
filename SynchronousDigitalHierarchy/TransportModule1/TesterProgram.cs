using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TransportModole
{
    class TesterProgram
    {
        static void Main(string[] args)
        {
            TestContainerSTM1();

        }

        private static void TestContainerSTM1()
        {
            AU4 au4 = TestContaunerAU4();

            MSOH msoh = TestMSOH();

            STM1 containerSTM1 = new STM1();

            containerSTM1.CreateSTM1(msoh, au4);

            Console.WriteLine(containerSTM1.GetSTM1());

            string message1 = containerSTM1.PrepareToSend();

            Console.WriteLine(message1);

            containerSTM1.GetSTM1fromSendedContainer(message1);

            Console.ReadKey();
        }

        private static MSOH TestMSOH()
        {
            DataChannel dc = new DataChannel();

            MSOH msoh = new MSOH();
            msoh.createMSOH(dc);

            Console.WriteLine(msoh.GetMSOH());
            Console.ReadKey();

            return msoh;
        }

        private static AU4 TestContaunerAU4()
        {
            VC4 containerVC4 = TestContainerVC4();

            AU4 containerAU4 = new AU4();
            containerAU4.createAU4(containerVC4);

            Console.WriteLine(containerAU4.GetAU4());

            Console.ReadKey();

            return containerAU4;
        }

        private static VC4 TestContainerVC4()
        {
            C4 containerC4;
            containerC4 = TestContainerC4();

            VC4 containerVC4 = new VC4();

            containerVC4.CreateMessageVC4(containerC4);

            Console.WriteLine(containerVC4.GetMessageVC4());

            Console.ReadKey();

            return containerVC4;
        }
        
        private static C4 TestContainerC4()
        {
            C4 containerC4 = new C4();
            string message;
            string message1;
            message = "raz dwa trzy, próba c4";

            containerC4.CreateMessageC4(message);

            message1 = containerC4.GetMessage();

            Console.WriteLine(message1);

           // container4.DeleteMessage();

            Console.WriteLine(containerC4.GetMessage());

            Console.ReadKey();

            return containerC4;
        }
    }
}