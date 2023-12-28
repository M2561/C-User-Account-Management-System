using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace BankAccount
{
   
    internal class AccountOperation
    {
        public AccountOperation()
        {

        }

        public static double check()
        {
            double amount; bool isValidInput;
            isValidInput = double.TryParse(Console.ReadLine(), out amount);

            if (isValidInput   && amount >0) return amount;
            else
            {
                Console.WriteLine("Please enter a valid, positive number."); return 0;
            }
        }


        public static void Deposit(UserAccount user)
        {
                Console.WriteLine(" how match  will you Deposit  ?");
           
            double amount = check();  
  
                Console.WriteLine($"Your Blance is {user.Balance} and you need {amount} \n and   your new Balnse is {user.Balance + amount}");
                user.Balance += amount;
            
           
        }








        public  static  void   withdrawa(UserAccount user)
        {
            

               
                Console.WriteLine(" how match  will you need ?");
            double amount = check();
            if (amount < user.Balance ) { 
                    Console.WriteLine( $"Your Blance is {user.Balance} and you need {amount} \n and   your new Balnse is {user.Balance - amount}");
                    user.Balance -= amount;

            }
             else  Console.WriteLine( $"you only have {user.Balance} ");
        }








        public static void BalanceState(UserAccount userAccount)
        {
            Console.WriteLine($"Your Blance is {userAccount.Balance}    ");

        }









    }
}
