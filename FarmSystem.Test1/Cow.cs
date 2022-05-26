using System;

namespace FarmSystem.Test1
{
    public class Cow : Animal, IMilkableAnimal
    {
        /// <summary>
        /// Implement abstract Animal class methods
        /// </summary>
        public override void Talk()
        {
            Console.WriteLine("Cow says Moo!");
        }

        public override void Walk()
        {
            Console.WriteLine("Cow is walking");
        }

        public override void Run()
        {
            Console.WriteLine("Cow is running");
        }

        /// <summary>
        /// Implement interface which exposes method to milk animals
        /// </summary>
        public void ProduceMilk()
        {
            Console.WriteLine("Cow was milked");
        }
    }
}