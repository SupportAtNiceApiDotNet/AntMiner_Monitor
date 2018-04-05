using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

namespace AntMiner_Monitor
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                string cnfS9StartIp = "10.41.234.100";
                string cnfS9EndIp = "10.41.234.120";
                string cndDelay = "5";

                cnfS9StartIp = ConfigurationManager.AppSettings["ScanStartIp"] == null ? cnfS9StartIp : ConfigurationManager.AppSettings["ScanStartIp"];
                cnfS9EndIp = ConfigurationManager.AppSettings["ScanEndIp"] == null ? cnfS9EndIp : ConfigurationManager.AppSettings["ScanEndIp"];
                cndDelay = ConfigurationManager.AppSettings["Delay"] == null ? cndDelay : ConfigurationManager.AppSettings["Delay"];

                Console.Title = String.Format("AntMiner Monitor, scanning for {0} to {1}", cnfS9StartIp, cnfS9EndIp);

                IPLoop.Loop(cnfS9StartIp, cnfS9EndIp, int.Parse(cndDelay));
            }
            catch (SystemException)
            {
                Console.Clear();
                Console.WriteLine("Fatal error");
                Console.ReadLine();
            }
        }
    }
}
