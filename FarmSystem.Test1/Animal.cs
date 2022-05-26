using System;

namespace FarmSystem.Test1
{
    /// <summary>
    /// Abstract Animal class
    /// </summary>
    public abstract class Animal
    {
        public Animal()
        {
            _id = Guid.NewGuid().ToString();
        }

        private string _id = null;
        private int _noOfLegs = 4;

        public string Id
        {
            get { return _id; }
            set { _id = value; }
        }
        public int NoOfLegs
        {
            get { return _noOfLegs; }
            set { _noOfLegs = value; }
        }

        public abstract void Talk();

        public abstract void Walk();

        public abstract void Run();
    }
}