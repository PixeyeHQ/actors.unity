using System;

namespace Pixeye.Actors
{
    public class SetGroupCapacityAttribute : Attribute
    {
        public int Capacity;

        public SetGroupCapacityAttribute(int capacity)
        {
            this.Capacity = capacity;
        }
    }
}

