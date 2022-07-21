using Microsoft.EntityFrameworkCore;
using PFMBackend.Data.Entities;

namespace PFMBackend.Data.Configuration
{
    public class CategoryConfiguration : IEntityTypeConfiguration<CategoryEntity>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<CategoryEntity> builder)
        {
            builder.ToTable("categories");

            builder.HasKey(x => x.code);
            builder.Property(x => x.code).IsRequired();
            builder.Property(x => x.ParentCode);
            builder.Property(x => x.name).IsRequired();
        }
    }
}
