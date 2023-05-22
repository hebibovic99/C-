using System;

namespace OOPExample 
{
    class Program {
        static void Main(string[] args)
        { 
           
            List<Laptop> laptops = new List<Laptop>() {new Mackbook(),new Zenbook()};
           
           foreach(var laptop in laptops) {
            
            laptop.TurnOn();
            laptop.TurnOn(true);
           
           }
           
        }
    }
}

