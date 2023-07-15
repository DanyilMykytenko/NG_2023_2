namespace Open_Closed
{
    public class Audi : Auto
    {
        public string AudiFeature { get; set; }

        public override void GetInfo()
        {
            Console.WriteLine($"Model: {Model}. Price: {Price}. It has {AudiFeature}");
        }
    }
}
