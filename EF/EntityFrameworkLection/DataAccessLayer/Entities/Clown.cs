namespace DataAccessLayer.Entities
{
    public class Clown : BaseEntity
    {
        public string Name { get; set; }
        public decimal Salary { get; set; }

        public Guid? CircusId { get; set; }

        public virtual Toolbox? Toolbox { get; set; }
        public virtual Circus? Circus { get; set; }
    }
}
