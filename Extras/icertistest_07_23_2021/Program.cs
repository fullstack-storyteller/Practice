using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

/* Don't change anything here.
 * Do not add any other imports. You need to write
 * this program using only these libraries 
 */

namespace icertistest_07_23_2021
{
    /* You may add helper classes here if necessary */

    public class Program
    {
        public static List<String> processData(IEnumerable<string> lines)
        {
            /* 
             * Do not make any changes outside this method.
             *
             * Modify this method to process `array` as indicated
             * in the question. At the end, return a List containing
             * the appropriate values
             *
             * Do not print anything in this method
             *
             * Submit this entire program (not just this function)
             * as your answer
             */
            List<String> retVal = new List<String>();

            //make dictionary of api and highest version
            Dictionary<string, int> apiMap = new Dictionary<string, int>();
            foreach(string line in lines)
            {
                string[] items = line.Split(',');

                string apiName = items[2].Trim();
                int apiVersion = int.Parse(items[3].Trim().Split(' ')[1]);
                if (!apiMap.ContainsKey(apiName))
                {
                    apiMap.Add(apiName, apiVersion);
                }
                else
                {
                    if (apiVersion > apiMap[apiName])
                    {
                        apiMap[apiName] = apiVersion;
                    }
                }
                
            }
            //foreach(KeyValuePair<string, int> i in apiMap)
            //{
            //    Console.WriteLine("{0} {1}", i.Key, i.Value);
            //}

            //loop through each line to make the retVal list
            Dictionary<string, bool> containsOldApi = new Dictionary<string, bool>();
            foreach(string line in lines)
            {
                string[] items = line.Split(',');
                string company = items[0];
                string api = items[2].Trim();
                int version = int.Parse(items[3].Trim().Split(' ')[1]);
                bool hasOldVersion = version < apiMap[api];

                if (!containsOldApi.ContainsKey(company))
                {
                    containsOldApi[company] = hasOldVersion;
                }
                
                
                if (apiMap[api] == version)
                {
                    if (!retVal.Contains(company))
                    {
                        retVal.Add(company);
                    }
                }
                else
                {
                    if (retVal.Contains(company))
                    {
                        retVal.RemoveAll(x => x == company);
                    }
                        
                }
            }
            //remove the companies which may contain old version
            if (containsOldApi.Count() > 0)
            {
                retVal.RemoveAll(x => containsOldApi[x]);
            }
            return retVal;
        }

        static void Main(string[] args)
        {
            string s = "hello\0world";
            Console.WriteLine(s.Length);
            try
            {
                String line;
                var inputLines = new List<String>();
                while ((line = Console.ReadLine()) != "")
                {
                    line = line.Trim();
                    if (line != "")
                        inputLines.Add(line);
                }
                var retVal = processData(inputLines);
                foreach (var res in retVal)
                    Console.WriteLine(res);
            }
            catch (IOException ex)
            {
                Console.WriteLine(ex.Message);
            }
            Console.ReadKey();
        }

    }

}
