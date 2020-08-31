using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceDemo
{
    class Friend : IFriend
    {
        public void Friendly() { Console.WriteLine("Friendly"); }
        public void Anger() { Console.WriteLine("Friendly"); }
        public void Laughter() { Console.WriteLine("Friendly"); }
        public void Mature() { Console.WriteLine("Friendly"); }

        public void Hangout(Person obj)
        {
            this.Anger();
            this.Friendly();
            this.Laughter();
            this.Mature();
            
        }
    }
}
