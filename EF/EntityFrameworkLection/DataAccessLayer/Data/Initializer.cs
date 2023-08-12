namespace DataAccessLayer.Data
{
    public class Initializer
    {
        public static void Initialize(CircusDatabaseContext context)
        {
            context.Database.EnsureCreated();
            //why do not migrate?
        }
    }
}
