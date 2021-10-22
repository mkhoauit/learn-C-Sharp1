using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animal.Classes
{
    /// <summary>
    /// Snake inherits AbstractAnimal 
    ///
    /// </summary>
    class Snake : AbstractAnimal
    {
        
        public Snake(string name, int speed, string food) : base(name , speed, type:"Snake",speak:"SSSSS",food) 
        { }
    }
}
