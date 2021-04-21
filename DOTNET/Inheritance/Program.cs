using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

namespace Inheritance
{
    class Employee
    {
        public Employee()
        {
            Console.WriteLine("Parent Class Constructor executed");
        }

        public Employee(string Name)
        {
            Console.WriteLine("{0}! Parent Class Constructor executed", Name);
        }
        public string fname;
        public string lname;
        public virtual void FullName()
        {
            Console.WriteLine("{0} {1} - Base class.", fname, lname);
        }

    }

    class FullTimeEmployeee : Employee
    {
        public FullTimeEmployeee()
        {
            Console.WriteLine("Full Time- Child Class Constructor executed");
        }
        public float YearlySalary;

        
    }
    class PartTimeEmployeee : Employee
    {
        public PartTimeEmployeee(): base("Manish")
        {
            Console.WriteLine("Part Time - Child Class Constructor executed");
        }
        public float HourlyRate;
        /*
         Method Hiding in C#
            the below method hides the FullName in Employee (Parent class), thus the green swigly line
         to hide the warning use the new keyword
             */
        //public new void FullName()
        //{
        //    Console.WriteLine("{0} {1} - Contractor", fname, lname);
        //}

        //to call the base class implementation of Fullname we can use the base keyword as below
        //public new void FullName()
        //{
        //    base.FullName();
        //}

        //the below will make sure only the latest impementation of the FullName method will be opted, even when calling from the base class.

        /*
         A method signature is a unique identification of a method for the C# compiler. 
         The signature consists of a method name and the type and kind (value, reference, 
         or output) of each of its formal parameters. Method signature does not include the
         return type.

         */
        public override void FullName()
        {
            Console.WriteLine("{0} {1} - Contractor", fname, lname);
        }
    }
    /*
     Derived class is actually a specialization of the base class
     C# only supports single class inheritence, i.e. one class inherits only one class
     multiple imnterfaces can be implemented by one class
     Multi-level inheritence is valid iin C#

     Any time we create an instance of the child class, it automatically creates an instance of the base classs.
     i.e. before the child class cnstructor gets executed, base class constructor will execute.

     In case the parent class has multiple overloaded constructors, the parameterless constructor will be called.
     You can actually control which constructor should be invoked by using the "Base " keyword

         */
    class Program
    {
        static void Main()
        {
            FullTimeEmployeee FTE = new FullTimeEmployeee()
            {
                fname = "Manish",
                lname = "Kumar",
                YearlySalary = 500000
            };
            
            FTE.FullName();
            Console.WriteLine();

            PartTimeEmployeee PTE = new PartTimeEmployeee();
            PTE.fname = "Manish Temp";
            PTE.lname = "Kumar";
            PTE.HourlyRate = 40;
            PTE.FullName();
            Console.WriteLine();

            /*if we want to call the base class from an object of child class, where child has already overridden the base classs implementation of FullName() method*/
            ((Employee)PTE).FullName();//calling the hidden method in base class
            Console.WriteLine();

            /*
             * or we can also call the base class implementation of the FullName method, by using Base class reference variable
             */
            Employee pte = new PartTimeEmployeee();
            pte.FullName();

            //Polymorphism

            //one interfce multiple ways  of implementation
            //polymorphism basically enables you to invoke derived class methods through base class reference variable at runtime.
            //To make sure that the polymorphism is implemented properly, make sure to define the base class method being overridden as Virtual.
            //this will stop method hiding. and even the base class reference variable will be able to fetch the class specific method.

            /*
             what is the basic difference between method hiding and method overrriding?
             1. method hiding may or may not use the new keyword while hiding the base class method, but method overriding will use the virtual keywork in base class method and override
                keyword in child class where overriding is happening
            2.  in case of method hiding, polymorphism can't be implemented. as the base class reference variable will always point to base class implementation, but in 
                method overriding, polymorphism can be implemented because, override keyworks ensure, base class implementation is overridden by child class's implentationa and in can 
                child classes implementation of that method is not available, only then it will go the  base class method implentation.
             
             */

            Employee ep = new FullTimeEmployeee() {
                fname="Employee",
                lname
                ="FullTime",
                YearlySalary=50000
            };
            ep.FullName();
            Console.WriteLine();

            ep = new PartTimeEmployeee() {
                lname = "PartTime",
                fname = "Employee"
                , HourlyRate = 90
            };
            ep.FullName();
            Console.WriteLine();

            Console.ReadKey();


        }
    }
}
