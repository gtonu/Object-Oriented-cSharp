using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritence
{
    public class BankAccount  //Base class/Parent class/super class
    {
        public string AccountNo { get; set; }
        public string CustomerName { get; set; }
        public decimal Balance { get; private set; }


        public string Deposit(decimal amount)
        {
            Balance += amount;
            return "Deposited Successfully!";
        }
        public string WithDraw(decimal amount)
        {
            Balance -= amount;
            return "Withdrawn";
        }
    }
}
