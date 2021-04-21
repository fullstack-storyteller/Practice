using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeautifulTripletsHackerrank
{
    class Program
    {
        static void Main(string[] args)
        {
            //int n = 7;
            int d = 3;
            int[] arr = { 1, 2,  4, 5, 7, 8, 10 };
            //int[] arr = { 1, 2, 2, 4, 5, 7, 8, 10 };
            //int[] arr = {1, 6, 7, 7, 8, 10, 12, 13, 14, 19};
            int result = beautifulTriplets(d, arr);
            Console.ReadKey();
        }


        static int beautifulTriplets(int d, int[] arr)
        {
            Dictionary<int, int> keyValues = new Dictionary<int, int>();
            int count = 0;
            foreach (int i in arr)
            {
                keyValues[i] = i ;
            }
            foreach(int i in arr)
            {
                if( keyValues.Values.Contains(i+d) && keyValues.Values.Contains(i + 2*d))
                {
                    Console.WriteLine(i + " " + (i + d) + " " + (i + 2 * d));
                    count++;
                }
            }


            printDict(keyValues);
            Console.WriteLine("Count of Beautiful Triplets: " + count);
            return count;

        }

        private static void printDict(Dictionary<int, int> keyValues)
        {
            foreach(int i in keyValues.Keys)
            {
                Console.WriteLine(i + " " + keyValues[i]);
            }
        }
    }
}
