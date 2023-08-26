namespace DAL.Entities
{
    public class User : BaseEntity
    {
        public string name { get; set; }
        public string? surname { get; set; }
        public string phone { get; set; }
        public string login { get; set; }
        public string password { get; set; }
        public virtual ICollection<Order>? Orders { get; set; } = new HashSet<Order>();
    }
}
