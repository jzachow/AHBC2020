using System;
using System.Collections.Generic;
using System.Text;

namespace July29Examples
{
    public abstract class Automobile
    {
        protected abstract string Model { get; set; }

        public abstract string Make { get; set; }

        public abstract void Build();

        public void Detroy()
        {
            Console.WriteLine("Your automobile has been destroyed");
        }
    }
}
