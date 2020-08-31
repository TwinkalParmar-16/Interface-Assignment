using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceDemo
{
    class Office :IOffice
    {
        public void Professional() { Console.WriteLine("Professional"); }

        public void Mature() { Console.WriteLine("Mature"); }

        public void Dowork(Person obj)
        {
            this.Professional();
            this.Mature();
        }

    }
}
