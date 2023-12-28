using System.Data;

namespace BankAccount
{
    internal class Program
    {
        static void Main(string[] args)
        {
           
            UserAccount account1 = new UserAccount("1", 1000, "Mohamed", "123");
            UserAccount account2 = new UserAccount("2", 2000, "ali", "123");
            UserAccount account3 = new UserAccount("3", 3000, "AHMED", "123");

          

            Accounts account = new Accounts();
            account.Create(account1);
            account.Create(account2);
            account.Create(account3);
            account.Create(account3);
            // AccountOperation accountOperation1 = new AccountOperation();
            // accountOperation1.withdrawa(account2);
            account. TypeOoeration();
            

            // foreach(var item in Accounts.accounts) { Console.WriteLine(item ); }



        }
    }
}