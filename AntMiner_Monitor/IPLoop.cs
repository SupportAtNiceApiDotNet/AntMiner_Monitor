using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Net.Sockets;
using System.Net;


namespace AntMiner_Monitor
{
    class IPLoop
    {
        public static void Loop(string start, string end, int delay)
        {
            IPAddress ipStart = IPAddress.Parse(start);
            IPAddress ipEnd = IPAddress.Parse(end);

            OutputManager.Ini();

            while (true)
            {
                DateTime dtStart = DateTime.Now;

                IPAddress ipWalk = ipStart;
                while (ipWalk.ToString() != ipEnd.ToString())
                {
                    OutputManager.Info(ipWalk.ToString());
                    try
                    {
                        string ResContactS9 = Communication.ContactS9(ipWalk, "{\"command\": \"version+summary+stats+pools\"}");
                        OutputData ResJsonParser = JsonParser.Parse(ResContactS9);
                        OutputManager.Display(ipWalk.GetAddressBytes()[3], ResJsonParser);
                    }
                    catch (SystemException)
                    {

                    }
                    ipWalk = Next(ipWalk);
//                    S9Id++;
                }

                DateTime dtEnd = DateTime.Now;
                TimeSpan tsDif = dtEnd - dtStart;
                if (tsDif.TotalSeconds < delay)
                {
                    double wait = delay - tsDif.TotalSeconds;
                    wait *= 1000;
                    System.Threading.Thread.Sleep((int)wait);
                }
            }
        }

        static IPAddress Next(IPAddress inA)
        {
            byte[] aTemp = inA.GetAddressBytes();
            aTemp[3]++;
            IPAddress r = new IPAddress(aTemp);
            return r;
        }
    }
}
