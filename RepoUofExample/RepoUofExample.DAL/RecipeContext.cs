using Microsoft.EntityFrameworkCore;
using RepoUofExample.DAL.Configurations;
using RepoUofExample.DAL.Entities;

namespace RepoUofExample.DAL;

public class RecipeContext : DbContext
{
    public RecipeContext()
    {
    }

    public RecipeContext(DbContextOptions<RecipeContext> options)
        : base(options)
    {
    }

    public DbSet<User> Users { get; set; }
    public DbSet<Author> Authors { get; set; }
    public DbSet<Recipe> Recipes { get; set; }
    public DbSet<Tag> Tags { get; set; }
    
    protected override void OnModelCreating(ModelBuilder builder)
    {
        builder.ApplyConfiguration(new AuthorConfiguration());
    }
}