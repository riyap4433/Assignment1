using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace RoseBlanches
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Taking the user input for the amount of the money received
            Console.Write("How much did you receive money ($)? ");
            int total_money = int.Parse(Console.ReadLine());


            //Declaring a new variable book_supplies as integer and calculating the amount of dollars spent on it 
            //According ot the given situation
            int books_supplies = (3*total_money/4) ;

            //Calculating the remaining money after spending some dollars on books and supplies
            int remainingMoney = total_money - books_supplies;
            

            //Evenly dividing the money
            int remaining_money1 = remainingMoney / 3;


            //Calculating the number of things that can be purchased
            int coffees = (remaining_money1 / 2);
            int flash_computers = (remaining_money1 / 4);
            int subway_tickets = (remaining_money1 / 3);

            int money_spent = (coffees * 2 + flash_computers * 4 + subway_tickets * 3);


            //Calculating the remaining money after all the expenses are done
            int remaining_afterexpense = remainingMoney - money_spent;


            //Printing the output
            Console.WriteLine("Book and Supplies: {0}$ ", books_supplies);
            Console.WriteLine("You can then buy:");
            Console.WriteLine("{0} coffees", coffees);
            Console.WriteLine("{0} Flash Computer Numbers", flash_computers);
            Console.WriteLine("{0} subway Tickets", subway_tickets);

            
            Console.WriteLine("and you will have {0} dollars for the white roses.",remaining_afterexpense) ;
        }
    }
}