using System.Text;
using Animal.Models;

class Program
{
    static void Main(string[] args)
    {
        Console.OutputEncoding = Encoding.UTF8;

        Griffin griffin= new();
        griffin.Move("Griffin");
        griffin.Sleep("Griffin");

        Dragon dragon = new();
        dragon.Move("Dragon");
        dragon.Sleep("Dragon");

        Console.ReadLine();
    }
}