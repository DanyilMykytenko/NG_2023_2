namespace DataAccessLayer.Entities
{
    public class Owner
    {
        public string Name { get; set; }
        public string Contacts { get; set; }

        public virtual ICollection<Circus?> Circuses { get; set; }
    }
}
