using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using TsstSdh.SocketUtils;

namespace TsstSdh
{
    class Program
    {
        public static void Main(String[] args)
        {
            CloudSetupProcess setupProcess = new CloudSetupProcess("linkConfig.xml");
            setupProcess.startCloudProcess();
            Console.ReadLine();
        }
    }
}
