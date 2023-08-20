namespace RepoUofExample.DAL.Entities;

public class Author : BaseEntity
{
    public string Name { get; set; }
    public string Surname { get; set; }
    public string Description { get; set; }
    public string Speciality { get; set; }

    public Guid UserId { get; set; }

    public virtual User User { get; set; } 
    public virtual ICollection<Recipe> Recipes { get; set; }
}