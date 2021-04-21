using System;
using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

namespace Chef_CHEFINSQ
{
    class Program
    {
        static int factorial( int i)
        {
            int result=1;
            if(i==1 || i == 0)
            {
                return result;
            }
            else
            {
                for(int j=2; j <= i; j++)
                {
                    result *= j;
                }
            }
            return result;
        }
        static void Main(string[] args)
        {
            int TestCount=Convert.ToInt32(Console.ReadLine());
            int TestNo = 1;
            do
            {
                string[] ms = Console.ReadLine().Split(' ');
                int LenthMainSeq = Convert.ToInt32(ms[0]);
                int LengthSubSeq = Convert.ToInt32(ms[1]);
                int[] mseq = Array.ConvertAll(Console.ReadLine().Split(' '), ar=>Convert.ToInt32(ar));
                //int InterestingCase = 0;
                Console.WriteLine(InterestingCase(mseq, LenthMainSeq, LengthSubSeq));
                TestNo++;
            } while (TestNo <= TestCount);
        }

        static int FindSetSum(int[][] a, int subsetsize, int column) 
        {
            int sum = 0;
            for(int i=0; i<subsetsize; i++)
            {
                sum += a[i][column];
            }
            return sum;
        }
        static int InterestingCase(int[] mainseq, int mainsize,int subseqsize)
        {
            int interestingCaseCount = 0;
            int numberofsubsets = factorial(mainsize) / (factorial(mainsize - subseqsize) * factorial(subseqsize));
            int[][] set = new int[subseqsize][];
            int sum=FindSetSum(set, subseqsize,0);
            for(int i=1; i<numberofsubsets; i++)
            {
                if(sum>FindSetSum(set, subseqsize, i))
                {
                    sum = FindSetSum(set, subseqsize, i);
                }
            }

            
            return interestingCaseCount;
        }
    }
}
