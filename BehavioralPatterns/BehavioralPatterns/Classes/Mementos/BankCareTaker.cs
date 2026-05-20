using System;
using System.Collections.Generic;
using System.Text;

namespace BehavioralPatterns.Classes.Mementos
{
    public class BankCareTaker
    {
        public List<BankMemento> history { get; private set; } = new List<BankMemento>();

        public void Push(BankMemento memento)
        {
            if (memento != null)
            {
                this.history.Add(memento);
            }
        }

        public BankMemento Pop()
        {
            if (this.history.Count == 0)
            {
                return null;
            }

            int lastIndex = this.history.Count - 1;
            BankMemento lastState = this.history[lastIndex];

            this.history.RemoveAt(lastIndex);

            return lastState;
        }

    }
}
