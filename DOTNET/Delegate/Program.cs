using System;
using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

namespace Delegate
{
    /*
     * delegate is a type safe function pointer
     * a reference type like class
     * the syntax is similar to a method
     * the syntax of the delegate should be same as method to be associated 
     * with it.
     */
    //public delegate void HelloFunctionDelegate(string message);
    class Program
    {
        static void Main(string[] args)
        {
            //create a new instance of the delegate
            //HelloFunctionDelegate delegatedHello = new HelloFunctionDelegate(Hello);
            //delegatedHello("This is my delegate");
            List<Employee> empList = new List<Employee>();
            empList.Add(new Employee(){ ID= 101, Name = "Manish", experience=5, salary=4000});
            empList.Add(new Employee() { ID = 101, Name = "Manish", experience = 5, salary = 4000 });
            empList.Add(new Employee() { ID = 101, Name = "Archana", experience = 15, salary = 3000 });
            empList.Add(new Employee() { ID = 101, Name = "Ramesh", experience = 5, salary = 5000 });
            empList.Add(new Employee() { ID = 101, Name = "Akilandeshwari", experience = 5, salary = 6000 });
            empList.Add(new Employee() { ID = 101, Name = "Poonam", experience = 5, salary = 47000 });
            Employee.PromoteEmployees(empList);
            Console.WriteLine();
            Employee.PromoteEmployeesDelegateEnabled(empList, /*you can pass the method implementing the logic itself*/PromoteEmployeeLogic);

            // depending upon the requirement your can change the method implementation of PromoteEmployeeLogic in different module than send it to Employee object method which has delegate enabled
            Console.WriteLine();
            //another way to implement this is, we can directly pass the lambda expression, which create the delegate automatically for us at runtime.
            Employee.PromoteEmployeesDelegateEnabled(empList, emp => emp.experience >= 5); //see how simple it is.
            //or
            Console.WriteLine();
            Employee.PromoteEmployeesDelegateEnabled(empList, (employeeObject)=> employeeObject.experience>=5 ); //lambda object with the annonymous function

            Console.ReadKey();
        }
        static void Hello(string msg)
        {
            Console.WriteLine(msg+"\n");
        }

        static bool PromoteEmployeeLogic(Employee e)//this is the method which implement the promotion logic
        {
            /*for the sake of this program, I'm writing the method to be delegated here
             it can be in any file to outside of employee class
             */
            if (e.experience >= 5)
                return true;
            return false;
        }

    }
    //lets define the delegate which will use PromoteEmployeeLogic
    public delegate bool PromoteEmployeeDelegate(Employee e);
    public class Employee
    {
        public int ID { get; set; }
        public int salary { get; set; }
        public int experience { get; set; }
        public string Name { get; set; }

        /*
         * Now if we want to implement a logic to promote a bunch of employees,
         * it should be delegated to a different place / method not inside the employees class
         * The Employee class should be as independent as possible.
         * Check out the below function which is a porr ways of implementing this logic
         * 
         * **/
        public static void PromoteEmployees(List<Employee> x)
        {
            foreach( Employee e in x)
            {
                if (e.experience >= 5) //any future changes to the logic of promotion have to be made here, which is not cool!
                    Console.WriteLine("{0} promoted! ", e.Name);
            }
        }
        /*
         * this is how we implement the desired code using delegate.
         * Goal is to make sure the Logic for the finding the people to promote is not hardcoded into the code
         * to fulfill this we can send the logic as a method parameter itself.
         * 
         * And how do we accomplish that?
         * By sending the function itself, which will do the logic implementation.
         * 
         * So check out the new method PromoteEmployeesDelegateEnabled
         * 
         * **/
         public static void PromoteEmployeesDelegateEnabled(List<Employee> x, PromoteEmployeeDelegate promoteEmployeeDelegate)
        {
            foreach(Employee e in x)
            {
                if (promoteEmployeeDelegate(e))
                    Console.WriteLine("{0} promoted! ", e.Name);

            }
        }

    }
}
