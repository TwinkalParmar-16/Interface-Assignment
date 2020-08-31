using System;

namespace InterfaceDemo
{
   

    /*public class Friend
    {
        public void Hangout(Person obj)
        {
            obj.Anger();
            obj.Friendly();
            obj.Laughter();
            obj.Mature();
            obj.Professional();//Hidden

        }

    }

    public class Office
    {
        public void Dowork(Person obj)
        {
            obj.Professional();
            obj.Mature();
            obj.Anger();//hidden
            obj.Friendly();//hidden


        }
    }




    public class Person
    {

        public void Friendly() { Console.WriteLine("Friendle Behavior"); }
        public void Professional() { }
        public void Anger() { }

        public void Laughter() { }

        public void Mature() { }


    }*/
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Person _singlePerson = new Person();

            Family __familiyVisit = new Family();
            __familiyVisit.Visit(_singlePerson);

            Office _workContext = new Office();
            _workContext.Dowork(_singlePerson);

            Friend _friendCircle = new Friend();
            _friendCircle.Hangout(_singlePerson);
        }
    }
}
