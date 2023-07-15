using Interface_Segregation.Interfaces;

namespace Interface_Segregation.Classes
{
    public class Triangle : ITriangle
    {
        public void DrawTriangle()
        {
            Console.WriteLine("triangle.");
        }

        public void OneMoreMethodWeNeed()
        {
            Console.WriteLine($"Now we have it. {CalcucateSomething()}");
        }

        private int CalcucateSomething()
        {
            return 1 + 1;
        }
    }
}
