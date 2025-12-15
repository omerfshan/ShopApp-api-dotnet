using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using shopapp.entity;

namespace shopapp.data.Configurations
{
    public class ProductConfiguration : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.HasKey(m=>m.ProductId);

            builder.Property(m=>m.Name).IsRequired().HasMaxLength(100);

            // Sqlite için tarih varsayılan değeri
            builder.Property(m=>m.DateAdded).HasDefaultValueSql ("date('now')");   // sqlite            
        }
    }
}