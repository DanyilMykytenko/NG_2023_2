namespace DataAccessLayer.Entities
{
    public class Toolbox : BaseEntity
    {
        public string Name { get; set; }
        public string Description { get; set; }

        public Guid? ClownId { get; set; }

        public virtual Clown? Clown { get; set; }
    }
}
