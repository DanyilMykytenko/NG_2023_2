namespace Liskov_Substitution
{
    public class Program
    {
        void Main()
        {
            var array = new List<Auto>();

            var audi = new Audi
            {
                AudiFeature = "Incredible",
                Price = 1,
                Model = "MATIZ"
            };

            var bibika = new BMW
            {
                Price = 0,
                Model = "da",
                Check = "mnogo",
                BMWFeature = "aiwjreaiwwairjaiosrtjweiojtgeiowrjtgioekrwjtgeri"
            };

            array.Add(bibika);
            array.Add(audi);
        }
    }
}
