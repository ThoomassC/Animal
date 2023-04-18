namespace Animal.Models
{
    public class Dragon : AnimalMooveSleep
    {
        public Dragon() { }

        public override void Move(string name)
        {
            Console.WriteLine($"{name} bouge ! (fonction override Dragon)");
        }

        public new void Sleep(string name)
        {
            Console.WriteLine($"{name} dort ! (fonction new Dragon)");
        }
    }
}
