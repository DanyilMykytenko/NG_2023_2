using DataAccessLayer.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccessLayer.EntitiesConfiguration
{
    public class ToolboxConfiguration : IEntityTypeConfiguration<Toolbox>
    {
        public void Configure(EntityTypeBuilder<Toolbox> builder)
        {
            builder.Property(x => x.Name).IsRequired();


        }
    }
}
