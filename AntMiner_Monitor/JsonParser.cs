using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.XPath;
using System.Xml;
using System.Xml.Linq;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Json;


namespace AntMiner_Monitor
{
    /*
.version.STATUS.STATUS -> S
.version.STATUS.When -> 41695
.version.STATUS.Code -> 22
.version.STATUS.Msg -> BMMiner versions
.version.STATUS.Description -> bmminer 1.0.0
.version.VERSION.BMMiner -> 2.0.0
.version.VERSION.API -> 3.1
.version.VERSION.Miner -> 16.8.1.3
.version.VERSION.CompileTime -> Fri Nov 17 17:37:49 CST 2017
.version.VERSION.Type -> Antminer S9
.version.id -> 1
.summary.STATUS.STATUS -> S
.summary.STATUS.When -> 41695
.summary.STATUS.Code -> 11
.summary.STATUS.Msg -> Summary
.summary.STATUS.Description -> bmminer 1.0.0
.summary.SUMMARY.Elapsed -> 8505
.summary.SUMMARY.GHS5s -> 13742.84
.summary.SUMMARY.GHSav -> 13433.46
.summary.SUMMARY.FoundBlocks -> 0
.summary.SUMMARY.Getworks -> 272
.summary.SUMMARY.Accepted -> 1555
.summary.SUMMARY.Rejected -> 22
.summary.SUMMARY.HardwareErrors -> 180
.summary.SUMMARY.Utility -> 10.97
.summary.SUMMARY.Discarded -> 4388
.summary.SUMMARY.Stale -> 44
.summary.SUMMARY.GetFailures -> 2
.summary.SUMMARY.LocalWork -> 421410
.summary.SUMMARY.RemoteFailures -> 2
.summary.SUMMARY.NetworkBlocks -> 9
.summary.SUMMARY.TotalMH -> 114238136950.0000
.summary.SUMMARY.WorkUtility -> 182275.61
.summary.SUMMARY.DifficultyAccepted -> 25477120.00000000
.summary.SUMMARY.DifficultyRejected -> 360448.00000000
.summary.SUMMARY.DifficultyStale -> 0.00000000
.summary.SUMMARY.BestShare -> 98877137
.summary.SUMMARY.DeviceHardware% -> 0.0007
.summary.SUMMARY.DeviceRejected% -> 1.3951
.summary.SUMMARY.PoolRejected% -> 1.3951
.summary.SUMMARY.PoolStale% -> 0.0000
.summary.SUMMARY.Lastgetwork -> 41695
.summary.id -> 1
.stats.STATUS.STATUS -> S
.stats.STATUS.When -> 41695
.stats.STATUS.Code -> 70
.stats.STATUS.Msg -> BMMiner stats
.stats.STATUS.Description -> bmminer 1.0.0
.stats.STATS.BMMiner -> 2.0.0
.stats.STATS.Miner -> 16.8.1.3
.stats.STATS.CompileTime -> Fri Nov 17 17:37:49 CST 2017
.stats.STATS.Type -> Antminer S9
.stats.STATS.STATS -> 0
.stats.STATS.ID -> BC50
.stats.STATS.Elapsed -> 8505
.stats.STATS.Calls -> 0
.stats.STATS.Wait -> 0.000000
.stats.STATS.Max -> 0.000000
.stats.STATS.Min -> 99999999.000000
.stats.STATS.GHS5s -> 13732.37
.stats.STATS.GHSav -> 13433.46
.stats.STATS.miner_count -> 3
.stats.STATS.frequency -> 675
.stats.STATS.fan_num -> 2
.stats.STATS.fan1 -> 0
.stats.STATS.fan2 -> 0
.stats.STATS.fan3 -> 5880
.stats.STATS.fan4 -> 0
.stats.STATS.fan5 -> 0
.stats.STATS.fan6 -> 4200
.stats.STATS.fan7 -> 0
.stats.STATS.fan8 -> 0
.stats.STATS.temp_num -> 3
.stats.STATS.temp1 -> 0
.stats.STATS.temp2 -> 0
.stats.STATS.temp3 -> 0
.stats.STATS.temp4 -> 0
.stats.STATS.temp5 -> 0
.stats.STATS.temp6 -> 73
.stats.STATS.temp7 -> 67
.stats.STATS.temp8 -> 72
.stats.STATS.temp9 -> 0
.stats.STATS.temp10 -> 0
.stats.STATS.temp11 -> 0
.stats.STATS.temp12 -> 0
.stats.STATS.temp13 -> 0
.stats.STATS.temp14 -> 0
.stats.STATS.temp15 -> 0
.stats.STATS.temp16 -> 0
.stats.STATS.temp2_1 -> 0
.stats.STATS.temp2_2 -> 0
.stats.STATS.temp2_3 -> 0
.stats.STATS.temp2_4 -> 0
.stats.STATS.temp2_5 -> 0
.stats.STATS.temp2_6 -> 88
.stats.STATS.temp2_7 -> 82
.stats.STATS.temp2_8 -> 87
.stats.STATS.temp2_9 -> 0
.stats.STATS.temp2_10 -> 0
.stats.STATS.temp2_11 -> 0
.stats.STATS.temp2_12 -> 0
.stats.STATS.temp2_13 -> 0
.stats.STATS.temp2_14 -> 0
.stats.STATS.temp2_15 -> 0
.stats.STATS.temp2_16 -> 0
.stats.STATS.temp3_1 -> 0
.stats.STATS.temp3_2 -> 0
.stats.STATS.temp3_3 -> 0
.stats.STATS.temp3_4 -> 0
.stats.STATS.temp3_5 -> 0
.stats.STATS.temp3_6 -> 0
.stats.STATS.temp3_7 -> 0
.stats.STATS.temp3_8 -> 0
.stats.STATS.temp3_9 -> 0
.stats.STATS.temp3_10 -> 0
.stats.STATS.temp3_11 -> 0
.stats.STATS.temp3_12 -> 0
.stats.STATS.temp3_13 -> 0
.stats.STATS.temp3_14 -> 0
.stats.STATS.temp3_15 -> 0
.stats.STATS.temp3_16 -> 0
.stats.STATS.freq_avg1 -> 0.00
.stats.STATS.freq_avg2 -> 0.00
.stats.STATS.freq_avg3 -> 0.00
.stats.STATS.freq_avg4 -> 0.00
.stats.STATS.freq_avg5 -> 0.00
.stats.STATS.freq_avg6 -> 643.55
.stats.STATS.freq_avg7 -> 606.00
.stats.STATS.freq_avg8 -> 651.11
.stats.STATS.freq_avg9 -> 0.00
.stats.STATS.freq_avg10 -> 0.00
.stats.STATS.freq_avg11 -> 0.00
.stats.STATS.freq_avg12 -> 0.00
.stats.STATS.freq_avg13 -> 0.00
.stats.STATS.freq_avg14 -> 0.00
.stats.STATS.freq_avg15 -> 0.00
.stats.STATS.freq_avg16 -> 0.00
.stats.STATS.total_rateideal -> 13501.21
.stats.STATS.total_freqavg -> 633.55
.stats.STATS.total_acn -> 189
.stats.STATS.total_rate -> 13732.37
.stats.STATS.chain_rateideal1 -> 0.00
.stats.STATS.chain_rateideal2 -> 0.00
.stats.STATS.chain_rateideal3 -> 0.00
.stats.STATS.chain_rateideal4 -> 0.00
.stats.STATS.chain_rateideal5 -> 0.00
.stats.STATS.chain_rateideal6 -> 4574.38
.stats.STATS.chain_rateideal7 -> 4352.29
.stats.STATS.chain_rateideal8 -> 4574.53
.stats.STATS.chain_rateideal9 -> 0.00
.stats.STATS.chain_rateideal10 -> 0.00
.stats.STATS.chain_rateideal11 -> 0.00
.stats.STATS.chain_rateideal12 -> 0.00
.stats.STATS.chain_rateideal13 -> 0.00
.stats.STATS.chain_rateideal14 -> 0.00
.stats.STATS.chain_rateideal15 -> 0.00
.stats.STATS.chain_rateideal16 -> 0.00
.stats.STATS.temp_max -> 73
.stats.STATS.DeviceHardware% -> 0.0007
.stats.STATS.no_matching_work -> 180
.stats.STATS.chain_acn1 -> 0
.stats.STATS.chain_acn2 -> 0
.stats.STATS.chain_acn3 -> 0
.stats.STATS.chain_acn4 -> 0
.stats.STATS.chain_acn5 -> 0
.stats.STATS.chain_acn6 -> 63
.stats.STATS.chain_acn7 -> 63
.stats.STATS.chain_acn8 -> 63
.stats.STATS.chain_acn9 -> 0
.stats.STATS.chain_acn10 -> 0
.stats.STATS.chain_acn11 -> 0
.stats.STATS.chain_acn12 -> 0
.stats.STATS.chain_acn13 -> 0
.stats.STATS.chain_acn14 -> 0
.stats.STATS.chain_acn15 -> 0
.stats.STATS.chain_acn16 -> 0
.stats.STATS.chain_acs6 ->  oooooooo oooooooo oooooooo oooooooo oooooooo oooooooo oooooooo ooooooo
.stats.STATS.chain_acs7 ->  oooooooo oooooooo oooooooo oooooooo oooooooo oooooooo oooooooo ooooooo
.stats.STATS.chain_acs8 ->  oooooooo oooooooo oooooooo oooooooo oooooooo oooooooo oooooooo ooooooo
.stats.STATS.chain_hw1 -> 0
.stats.STATS.chain_hw2 -> 0
.stats.STATS.chain_hw3 -> 0
.stats.STATS.chain_hw4 -> 0
.stats.STATS.chain_hw5 -> 0
.stats.STATS.chain_hw6 -> 179
.stats.STATS.chain_hw7 -> 0
.stats.STATS.chain_hw8 -> 1
.stats.STATS.chain_hw9 -> 0
.stats.STATS.chain_hw10 -> 0
.stats.STATS.chain_hw11 -> 0
.stats.STATS.chain_hw12 -> 0
.stats.STATS.chain_hw13 -> 0
.stats.STATS.chain_hw14 -> 0
.stats.STATS.chain_hw15 -> 0
.stats.STATS.chain_hw16 -> 0
.stats.STATS.chain_rate6 -> 4698.01
.stats.STATS.chain_rate7 -> 4320.38
.stats.STATS.chain_rate8 -> 4713.98
.stats.STATS.chain_offside_6 -> 0
.stats.STATS.chain_offside_7 -> 0
.stats.STATS.chain_offside_8 -> 0
.stats.STATS.chain_opencore_6 -> 1
.stats.STATS.chain_opencore_7 -> 1
.stats.STATS.chain_opencore_8 -> 1
.stats.STATS.miner_version -> 16.8.1.3
.stats.id -> 1
.pools.STATUS.STATUS -> S
.pools.STATUS.When -> 41695
.pools.STATUS.Code -> 7
.pools.STATUS.Msg -> 3 Pool(s)
.pools.STATUS.Description -> bmminer 1.0.0
.pools.POOLS.POOL -> 0
.pools.POOLS.Status -> Alive
.pools.POOLS.Priority -> 0
.pools.POOLS.Quota -> 1
.pools.POOLS.LongPoll -> N
.pools.POOLS.Getworks -> 272
.pools.POOLS.Accepted -> 1555
.pools.POOLS.Rejected -> 22
.pools.POOLS.Discarded -> 4388
.pools.POOLS.Stale -> 44
.pools.POOLS.GetFailures -> 2
.pools.POOLS.RemoteFailures -> 2
.pools.POOLS.User -> HotBox.001
.pools.POOLS.LastShareTime -> 0:00:00
.pools.POOLS.Diff -> 16.4K
.pools.POOLS.Diff1Shares -> 0
.pools.POOLS.DifficultyAccepted -> 25477120.00000000
.pools.POOLS.DifficultyRejected -> 360448.00000000
.pools.POOLS.DifficultyStale -> 0.00000000
.pools.POOLS.LastShareDifficulty -> 16384.00000000
.pools.POOLS.HasStratum -> true
.pools.POOLS.StratumActive -> true
.pools.POOLS.HasGBT -> false
.pools.POOLS.BestShare -> 98877137
.pools.POOLS.PoolRejected% -> 1.3951
.pools.POOLS.PoolStale% -> 0.0000
.pools.id -> 1
.id -> 1
     * 
     */
    class JsonParser
    {
        public static OutputData Parse(string json)
        {
            Dictionary<String, String> dic = Go(json);
            OutputData res = new OutputData();
            //foreach (KeyValuePair<string, string> o1 in dic)
            //{
            //    System.Diagnostics.Debug.WriteLine(o1.Key + " -> " + o1.Value);
            //}
            res.S9Id = GetLastDot(dic, ".pools.POOLS.User");
            res.Elapsed = GetInt(dic, ".summary.SUMMARY.Elapsed");
            res.GH5S = GetDecimal(dic, ".summary.SUMMARY.GHS5s");
            res.GHav = GetDecimal(dic, ".summary.SUMMARY.GHSav");
            res.FoundBlocks = GetInt(dic, ".summary.SUMMARY.FoundBlocks");
            res.Getworks = GetInt(dic, ".summary.SUMMARY.Getworks");
            res.Accepted = GetInt(dic, ".summary.SUMMARY.Accepted");
            res.Rejected = GetInt(dic, ".summary.SUMMARY.Rejected");
            res.HardwareErrors = GetInt(dic, ".summary.SUMMARY.HardwareErrors");
            res.Utility = GetDecimal(dic, ".summary.SUMMARY.Utility");
            res.Discarded = GetInt(dic, ".summary.SUMMARY.Discarded");
            res.Fan1 = GetInt(dic, ".stats.STATS.fan3");
            res.Fan2 = GetInt(dic, ".stats.STATS.fan6");
            res.Temp1 = GetInt(dic, ".stats.STATS.temp6");
            res.Temp2 = GetInt(dic, ".stats.STATS.temp7");
            res.Temp3 = GetInt(dic, ".stats.STATS.temp8");
            res.Temp4 = GetInt(dic, ".stats.STATS.temp2_6");
            res.Temp5 = GetInt(dic, ".stats.STATS.temp2_7");
            res.Temp6 = GetInt(dic, ".stats.STATS.temp2_8");


            return res;
        }

        private static string GetLastDot(Dictionary<String, String> dic, string key)
        {
            try
            {
                string val = dic[key];
                int pos = val.LastIndexOf('.');
                string r = val.Substring(pos + 1);
                return r;
            }
            catch (SystemException)
            {

            }
            return "???";
        }

        private static int GetInt(Dictionary<String, String> dic, string key)
        {
            try
            {
                return int.Parse(dic[key]);
            }
            catch (SystemException)
            {

            }
            return 0;
        }
        private static Decimal GetDecimal(Dictionary<String, String> dic, string key)
        {
            try
            {
                return Decimal.Parse(dic[key]);
            }
            catch (SystemException)
            {

            }
            return 0;
        }
        

        private static Dictionary<String, String> Go(String jsonString)
        {
            XmlDictionaryReader jsonReader = JsonReaderWriterFactory.CreateJsonReader(
                Encoding.UTF8.GetBytes(jsonString), new System.Xml.XmlDictionaryReaderQuotas());
            XElement root = XElement.Load(jsonReader);
            Dictionary<String, String> resList = new Dictionary<String, String>();
            JsonParsing(root, "", ref resList);
            return resList;
        }

        private static void JsonParsing(XNode theNode, String parentName, ref Dictionary<String, String> res)
        {
            //Debug.WriteLine(theNode.GetType().ToString());

            if (theNode.GetType() == typeof(XElement))
            {
                XElement xe = (XElement)theNode;
                String xeName = "." + xe.Name.ToString();
                //Debug.WriteLine(xe.Name);
                foreach (XNode xnChild in xe.Nodes())
                {
                    if (xeName.Contains("item"))
                    {

                    }
                    if ((xeName == ".root") || (xeName == ".item") || (xeName == ".{item}item"))
                    {
                        xeName = "";
                    }
                    if (xeName.Contains("item"))
                    {

                    }
                    JsonParsing(xnChild, parentName + xeName, ref res);
                }
            }
            else if (theNode.GetType() == typeof(XText))
            {
                XText xt = (XText)theNode;
                String item = getItemAttributeOfParent(xt);
                if (item != null)
                {
                    item = item.Replace(" ", "");
                    parentName += "." + item;
                }
                if (!res.ContainsKey(parentName))
                {
                    res.Add(parentName, xt.Value);
                }
                //Debug.WriteLine(parentName + ": " + xt.Value);
            }
            else
            {
                //Debug.WriteLine("???");
            }
        }

        private static String getItemAttributeOfParent(XText xt)
        {
            foreach (var a1 in xt.Parent.Attributes())
            {
                if (a1.Name == "item")
                {
                    return a1.Value;
                }
            }
            return null;
        }
    }
}
