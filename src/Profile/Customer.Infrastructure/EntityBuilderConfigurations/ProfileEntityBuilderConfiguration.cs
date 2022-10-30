using Customer.Domain.Entities;
using Customer.Domain.Enums;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Customer.Infrastructure.EntityBuilderConfigurations
{
    internal class ProfileEntityBuilderConfiguration : IEntityTypeConfiguration<Profile>
    {
        public void Configure(EntityTypeBuilder<Profile> builder)
        {
            builder.HasKey(p => p.Id);

            builder.Property(p => p.Status)
                .HasConversion(new EnumToStringConverter<ProfileStatus>());

            builder.Property(p => p.ModifiedOn)
                .HasDefaultValue(DateTime.UtcNow);
        }
    }
}
