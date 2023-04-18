namespace Animal.Models
{
    public class Griffin : AnimalMooveSleep
    {
        public Griffin() { }

        public override void Move(string name)
        {
            Console.WriteLine($"{name} bouge ! (fonction override Griffin)");
        }

        public new void Sleep(string name)
        {
            Console.WriteLine($"{name} dort ! (fonction new Griffin)");
        }
    }
}
