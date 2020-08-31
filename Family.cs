using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceDemo
{
    class Family : IFamily
    {

        public void Friendly() { Console.WriteLine("Friendle Behavior"); }
        
        public void Laughter() { Console.WriteLine("Laughter Behavior"); }

        public void Mature() { Console.WriteLine("Mature Behavior"); }
        public void Visit(Person obj)
        {

            this.Friendly();
            this.Laughter();
            this.Mature();
           
        }
    }
}
