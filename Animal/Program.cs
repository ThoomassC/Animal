using System.Text;
using Animal.AnimalClasses;

class Program
{
    static void Main(string[] args)
    {
        Console.OutputEncoding = Encoding.UTF8;

        AnimalMooveSleep animal = new();

        animal.Moove("Chien");
        animal.Sleep("Chien");
        Console.ReadLine();
    }
}