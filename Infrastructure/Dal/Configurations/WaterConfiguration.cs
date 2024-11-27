using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Dal.Configurations;

public class WaterConfiguration : IEntityTypeConfiguration<Water>
{
    public void Configure(EntityTypeBuilder<Water> builder)
    {
        builder.HasKey(p => p.Id);

        builder.Property(p => p.Id)
            .HasColumnName("id");

        builder.Property(p => p.SpendAmount)
            .IsRequired()
            .HasColumnName("spend_amount");

        builder.Property(p => p.CheckDate)
            .IsRequired()
            .HasColumnName("check_date");
        
        builder.Property(p => p.PeopleAmount)
            .IsRequired()
            .HasColumnName("people_amount");
    }
}