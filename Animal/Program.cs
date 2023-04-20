using System.Text;
using Animal.Interface;
using Animal.Models;

class Program
{
    static void Main(string[] args)
    {
        Console.OutputEncoding = Encoding.UTF8;

        /*Griffin griffin= new();
        griffin.move("Griffin");
        griffin.sleep("Griffin");*/

        /*Dragon dragon = new();  // si constructeur vide
        dragon.move("Dragon");
        dragon.sleep("Dragon");*/

        /*var a = new Dragon(1, "Thomas Caron", "Legendaire");

        IList<Dragon> animals = new List<Dragon>
        {
            new Dragon(1,"Thomas Caron", "Legendaire"), new Dragon(2, "Thomas Boucry", "commun"), new Dragon(3, "Samuel", "rare")
        };
         
        //var execption = animals.Where(value => value.Rarity == "rare");
        //var queryAnimal = from animal in animals where animal.Rarity == "rare" select animal;
        *//*foreach (var animal in queryAnimal)
        {
            animal.printIdAndNameAndRarity(animal.Id, animal.Name, animal.Rarity);
        }*//*
            //foreach (var animal in execption) { animal.printIdAndNameAndRarity(animal.Id, animal.Name, animal.Rarity); }
            // foreach(var animal in animals) { animal.printIdAndNameAndRarity(animal.Id, animal.Name, animal.Rarity); }

            *//*animal.printIdAndNameAndRarity(1, "Thomas Boucry", "commun");
            animal.printIdAndNameAndRarity(1, "Thomas Caron", "epique");
            animal.printIdAndNameAndRarity(1, "Samuel", "rare");*/

            /*Vehicule vehicule = new();
            vehicule.move("Voiture");*//*

        Chiens chiens= new();
        string[]listChiens = { "Snow", "Thomas Caron", "Thomas Boucry", "Camille", "Samuel", "Noé", "Dylan" };
        chiens.printChiens(listChiens);

        //IList<Dragon> dragons = new List<Dragon>
        IFly dragon = new Dragon(20, "Nicoulah", "Unique");
        dragon.fly();

        IFly bird = new Bird(20, "oiseau", "Unique");
        bird.fly();

        IFly aigle = new Aigle(20, "aigle", "Unique");
        aigle.fly();*/

        ///////////////////////////////////////////////////////////////////////////////////////////////////

        Console.Write("Entrez le nom de l'animal : ");
        string name = Console.ReadLine();

        Console.Write("Entrez la rareté de l'animal : ");
        string rarity = Console.ReadLine();

        Console.Write("Entrez le type de l'animal : ");
        string type = Console.ReadLine();
        //string verifiedType = (Dragon)type;

        BDD bdd = new BDD(name, rarity, type);
        bdd.ConnectionDataBase();

        Console.ReadLine();
    }
}