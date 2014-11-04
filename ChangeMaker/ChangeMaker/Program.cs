using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChangeMaker
{
    class Program
    {
        static void Main(string[] args)
        {
            ChangeMaker(1);
            Console.ReadKey();
        }
         static void ChangeMaker(double amount)
        {
             //created "containers" for the amounts of each coin used.
            int Quarters = 0;
            int Dimes = 0;
            int Nickels = 0;
            int Pennies = 0;
             // created this so that the base amount wouldn't actually be manipulated
            double coins = amount;
             //This loop says that as long as there's at least one cent left..
            while (coins > .01)
            {
                //if the amount of coins is greater than .25, it will lower by 25 cents
                //and add a quarter to the "quarter" container
                if (coins >= .25 )
                {
                    Quarters = Quarters + 1;
                    coins = coins - .25;
                } //once there's less than 25 cents, it will use dimes
                // the .09 is there so that it can get the last dime
                    if (coins < .25 && coins > .09)
                { 
                    Dimes = Dimes + 1;
                    coins = coins - .10;
                    }
                //same concept only for nickels
                    if (coins < .10 && coins > .04)
                {
                    Nickels = Nickels + 1;
                    coins = coins - .05;
                    }
                //and same again for pennies
                    if (coins < .05 && coins > 0)
                    {                        Pennies = Pennies + 1;
                        coins = coins - .01;
                    }
               

                

               
                //prints to the console
            } Console.WriteLine("Amount: " + amount);
            Console.WriteLine("Quarters: " + Quarters);
            Console.WriteLine("Dimes: " + Dimes);
            Console.WriteLine("Nickels: " + Nickels);
            Console.WriteLine("Pennies: " + Pennies);
            

        } 
    }
}
