using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AntMiner_Monitor
{
    class OutputManager
    {
        const ConsoleColor cNormal = ConsoleColor.White;
        const ConsoleColor cRecent = ConsoleColor.Gray;

        static Dictionary<byte, OutputDataWithSpinner> AllData = new Dictionary<byte, OutputDataWithSpinner>();
        static int sNextLine = 0;

        public static void Display(byte ip, OutputData data)
        {
            if (AllData.ContainsKey(ip))
            {
                // already there
                AllData[ip].Spinner.Increment();
                AllData[ip].Data = data;
            }
            else
            {
                // new
                OutputDataWithSpinner ds = new OutputDataWithSpinner();
                ds.Data = data;
                ds.Spinner = new Spinner();
                ds.LineDown = ++sNextLine;
                ds.Ip = ip;
                AllData.Add(ip, ds);
            }
            dispayAll();
        }

        private static void dispayAll()
        {
            foreach (KeyValuePair<byte, OutputDataWithSpinner> d1 in AllData)
            {
                // go down
                Console.SetCursorPosition(0, d1.Value.LineDown + 1);
                Console.ForegroundColor = cRecent;
                Console.WriteLine(getLine(d1.Value));
                System.Threading.Thread.Sleep(250);

                //System.Diagnostics.Debug.WriteLine(getIniLine());
                //System.Diagnostics.Debug.WriteLine(getLine(d1.Value));
            }

        }

        public static void Ini()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine();
            Console.WriteLine(getIniLine());
        }

        public static void Info(string info)
        {
            Console.SetCursorPosition(0, 0);
            Console.ForegroundColor = cNormal;
            Console.WriteLine(info.PadRight(39).Substring(0, 39));

        }

        private static string getIniLine()
        {
            //return "Id     Elapsd GH5S   GHAv   Fo Acc Rej HWE Uti fan1 fan2 ----- Temps -----";
            //return "L Id     fan1 fan2 ----- Temps ----- Elapsd GH5S   GHAv   Fo Acce Reje HWE Util";
            return "L  IP ____Id -Fans-- ------Temps------ Elapsd GH5S   GHAv   Fo Acce Reje HWErr";
        }

        private static string getLine(OutputDataWithSpinner dataWithSpinner)
        {
            OutputData data = dataWithSpinner.Data;
            StringBuilder sb = new StringBuilder();
            sb.Append(dataWithSpinner.Spinner.GetVal() + " ");
            addInt(sb, 3, dataWithSpinner.Ip);
            addStr(sb, 6, data.S9Id);

            addFan(sb, data.Fan1);
            addFan(sb, data.Fan2);
            addInt(sb, 2, data.Temp1);
            addInt(sb, 2, data.Temp2);
            addInt(sb, 2, data.Temp3);
            addInt(sb, 2, data.Temp4);
            addInt(sb, 2, data.Temp5);
            addInt(sb, 2, data.Temp6);

            addInt(sb, 6, data.Elapsed);
            addGH(sb, data.GH5S);
            addGH(sb, data.GHav);
            addInt(sb, 2, data.FoundBlocks);
//            addInt(sb, 2, data.Getworks);
            addInt(sb, 4, data.Accepted);
            addInt(sb, 4, data.Rejected);
            addInt(sb, 4, data.HardwareErrors);
//            addUti(sb, data.Utility);
//            addInt(sb, 4, data.Discarded);
            return sb.ToString();
        }

        private static void addUti(StringBuilder sb, Decimal valD)
        {
            string val = string.Format("{0:0.00}", valD).Trim() + " ";

            sb.Append(val);
        }

        private static void addFan(StringBuilder sb, int valFan)
        {
            float valF = (float)valFan / 1000;
            string val = string.Format("{0:0.0}", valF) + " ";

            sb.Append(val);
        }

        private static void addGH(StringBuilder sb, Decimal valD)
        {
            string val = string.Format("{0:0,000}", valD) + " ";

            sb.Append(val);
        }

        private static void addInt(StringBuilder sb, int size, int valI)
        {
            string val = string.Format("{0}", valI).PadLeft(size) + " ";

            sb.Append(val);
        }

        private static void addStr(StringBuilder sb, int size, string val)
        {
            val = val.PadRight(size).Substring(0, size) + " ";
            sb.Append(val);
        }

        private static void addSpinner(StringBuilder sb, ref int spinnerVal)
        {

        }

    }

    class OutputDataWithSpinner
    {
        public OutputData Data;
        public Spinner Spinner;
        public int LineDown;
        public byte Ip;
    }

    class Spinner
    {
        private int m;
        const string c = "-/|\\";
        public void Increment()
        {
            m++;
            if (m >= c.Length)
            {
                m = 0;
            }
        }
        public string GetVal()
        {
            string r = c.Substring(m, 1);
            return r;
        }
    }

    class OutputData
    {
        public string S9Id;
        public int Elapsed;
        public Decimal GH5S;
        public Decimal GHav;
        public int FoundBlocks;
        public int Getworks;
        public int Accepted;
        public int Rejected;
        public int HardwareErrors;
        public Decimal Utility;
        public int Discarded;
        public int Fan1;
        public int Fan2;
        public int Temp1;
        public int Temp2;
        public int Temp3;
        public int Temp4;
        public int Temp5;
        public int Temp6;

        public static OutputData Dummy()
        {
            OutputData r = new OutputData();
            r.S9Id = "Test";
            r.Elapsed = 13;
            r.GHav = r.GH5S = 13000;
            r.FoundBlocks = 13;
            r.Getworks = 13;
            r.Accepted = 1000;
            r.Rejected = 0;
            r.HardwareErrors = 0;
            r.Utility = 0.93M;
            r.Discarded = 0;
            r.Fan1 = r.Fan2 = 5000;
            r.Temp1 = r.Temp2 = r.Temp3 = r.Temp4 = r.Temp5 = r.Temp6 = 88;

            return r;
        }
    }
}
