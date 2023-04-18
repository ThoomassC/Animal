using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animal.Models
{
    public abstract class Animal
    {
        public Animal(int id, string name, string rarity) 
        {
            Id = id;
            Name = name;
            Rarity = rarity;
        }

        public string Name { get; protected set; }

        public string Rarity { get; set; }

        public int Id { get; set; }

        public virtual void move(string name)
        {
            Console.WriteLine($"{name} bouge !");
        }

        public virtual void sleep(string name)
        {
            Console.WriteLine($"{name} dort !");
        }

        public virtual void printIdAndNameAndRarity(int id, string name, string rarity)
        {
            Console.WriteLine($"l'id {id} a pour nom {name} et est de rareté {rarity}");
        }
    }
}