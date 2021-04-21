using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;


/*
 Here is what this program is doing:

1. Customer is displayed with a menu
2. Customer selects a item
    a. valid selection move to 3
    b. invalid selection :
        display "Please select valid item from menu"
        move to 1
3. calculate the total amount for this item
4. Ask for another drink?
    a. if yes, move to 1
    b. if no, move to 5
5. display "have a great day!"
6. Display the total bill
7. EXIT

 */
namespace CoffeeeShop
{
    class Program
    {
        static void Main(string[] args)
        {

            int user_choice = 0, move_to_bill = 0;
            int next_round = 0;
            int amt = 0;
            do
            {
                next_round = 0;
                
                
                //displaying the menu
                do
                {
                    Console.WriteLine("1. Black Coffee");
                    Console.WriteLine("2. Latte");
                    Console.WriteLine("3. Kappu Nirvana");
                    Console.WriteLine("Please select from above menu");
                    bool choice = int.TryParse(Console.ReadLine(), out user_choice);
                    if (choice)
                    {
                        if (user_choice < 1 || user_choice > 3)
                        {
                            move_to_bill = 0;
                            Console.WriteLine("Please enter a valid choice");
                        }
                        else
                            move_to_bill = 1;
                    }
                    else
                    {
                        move_to_bill = 0;
                        Console.WriteLine("Please enter a valid choice");
                    }
                } while (move_to_bill == 0);
                //order amount calculation

                switch (user_choice)
                {
                    case 1:
                        amt += 1;
                        break;
                    case 2:
                        amt += 2;
                        break;
                    case 3:
                        amt += 3;
                        break;
                    default:
                        break;
                }
                // asking for another round
                do
                {
                    Console.WriteLine("Would you like another beverage?");
                    Console.WriteLine("Enter 1 for YES and 0 for NO");
                    bool choice = int.TryParse(Console.ReadLine(), out next_round);
                    if (choice)
                    {
                        if (next_round == 1 || next_round==0)
                            break;
                        
                        else
                        {
                            next_round = 0;
                            Console.WriteLine("Please enter a 1 or 0 as response.");
                        }
                    }
                    else
                        Console.WriteLine("Please enter a 1 or 0 as response.");

                } while (next_round==0);

            } while (next_round==1);

            Console.WriteLine("Thank you! Have a great day!");
            Console.WriteLine("Your Total Bill is  {0}", amt);
            Console.ReadKey();
        }
    }
}
