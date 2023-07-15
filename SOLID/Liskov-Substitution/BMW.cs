namespace Liskov_Substitution
{
    public class BMW : Auto
    {
        public string BMWFeature { get; set; }
        public string Check { get; set; }

        public override void GetInfo()
        {
            Console.WriteLine($"This is Audi. His price is {Price} and it's a model - {Model}. It has a {BMWFeature}. It has {Check}");
        }
    }
}
