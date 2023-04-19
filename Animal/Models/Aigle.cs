using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Animal.Interface;

namespace Animal.Models
{
    public class Aigle: Animal, IFly
    {
        public Aigle(int id, string name, string rarity) : base(id, name, rarity)
        { }

        public void fly()
        {
            Console.WriteLine($"Aigle {Name} est en train de voler !");
        }
    }
}
