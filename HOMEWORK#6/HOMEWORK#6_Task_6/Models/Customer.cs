using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HOMEWORK_6_Task_6.Models
{
    public class Customer
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public long CardNumber { get; set; }

        private int Pin { get; set; }
        private int Balance { get; set; }

        public Customer(string firstName, string lastName, int balance, long cardNumber, int pin)
        {
            FirstName = firstName;
            LastName = lastName;
            Balance = balance;
            CardNumber = cardNumber;
            Pin = pin;
        }

        public int GetBalance()
        {
            return Balance;
        }

        public void SetBalance(int balance)
        {
            Balance = balance;
        }

        public bool IsPinValid(int pin)
        {
            return Pin == pin;
        }
    }
}
