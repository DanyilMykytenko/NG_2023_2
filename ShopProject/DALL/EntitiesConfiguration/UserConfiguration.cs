using DAL.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DAL.EntitiesConfiguration
{
    public class UserConfiguration : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(u => u.Id)
                .IsRequired().ValueGeneratedOnAdd();
            builder
                .HasMany(u => u.Orders)
                .WithOne(u => u.User)
                .HasPrincipalKey(u => u.Id)
                .HasForeignKey(u => u.CustomerID);
        }
    }
}
