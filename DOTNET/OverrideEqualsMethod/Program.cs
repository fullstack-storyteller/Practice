using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OverrideEqualsMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 10;
            int j = 10;
            Console.WriteLine("{0} == {1} => {2}", i, j, i == j);
            Console.WriteLine("{0}.equals( {1} ) => {2}", i, j, i.Equals(j));

            string s1 = "Manish";
            string s2 = "Manish";
            Console.WriteLine("{0} == {1} => {2}", s1, s2, s1 == s2);
            Console.WriteLine("{0}.equals( {1} ) => {2}", s1, s2, s1.Equals(s2));

            Color c1 = Color.blue;
            Color c2 = Color.blue;
            Console.WriteLine("{0} == {1} => {2}", c1, c2, c1 == c2);
            Console.WriteLine("{0}.equals( {1} ) => {2}", c1, c2, c1.Equals(c2));

            //all the above are value types
            //lets talk about the reference types

            Customer C1 = new Customer();
            C1.FirstName = "Archana";
            C1.LastName = "Jasbir";

            Customer C2 = C1;
            Console.WriteLine("C1 == C2 => {0}", C1 == C2);
            Console.WriteLine("C1.equals( C2 ) => {0}", C1.Equals(C2));

            Customer C3 = new Customer();
            C3.FirstName = "Archana";
            C3.LastName = "Jasbir";
            Console.WriteLine("C1 == C3 => {0}", C1 == C3); //false
            Console.WriteLine("C1.equals( C3 ) => {0}", C1.Equals(C3)); //True

            Console.ReadKey();
        }
    }

    public enum Color
    {
        red,
        green,
        blue,
        white
    }

    public class Customer //green swiggly, to remove this, we need to over ride Equals as well as gethascode medot
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public override bool Equals(object obj)
        {
            if (obj ==null)
                return false;

            if (!(obj is Customer))
                return false;

            return this.FirstName == ((Customer)obj).FirstName && this.LastName == ((Customer)obj).LastName;

        }
        public override int GetHashCode()
        {
            //return base.GetHashCode();
            return this.FirstName.GetHashCode() ^ this.LastName.GetHashCode();
        }
    }
}
