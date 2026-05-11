using System;
using System.Collections.Generic;
using System.Text;
using DesignPatterns.Interfaces;

namespace DesignPatterns.Classes
{
    public class GroupNote : Note
    {
        private List<string> groupMembers;

        public GroupNote(string message, ITheme theme) : base(message, theme)
        {
            this.groupMembers = new List<string>();
        }

        public void AddMember(string name)
        {
            if (!groupMembers.Contains(name))
            {
                groupMembers.Add(name);
            }
        }

        public void RemoveMember(string name) 
        {
            if (groupMembers.Contains(name))
            {
                groupMembers.Remove(name);
            }
        }

        public override void Show()
        { 
            this.ChangeColor();

            Console.WriteLine("GROUP NOTE:");

            string framedMessage = this.GetFramedMessage();
            Console.WriteLine(framedMessage);

            Console.WriteLine("Members: " + string.Join(", ", groupMembers));

            Console.ResetColor();
        }
    }
}
