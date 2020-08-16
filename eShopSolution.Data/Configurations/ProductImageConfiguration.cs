using eShopSolution.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace eShopSolution.Data.Configurations
{
    public class ProductImageConfiguration : IEntityTypeConfiguration<ProductImage>
    {
        public void Configure(EntityTypeBuilder<ProductImage> builder)
        {
            builder.HasKey(t => t.Id);
            builder.ToTable("ProductImages");

            builder.Property(t => t.Id).UseIdentityColumn();
            builder.Property(t => t.ImagePath).HasMaxLength(200).IsRequired(true);
            builder.Property(t => t.Caption).HasMaxLength(200);

            builder.HasOne(t => t.Product).WithMany(pc => pc.ProductImages).HasForeignKey(pc => pc.ProductId);
        }
    }
}
