using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animal.Models
{
    public class Chiens
    {
        public void printChiens(string[] listChiens)
        {
            var choix = from chien in listChiens where chien != "Snow" select chien;
            foreach (string name in choix)
            {
                Console.WriteLine($"{name} est un chien");
            }
        }
    }
}
