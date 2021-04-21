using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

namespace StaticKeywords
{
    class Circle
    {
        public static float  _PI;
            int _Radius;
        static Circle()
        {
            Console.WriteLine("Static Constructor called");
            Circle._PI = 3.14f;
        }
        public Circle(int radius)
        {
            Console.WriteLine("Instance Constructor Called");
            this._Radius = radius;
        }

        public float area()
        {
            return Circle._PI * this._Radius * this._Radius;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Circle c = new Circle(10);
            Console.WriteLine("The area of the circle = {0}", c.area());
            Console.ReadKey();
        }
    }
}
