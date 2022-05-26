using System;

namespace FarmSystem.Test1
{
    public class Hen : Animal
    {
        /// <summary>
        /// Implement abstract Animal class methods
        /// </summary>
        public override void Talk()
        {
            Console.WriteLine("Hen say CLUCKAAAAAWWWWK!");
        }
        public override void Run()
        {
            Console.WriteLine("Hen is running");
        }
        public override void Walk()
        {
            Console.WriteLine("Hen is walking");
        }
    }
}