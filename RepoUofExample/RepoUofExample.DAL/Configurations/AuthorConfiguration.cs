using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RepoUofExample.DAL.Entities;

namespace RepoUofExample.DAL.Configurations;

public class AuthorConfiguration : IEntityTypeConfiguration<Author>
{
    public void Configure(EntityTypeBuilder<Author> builder)
    {
        builder
            .HasOne(x => x.User)
            .WithOne(y => y.AuthorAccount)
            .HasForeignKey<Author>(x => x.UserId)
            .OnDelete(DeleteBehavior.Cascade);

        builder
            .HasMany(x => x.Recipes)
            .WithOne(y => y.Author)
            .HasForeignKey(x => x.AuthorId).IsRequired(false)
            .HasPrincipalKey(y => y.Id)
            .OnDelete(DeleteBehavior.Cascade);
    }
}