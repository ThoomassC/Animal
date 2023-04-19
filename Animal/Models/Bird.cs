using Animal.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Animal.Models
{
    public class Bird: Animal, IFly
    {
        public Bird(int id, string name, string rarity) : base(id, name, rarity)
        { }
        public void fly()
        {
            Console.WriteLine($"Bird {Name} est en train de voler !");
        }
    }
}
