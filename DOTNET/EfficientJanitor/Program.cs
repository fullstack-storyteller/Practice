using System;
using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

namespace EfficientJanitor
{
    class Program
    {

        public static int efficientJanitor(List<double> weight)
        {
            double weight_in_hand = 0;
            int bag_no= 0;
            int trip_count = 0;
            while (bag_no < weight.Count)
            {
                weight_in_hand = 0;
                while(bag_no<weight.Count && weight_in_hand + weight[bag_no] <= 3.0) //  make sure to double check the bag_no limit. it should be less than weight list count in every loop.
                {
                    //this kind of problem where the loop variable is incremented conditionally
                    //is better to be handled using the while loop. more to be practiced.
                    weight_in_hand += weight[bag_no];
                    bag_no++; 
                    
                }
                trip_count++;
            }



            //double remaining = 3.0;
            //for (int i =0; i< weight.Count; i++)
            //{
            //    Console.WriteLine("Current Weight = " + weight[i]);
            //    if (weight[i]<3.0)
            //    {
            //        in_hand += weight[i];
            //        remaining = 3.0 - in_hand ;
            //        Console.WriteLine("in-hand = " + in_hand);
            //        Console.WriteLine("Remaining weight = "+remaining);
            //        if (remaining <= 0)
            //        {
            //            trip_count += 1;
            //            in_hand =0  ;
                        
            //            Console.WriteLine("Current Trip = "+trip_count);
            //            Console.WriteLine();
            //        }
            //        //capacity = 0;
            //    }
                //if (carry_weight <= 3.0) 
                //{
                //    carry_weight += i;
                //    //Console.WriteLine(carry_weight);

                //}
                //else
                //{
                //    trip_count += 1;
                //    carry_weight = 0;
                //}
            //}
            return trip_count;
        }
        static void Main(string[] args)
        {
            List<double> l = new List<double>();
            l.Add(1.01);
            l.Add(1.01);
            l.Add(1.01);
            l.Add(1.4);
            l.Add(2.4);
            Console.WriteLine(efficientJanitor(l));
            Console.ReadKey();
        }
    }
}
