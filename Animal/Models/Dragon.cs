using Animal.Interface;

namespace Animal.Models
{
    public class Dragon : Animal, Pilotage, IFly
    {
        public Dragon(int id, string name, string rarity) : base(id, name, rarity)
        { }

        public void drive()
        {
            throw new NotImplementedException();
        }

        public override void move(string name)
        {
            Console.WriteLine($"{name} bouge ! (fonction override Dragon)");
        }

        public new void sleep(string name)
        {
            Console.WriteLine($"{name} dort ! (fonction new Dragon)");
        }

        public new void printIdAndNameAndRarity(int id, string name, string rarity)
        {
            Console.WriteLine($"l'id {id} a pour nom {name} et est de rareté {rarity}");
        }

        public void fly()
        {
            Console.WriteLine($"Dragon {Name} est en train de voler !");
        }
    }
}
