using System.Text;
using Animal.Models;
using Animal.Interface;

class Program
{
    static void Main(string[] args)
    {
        Console.OutputEncoding = Encoding.UTF8;

        Griffin griffin= new();
        griffin.move("Griffin");
        griffin.sleep("Griffin");

        Dragon dragon = new();
        dragon.move("Dragon");
        dragon.sleep("Dragon");

        Vehicule vehicule = new();
        vehicule.move("Voiture");

        Console.ReadLine();
    }
}