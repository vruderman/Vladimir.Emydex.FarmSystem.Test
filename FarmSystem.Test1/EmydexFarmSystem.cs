using System;
using System.Collections.Generic;
using System.Linq;

namespace FarmSystem.Test1
{
    public class EmydexFarmSystem
    {
        /// <summary>
        /// Maintain animal queue using the first in / first out structure
        /// </summary>
        protected Queue<Animal> AnimalQueue = new Queue<Animal>();

        //TEST 1

        public void Enter(Animal animal)
        {
            AnimalQueue.Enqueue(animal);
            Console.WriteLine($"{animal.GetType().Name} ({animal.Id}) has entered the Emydex farm");
        }

        //TEST 2 - Modify this method to make the animals talk

        public void MakeNoise()
        {
            if (AnimalQueue.Count > 0)
            {
                foreach (Animal animal in AnimalQueue)
                {
                    animal.Talk();
                }
            }
            else
            {
                Console.WriteLine("There are no animals in the farm");
            }
        }

        //TEST 3
        public void MilkAnimals()
        {
            foreach (Animal animal in AnimalQueue)
            {
                if (animal is IMilkableAnimal)
                {
                    ((IMilkableAnimal)animal).ProduceMilk();
                }
            }
        }

        //TEST 4

        /// <summary>
        /// Process animals leaving using the first in / first out structure
        /// </summary>
        /// 
        public void Release()
        {
            Animal animal = AnimalQueue.Dequeue();
            Console.WriteLine($"{animal.GetType().Name} ({animal.Id}) has left the farm");
        }

        /// <summary>
        /// Option to release specific anymal
        /// </summary>
        /// 
        public void Release(Animal animal)
        {
            AnimalQueue = new Queue<Animal>(AnimalQueue.Where(x => x.Id != animal.Id));
            Console.WriteLine($"{animal.GetType().Name} ({animal.Id}) has left the farm");
        }
        public void ReleaseAllAnimals()
        {
            while (AnimalQueue.Count > 0)
            {
                Release();
            }

            Console.WriteLine("Emydex Farm is now empty");
        }
    }
}