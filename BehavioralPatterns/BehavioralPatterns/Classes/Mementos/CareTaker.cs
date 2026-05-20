using System;
using System.Collections.Generic;
using System.Text;

namespace BehavioralPatterns.Classes.Mementos
{
    public class CareTaker
    {
        public List<Memento> history { get; private set; } = new List<Memento>();

        public void Push(Memento memento)
        {
            if (memento != null)
            {
                this.history.Add(memento);
            }
        }

        public Memento Pop()
        {
            if (this.history.Count == 0)
            {
                return null;
            }
            
            int lastIndex = this.history.Count - 1;
            Memento lastState = this.history[lastIndex];

            this.history.RemoveAt(lastIndex);

            return lastState;
        }
    }
}
