using System;
using System.Collections.Generic;
using System.Text;

namespace BehavioralPatterns.Classes.Mementos
{
    public class BankAccount
    {
        private string ownerName;
        private string ownerAddress;
        private decimal balance;
        public BankAccount(string ownerName, string ownerAddress, decimal balance)
        {
            this.ownerName = ownerName;
            this.ownerAddress = ownerAddress;
            this.balance = balance;
        }
        public void ChangeOwnerAddress(string address)
        {
            this.ownerAddress = address;
        }
        public void UpdateBalance(decimal amount) { this.balance += amount; }
        public string OwnerName { get { return this.ownerName; } }
        public string OwnerAddress { get { return this.ownerAddress; } }
        public decimal Balance { get { return this.balance; } }

        public BankMemento StoreState()
        {
            return new BankMemento(this.OwnerName, this.OwnerAddress, this.balance);
        }

        public void RestoreState(BankMemento previous) 
        {
            this.ownerName = previous.ownerName;
            this.ownerAddress = previous.ownerAdress;
            this.balance = previous.balance;
        }

        public override string ToString()
        {
            return "Name " + this.OwnerName + " Adress " + this.OwnerAddress + "\n" + "Balance: " + balance;
        }

    }
}
