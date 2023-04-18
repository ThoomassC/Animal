namespace Animal.Models
{
    public class Griffin : AnimalMooveSleep
    {
        public Griffin() { }

        public override void move(string name)
        {
            Console.WriteLine($"{name} bouge ! (fonction override Griffin)");
        }

        public new void sleep(string name)
        {
            Console.WriteLine($"{name} dort ! (fonction new Griffin)");
        }
    }
}
