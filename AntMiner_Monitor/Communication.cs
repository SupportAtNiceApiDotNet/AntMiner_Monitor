using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Net.Sockets;
using System.Net;

namespace AntMiner_Monitor
{
    class Communication
    {
        public static string ContactS9(IPAddress s9Address, string jsonToSend)
        {
            string responseString = null;
            int readCount = 0;
            StringBuilder readSB = new StringBuilder();

            MemoryStream msIn = new MemoryStream();
            StringToStream(jsonToSend, msIn);
            msIn.Seek(0, SeekOrigin.Begin);

            using (var client = new TcpClient())
            {
                try
                {
                    DateTime dtStart = DateTime.Now;
                    var result = client.BeginConnect(s9Address, 4028, null, null);
                    var success = result.AsyncWaitHandle.WaitOne(TimeSpan.FromMilliseconds(400));
                    if (!success)
                    {
                        throw new Exception("Failed to connect.");
                    }
                    DateTime dtEnd = DateTime.Now;
                    TimeSpan spDif = dtEnd - dtStart;
                    //client.Connect(s9Address, 4028);
                    
                    Stream s = client.GetStream();
                    msIn.CopyTo(s);

                    MemoryStream ms = new MemoryStream();
                    s.CopyTo(ms);
                    ms.Seek(0, SeekOrigin.Begin);
                    ReadStream(ms, ref readCount, ref readSB);
                }
                catch (IOException ioe)
                {

                }
                catch (Exception)
                {
//                    Console.WriteLine("Ups");
                }
                responseString = readSB.ToString();

            }
            return responseString;
        }

        private static void StringToStream(String str, Stream stream)
        {
            foreach (char c1 in str)
            {
                byte b1 = (byte)c1;
                stream.WriteByte(b1);
            }
        }

        private static void ReadStream(Stream stream, ref int count, ref StringBuilder text)
        {
            count = 0;
            text.Clear();
            while (true)
            {
                int i = stream.ReadByte();
                if (i == -1)
                {
                    throw new IOException("EOS");
                }
                //Console.WriteLine(count.ToString() + ": " + i.ToString());
                text.Append((char)i);
                count++;
            }
        }

    }
}
