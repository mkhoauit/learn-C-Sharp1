using Animal.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animal.Classes
{
    /// <summary>
    /// Dog inherits AbstractAnimal and ICanSwim
    /// Having method Swim
    /// </summary>
    class Dog : AbstractAnimal,ICanSwim
    {
        
        public void Swim()
        {
            Console.WriteLine(" Ya I can swim");
        }

        public Dog(string name, int speed, string food) : base (name,speed,type:"Dog",speak:"Woof woof",food) 
        { }
    }
}
