using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animal.Classes
{
    /// <summary>
    /// Cat inherits AbstractAnimal 
    /// 
    /// </summary>
    class Cat : AbstractAnimal
    {
       
        public Cat (String name, int speed, string food) : base(name, speed, type: "Cat",speak:"Meow Meow", food) 
        { }
    }
}
