using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccount
{
    public delegate UserAccount LoginDelgete();
    internal class Accounts : UserAccount
    {
        public List<UserAccount> accounts;

        #region Create New Account 
        public void Create(UserAccount userAccount)
        {

            if (accounts.Count == 0) { accounts.Add(userAccount); }
            else
            {
                bool Exists = false;
                foreach (var item in accounts)
                {

                    if (userAccount.AccountNumber.Equals(item.AccountNumber))
                    {
                        Console.WriteLine($"Please enter anthor accound  number {item.AccountNumber}  is Exists   "); 
                        Exists = true; break;
                    }


                }
                if (!Exists) accounts.Add(userAccount);
            }

        }
        #endregion


        public Accounts(string _accountNumber, double _balance, string _wnerName, string _password)
            : base(_accountNumber, _balance, _wnerName, _password)
        {



        }
        public Accounts()
        {
            accounts = new List<UserAccount>();
        }

        public void TypeOoeration()
        {
            //LoginDelgete loginDelgete = new LoginDelgete( Accounts.Login);
            var input_user = Login();
            if (input_user!=null)
            {
                OperationFunctionDelgete functionDelgete;
                int op; bool x;
                do
                {
                    Console.WriteLine("please enter your operation \n  1-withdrawa \n 2- Deposit \n  3- Query BlanceState");
                    x = int.TryParse(Console.ReadLine(), out op);

                }
                while (x == false || op < 1 || op > 3);
                //  Console.WriteLine("please enter your operation   1-    withdrawa \n 2- Deposit  ");

                if (op == 1) { functionDelgete = AccountOperation.withdrawa;  functionDelgete.Invoke(input_user); }
                if (op == 2) { functionDelgete = AccountOperation.Deposit;    functionDelgete.Invoke(input_user); }
                if (op == 3) { functionDelgete = AccountOperation.BalanceState; functionDelgete.Invoke(input_user); }


            }
        }


        public UserAccount Login()
        {
            Console.Write(" please enter Account Number");
            string Accn = Console.ReadLine();
            Console.Write(" please enter Account Password");
            string AccP = Console.ReadLine();


            UserAccount loggedInAccount = accounts.FirstOrDefault((accounts => accounts.AccountNumber.Equals(Accn, StringComparison.OrdinalIgnoreCase) 
            && accounts.Password.Equals(AccP)));

            if (loggedInAccount != null)
            {
                Console.WriteLine("Login successful. Welcome, " + loggedInAccount.OwnerName);
            }
            else
            {
                Console.WriteLine("Login failed. Please check your Account Number and Password.");
            }

            return loggedInAccount;
        }
    }
}

        //public override string ToString()
        //{
        //    return $"username is {OwnerName} and acc#{AccountNumber}  balance {Balance}";
        //}



