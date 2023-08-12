using DataAccessLayer.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccessLayer.EntitiesConfiguration
{
    public class ClownConfiguration : IEntityTypeConfiguration<Clown>
    {
        public void Configure(EntityTypeBuilder<Clown> builder)
        {
            builder.HasKey(x => x.Id);

            builder.Property(x => x.Name).IsRequired();
            builder.Property(x => x.Salary).IsRequired(false);


            builder
                .HasOne(x => x.Toolbox)
                .WithOne(x => x.Clown)
                .HasForeignKey<Toolbox>(x => x.ClownId)
                .HasPrincipalKey<Clown>(x => x.Id)
                .OnDelete(DeleteBehavior.SetNull);
        }
    }
}
