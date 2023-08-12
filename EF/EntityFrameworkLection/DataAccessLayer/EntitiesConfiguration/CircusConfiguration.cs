using DataAccessLayer.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccessLayer.EntitiesConfiguration
{
    public class CircusConfiguration : IEntityTypeConfiguration<Circus>
    {
        public void Configure(EntityTypeBuilder<Circus> builder)
        {
            builder.HasKey(x => x.Id);

            builder.Property(x => x.Name).IsRequired().HasMaxLength(50);
            builder.Property(x => x.Location).IsRequired(false);

            builder.HasIndex(x => x.Name).IsUnique();

            builder
                .HasMany(x => x.Clowns)
                .WithOne(x => x.Circus)
                .HasForeignKey(x => x.CircusId)
                .HasPrincipalKey(x => x.Id)
                .OnDelete(DeleteBehavior.Cascade);

            builder
                .HasMany(x => x.Owners)
                .WithMany(x => x.Circuses);
        }
    }
}
