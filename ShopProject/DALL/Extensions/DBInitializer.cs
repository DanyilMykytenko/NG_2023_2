using DAL.Context;

namespace DAL.Extensions
{
    public class DBInitializer
    {
        public static void Initialize(DBContext context)
        {
            context.Database.EnsureCreated();
        }
    }
}
