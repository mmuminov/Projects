using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//namespace Bank_T
//{
//    internal class BankAccount
//    {
//        protected string _accountHolderName;
//        protected int _accountNumber;
//        protected double _balance;

//        public virtual void Deposit(double money)
//        {
//            if(money >= 1000) 
//            {
//                _balance += money;
//            }
//            else
//            {
//                throw new Exception("you invalid money: ");
//            }
//        }

//        public virtual void Withdraw() 
//        {

//        }
//    }
//}


var full = new Hello();


public class Hello
{
    public string Fullname(string name, string lastname)
    {
        return $"{name} {lastname}";
    }
}