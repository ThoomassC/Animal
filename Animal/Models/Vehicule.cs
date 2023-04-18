using Animal.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animal.Models
{
    public class Vehicule: Pilotage
    {
        public void drive()
        {
            throw new NotImplementedException();
        }

        public void move(string name)
        {
            Console.WriteLine($"{name} est un véhicule");
        }
    }
}
