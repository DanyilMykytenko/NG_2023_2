namespace Liskov_Substitution
{
    public class Auto
    {
        public string Model { get; set; }
        public decimal Price { get; set; }

        public virtual void GetInfo()
        {
            Console.WriteLine($"Model: {Model}. Price: {Price}");
        }
    }
}

// LISKOV SUBSTITUTION
// ALL PARENT CLASSESS MAY BE REPLACABLE BY CHILD CLASSES