using Animal.Interface;

namespace Animal.Models
{
    public class Griffin : Animal, IFly
    {
        public Griffin(int id, string name, string rarity) : base(id, name, rarity)
        { }

        public override void move(string name)
        {
            Console.WriteLine($"{name} bouge ! (fonction override Griffin)");
        }

        public new void sleep(string name)
        {
            Console.WriteLine($"{name} dort ! (fonction new Griffin)");
        }

        public new void printIdAndNameAndRarity(int id, string name, string rarity)
        {
            Console.WriteLine($"l'id {id} a pour nom {name} et est de rareté {rarity}");
        }

        public void fly()
        {
            Console.WriteLine($"Griffin {Name} est en train de voler !");
        }
    }
}
