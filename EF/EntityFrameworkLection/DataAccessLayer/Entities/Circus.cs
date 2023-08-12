namespace DataAccessLayer.Entities
{
    public class Circus : BaseEntity
    {
        public string Name { get; set; }
        public string Location { get; set; }

        public virtual ICollection<Clown?> Clowns { get; set; }
        public virtual ICollection<Owner?> Owners { get; set; }
    }
}
