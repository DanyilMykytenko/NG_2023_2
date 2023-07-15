namespace Open_Closed
{
    public class Auto
    {
        public string NEWFIELD { get; set; }
        public string Model { get; set; }
        public decimal Price { get; set; }

        public virtual void GetInfo()
        {
            Console.WriteLine($"Model: {Model}. Price: {Price}");
        }
    }
}

//  OPEN-CLOSED PRINCIPLE
// CODE SHOULD BE CLOSED FOR REFACTORING AND OPEN FOR IMPLEMENTING