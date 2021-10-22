using Animal.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;




namespace Animal.Classes
{
    class Program
    {
        public static void Main()
        {
            var animals = new List<IAnimal>();
            animals.Add(new Dog("Popy", 10, "meat,bone,vegetable"));
            animals.Add(new Cat("Ming", 15,"meat,fish"));
            animals.Add(new Bird("Iggy", 19,"worm,vegetable"));
            animals.Add(new Snake("Snow", 12,"meat,egg"));
            
            Console.WriteLine("Animals have speed more than 10:");
            animals.FindAll(a => a.Speed > 11).ForEach(a =>a .Run());
            Console.WriteLine();

            Console.WriteLine($"Animals you have:{animals.Count()}");
            Console.WriteLine();

           

            Console.WriteLine("List of animals in the shop:");
            foreach (var animal in animals)
            {
                LetItLive(animal);
                LetItRun(animal);
                LetItEat(animal);
                

                switch (animal)
                {
                   
                    case ICanFly fly:
                        LetItFly(fly);
                        Console.WriteLine();
                        break;
                    case ICanSwim swim:
                        LetItSwim(swim);
                        Console.WriteLine();
                        break;
                }
            }
        }

        /// <summary>
        /// Gather the animal can fly
        /// </summary>
        private static void LetItFly(ICanFly animal)
        {
            animal.Fly();
        }

        /// <summary>
        /// Let the animal live
        /// </summary>
        private static void LetItLive(IAnimal animal)
        {
            animal.Live();
        }

        /// <summary>
        /// Let the animal run
        /// </summary>
        private static void LetItRun(IAnimal animal)
        {
            animal.Run();
        }

        /// <summary>
        /// Let the animal eat
        /// </summary>
        private static void LetItEat(IAnimal animal)
        {
            animal.Eat();
        }

        /// <summary>
        /// Gather the animal can swim
        /// </summary>
        private static void LetItSwim(ICanSwim animal)
        {
            animal.Swim();
        }
    }
}
