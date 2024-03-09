using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using UdemyCleanArchitecture.Domain.Entities;

namespace UdemyCleanArchitecture.Persistance.Configurations;
public sealed class ModelConfiguration : IEntityTypeConfiguration<Model>
{
    public void Configure(EntityTypeBuilder<Model> builder)
    {
        builder.ToTable("Models");
        builder.HasKey(m => m.Id);
    }
}
