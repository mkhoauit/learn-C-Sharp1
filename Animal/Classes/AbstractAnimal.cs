using Animal.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animal.Classes
{
    /// <summary>
    /// Create AbstrastAnimal 
    /// AbstrastAnimal inherits IAnimal
    /// Giving writeline for method Eat,Live,Run
    /// </summary>
    abstract class AbstractAnimal : IAnimal
    {
        public string Name { get; set; }

        public string Type { get; private set; }

        public int Speed { get ; set; }
        public string Food { get; set; }

        public string Speak { get; private set; }

        protected AbstractAnimal(string name, int speed, string type,string speak, string food) 
        {
            Name = name;
            Type = type;
            Speak = speak;
            Speed = speed;
            Food = food;
        }
        public void Eat()
        {

            Console.WriteLine($"I'm {Type}, and I can eat {Food} ");
        }

        public void Live()
        {

            Console.WriteLine($"I'm {Type}, and I'm living well");
            Console.WriteLine($"I'm {Type}, and I can speak: {Speak}");
        }

        public void Run()
        {

            Console.WriteLine($"I'm {Name}, I'm runninng at speed {Speed} km/h ");
        }

      
    }
}
