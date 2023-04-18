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

        public string name { get; private set; }

        public virtual void Move(string name)
        {
            Console.WriteLine($"{name} bouge !");
        }

        public virtual void Sleep(string name)
        {
            Console.WriteLine($"{name} dort !");
        }
    }
}
