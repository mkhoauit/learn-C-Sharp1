using Animal.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animal.Classes
{
    /// <summary>
    /// Bird inherits AbstractAnimal and ICanFly
    /// Having method Fly
    /// </summary>
    class Bird : AbstractAnimal, ICanFly
    {
        public void Fly()
        {
            Console.WriteLine(" ----> Yeah I can flying");
        }
       
        public Bird(string name, int speed,string food) : base(name, speed, type: "BIRD",speak:"cheap cheap",food)
        {
        }
    }
}
