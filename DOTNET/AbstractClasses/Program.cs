using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClasses
{
    public interface I
    {
        void MyPritn(); //public access modifiers in interfaces is by default and should not be explicitly written.
    }
    public abstract class MyAbstract : I//abstract help is implementing the code reusability.
        //it is incomplete and if any member inside it is incomplete, it should be marked as abstract including that incomplete member
    {
        public void MyPritn()
        {
            Console.WriteLine("If an Abstract class is implementing an interface, make sure to give the implementation of all the member of the Interface.\n");
        }

        public abstract void Print();

    }
    class Example : MyAbstract
    {
        public override void Print()//remember override keyword is necessary to implement the abstract method
        {
            Console.WriteLine("Abstract Print method implemented");
        }
    }
    /*
     * Can abstract class be used instead of interfaces?
     * 
     * Certainly! I mean, if we are hell bent on it, then may be we can replicate the behaviour of an interface using abstract class
     * but this would certainly lose some of its special properties.
     * 
     * For example, C# doesn't allow multiple class inheritance, one class will be able to implement on one abstract class
     * (which is acting as interface)
     * again, we willl need to multi level inheritance in order to achieve the goal of replicating the interface
     *  
     * We will also have to make sure that the abstract class (which is acting as interface) must not have any body of it members 
     * and there should also be no data fields
     * as interface doesn't allow that.
     * 
     * Since in abstract class default access modifier for its memebrs is private, We will have to specify the access modifier for 
     * all the member as Public, 
     * which is default in interfaces and also not need to be specified
     * 
     * To make sure we are following the interface properties totally, whichever class which implements the Abstract class 
     * (which is acting as interface)
     * must provide implementation of all the member of the abstract class (which is acting as interface).
     * 
     * Since interface can inherit from an interface only, but abstract class can inherit from Interface and class or abstract class,
     * we should mae sure that  our abstract class (which is acting as interface) must not be inheriting from 
     * an abstract class but only interfaces.
     * 
     * So we can definitely do it, but that's just too much much work. And our code will not be readable and maintainable, and there are too many 
     * conditions to look out for.
     * So evn though we can do it, we shouldn't.
     * 
     * **/
    class Program
    {
        static void Main(string[] args)
        {
            //two ways of calling an abstract method
            Example e = new Example();
            e.Print();
            Console.WriteLine();

            MyAbstract ma = new Example();
            ma.Print();
            Console.WriteLine();
            ma.MyPritn();
            Console.ReadKey();

        }
    }
}
