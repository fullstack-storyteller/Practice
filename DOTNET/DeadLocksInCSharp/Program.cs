using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
//using System.Text;
//using System.Threading.Tasks;

namespace DeadLocksInCSharp
    //this is an amazing example.
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Main Started.");
            Account accountA = new Account(102, 10000);
            Account accountB = new Account(105, 13000);

            Console.WriteLine("Account ID: {0}, Balance: {1}", accountA.ID, accountA.Balance);
            Console.WriteLine("Account ID: {0}, Balance: {1}", accountB.ID, accountB.Balance);

            AccountManager accountManagerA = new AccountManager(accountA, accountB, 5000);
            Thread T1 = new Thread(accountManagerA.Transfer);
            T1.Name = "T1";

            AccountManager accountManagerB = new AccountManager(accountB, accountA, 6000);
            Thread T2 = new Thread(accountManagerB.Transfer);
            T2.Name = "T2";

            T1.Start();
            T2.Start();

            T1.Join();
            T2.Join();

            Console.WriteLine("Main Completed.");

            Console.ReadKey();
        }
    }

    class AccountManager
    {
        Account _fromAccount, _toAccount;
        double _amountToTransfer;

        public AccountManager(Account fromAccount, Account toAccount, double amountTotransfer)
        {
            this._amountToTransfer = amountTotransfer;
            this._fromAccount = fromAccount;
            this._toAccount = toAccount;
        }

        ////the below code will deadlock.

        //public void Transfer()
        //{
        //    Console.WriteLine("{0} is trying to acquire lock on {1}", Thread.CurrentThread.Name, this._fromAccount.ID.ToString());
        //    lock (this._fromAccount)
        //    {
        //        Console.WriteLine("{0} has acquired lock on {1}", Thread.CurrentThread.Name, this._fromAccount.ID.ToString());
        //        Console.WriteLine("{0} is going to sleep for 5 seconds.", Thread.CurrentThread.Name);

        //        Thread.Sleep(5000); //simulate the time taken to process

        //        Console.WriteLine("{0} is back in action is trying to acquire lock on {1}", Thread.CurrentThread.Name, this._toAccount.ID.ToString());
        //        lock (this._toAccount)
        //        {
        //            Console.WriteLine("This code will never be executed.");
        //            _fromAccount.Withdraw(this._amountToTransfer);
        //            _toAccount.Deposit(this._amountToTransfer);
        //        }
        //    }
        //}


        ////the below code resolves deadlock by acquiring locks in a specific defined order

        public void Transfer()
        {
            object _resource1, _resource2;

            if(this._fromAccount.ID < this._toAccount.ID)
            //this logic is making sure, no matter which thread gets here first, 
            //_fromAccount will only be seleted
            //if T1 comes first, _fromAccount will be locked
            //if T2 comes first, _fromAccount will be locked
            {
                _resource1 = this._fromAccount;
                _resource2 = this._toAccount;
            }
            else
            {
                _resource2 = this._fromAccount;
                _resource1 = this._toAccount;
            }


            Console.WriteLine("{0} is trying to acquire lock on {1}", Thread.CurrentThread.Name, ((Account)_resource1).ID.ToString());
            lock (_resource1)
            {
                Console.WriteLine("{0} has acquired lock on {1}", Thread.CurrentThread.Name, ((Account)_resource1).ID.ToString());
                Console.WriteLine("{0} is going to sleep for 5 seconds.", Thread.CurrentThread.Name);

                Thread.Sleep(5000); //simulate the time taken to process

                Console.WriteLine("{0} is back in action, and is trying to acquire lock on {1}", Thread.CurrentThread.Name, ((Account)_resource2).ID.ToString());
                lock (_resource2)
                {
                    Console.WriteLine("{0} has acquired lock on {1}", Thread.CurrentThread.Name, ((Account)_resource2).ID.ToString());
                    _fromAccount.Withdraw(this._amountToTransfer);
                    _toAccount.Deposit(this._amountToTransfer);
                    Console.WriteLine("Amount {0} has been transferred from Account {1} to Account {2}", this._amountToTransfer, this._fromAccount.ID, this._toAccount.ID);
                    Console.WriteLine("Account ID: {0}, Balance: {1}", this._fromAccount.ID, this._fromAccount.Balance);
                    Console.WriteLine("Account ID: {0}, Balance: {1}", this._toAccount.ID, this._toAccount.Balance);
                }
            }
        }
    }

    class Account
    {
        double _balance;
        int _id;

        public Account(int id, int balance)
        {
            this._id = id; this._balance = balance;
        }
        public int ID
        {
            get { return this._id; }
        }
        public double Balance
        {
            get { return this._balance; }
        }
        public void Withdraw(double amount)
        {
            this._balance -= amount;
        }

        public void Deposit(double amount)
        {
            this._balance += amount;
        }
    }
}
