namespace RepoUofExample.DAL.Entities;

public class Recipe : BaseEntity
{
    public string Name { get; set; }
    public string Description { get; set; }
    public float Rating { get; set; }

    public Guid? AuthorId { get; set; }

    public virtual ICollection<Tag> Tags { get; set; }
    public virtual Author Author { get; set; }
}