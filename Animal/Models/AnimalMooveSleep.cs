using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animal.Models
{
    public abstract class AnimalMooveSleep
    {
        public AnimalMooveSleep() { }

        public string name { get; protected set; }

        public virtual void move(string name)
        {
            Console.WriteLine($"{name} bouge !");
        }

        public virtual void sleep(string name)
        {
            Console.WriteLine($"{name} dort !");
        }
    }
}