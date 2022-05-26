using System;

namespace FarmSystem.Test1
{
    public class Horse : Animal
    {
        /// <summary>
        /// Implement abstract Animal class methods
        /// </summary>
        public override void Talk()
        {
            Console.WriteLine("Horse says neigh!");
        }

        public override void Run()
        {
            Console.WriteLine("Horse is running");
        }
        public override void Walk()
        {
            Console.WriteLine("Horse is walking");
        }
    }
}