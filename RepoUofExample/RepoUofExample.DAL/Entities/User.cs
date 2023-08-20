namespace RepoUofExample.DAL.Entities;

public class User : BaseEntity
{
    public string UserName { get; set; }
    public string Email { get; set; }
    public string Password { get; set; }

    public virtual Author AuthorAccount { get; set; }
}