using System;
using System.Collections.Generic;
using System.Text;

namespace BehavioralPatterns.Classes.Mementos
{
    public class BankMemento
    {
        public string ownerName {  get; private set; }
        public string ownerAdress { get; private set; }
        public decimal balance { get; private set; }

        public BankMemento(string ownerName, string ownerAdress, decimal balance)
        {
            this.ownerName = ownerName;
            this.ownerAdress = ownerAdress;
            this.balance = balance;
        }
    }
}
