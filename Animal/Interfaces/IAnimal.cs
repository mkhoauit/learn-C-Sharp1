using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animal.Interfaces
{
    /// <summary>
    /// IAnimal has 3 method and 4 properties 
    /// </summary>
    interface IAnimal
    {
        public string Name { get; set; }
        public string Type { get; }
        public int Speed { get; set; }
        public string Food { get; set; }
        public string Speak { get; }
        void Live();
        void Run();
        void Eat();
        
    }
}
