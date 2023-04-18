using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animal.AnimalClasses
{
    public class AnimalMooveSleep
    {
        public AnimalMooveSleep() { }

        public string name { get; set; }

        public void Moove(string name)
        {
            Console.WriteLine($"{name} bouge !");
        }

        public void Sleep(string name)
        {
            Console.WriteLine($"{name} dort !");
        }
    }
}
