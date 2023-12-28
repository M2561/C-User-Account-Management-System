using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace BankAccount
{
    public delegate void OperationFunctionDelgete(UserAccount userAccount);
    public class UserAccount
    {
         

        public   string     AccountNumber { get; set; }
        public   double     Balance { get; set; }
        public   string     OwnerName { get; set; }
        public   string     Password { get; set; }



        public UserAccount(string _accountNumber, double _balance, string _wnerName, string _password)
        {
            Balance = _balance;
            OwnerName = _wnerName;
            Password = _password;
            AccountNumber = _accountNumber;
        }

            public UserAccount()
        {
            
        }

         



    }
}
