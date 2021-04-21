using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

namespace Enums
{
    public class Program
    {
        static void Main(string[] args)
        {
            
            Customer[] customers = new Customer[4];
            customers[0] = new Customer()
            {
                Name = "Manish",
                Gender = 1,
                GenderWithEnum=Gender.Male
                
            };
            customers[1] = new Customer()
            {
                Name = "Ramesh",
                Gender = 1,
                //GenderWithEnum = 123;//will through an error because enum is strongly typed

                //the below is ok
                //GenderWithEnum = Gender.Male
                GenderWithEnum = (Gender)14//correct conversion of int to enum element but the value 14 does not have any element associated with it inside enum
            };
        
            customers[2] = new Customer()
            {
                Name = "Akila",
                Gender = 2,
                GenderWithEnum = Gender.Female
            };
            customers[3] = new Customer()
            {
                Name = "Manisha",
                Gender = 0,
                GenderWithEnum = Gender.Unknown
            };

            foreach(Customer c in customers)
            {
                Console.WriteLine("Customer Name = {0}, and Gender = {1}", c.Name, GetGender(c.Gender));
                //even after implementing the getGender Method, the program is not readable.
                // as the program grows, dealing with interger forms of geneder will become more and deficult.
            }
            Console.WriteLine();
            Console.WriteLine("the below is done using Enum");
            Console.WriteLine();
            foreach (Customer c in customers)
            {
                Console.WriteLine("Customer Name = {0}, and Gender = {1}", c.Name, GetGenderWithEnum(c.GenderWithEnum));
               
            }


            //Use and difference between Enum and enum keywords
            // Enum is a class in sytem namespace, while enum keywprd help crate strongly typed
            //contants and value types.
            string[] EnumNames = Enum.GetNames(typeof(Gender));
            //int[] EnumValues = (int[]) Enum.GetValues(typeof(Gender));

            // Since we changed the type, we need to type cast again with short array
            short[] EnumValues = (short[])Enum.GetValues(typeof(Gender));
            // get all the string name of the enum
            Console.WriteLine();

            foreach (string name in EnumNames)
            {
                Console.WriteLine(name);
            }
            Console.WriteLine();

            //get all the underlying type of the values of enum
            foreach (int value in EnumValues)
            {
                Console.WriteLine(value);
            }
            Console.ReadKey();
        }

        /// <summary>
        /// 0-> Unknown
        /// 1-> Male
        /// 2-> Female
        /// </summary>
        static string GetGender(int gender)
        {
            switch (gender)
            {
                case 0: return "Unknown";
                    
                case 1: return "Male";
                //break; //break is not required as return is used
                case 2: return "Female";
                default: return "Not Specified";

            }
        }

        static string GetGenderWithEnum(Gender gender)
        {
            switch (gender)
            {
                case Gender.Unknown: return "Unknown";

                case Gender.Male: return "Male";
                //break; //break is not required as return is used
                case Gender.Female: return "Female";
                default: return "Not Specified";

            }
        }



    }

    //Let create an enum to resolve this problem

        //we can also change the underlying type of the enum.
        // by default it is integer.
        //Please note, the changed type should be intergral type only
    public enum Gender: short
    {
        Unknown,
        Male =11, // we can also assign some value into individual enum elements
        //just make sure the abide by the underlying types' range.
        Female
    }


    public class Customer
    {
        public string Name { get; set; }
        public int Gender { get; set; }
        
        // how enum to be used in class customer
        public Gender GenderWithEnum { get; set; }
    }
}
