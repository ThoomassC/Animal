using Animal.Interface;

namespace Animal.Models
{
    public class Dragon : AnimalMooveSleep, Pilotage 
    {
        public Dragon() { }

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
    }
}
