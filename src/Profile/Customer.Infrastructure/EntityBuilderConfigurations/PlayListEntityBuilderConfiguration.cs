using Customer.Domain.Entities;
using Customer.Domain.Enums;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Customer.Infrastructure.EntityBuilderConfigurations
{
    internal class PlayListEntityBuilderConfiguration : IEntityTypeConfiguration<PlayList>
    {
        public void Configure(EntityTypeBuilder<PlayList> builder)
        {
            builder.HasKey(p => p.Id);

            builder.Property(p => p.Status)
                .HasConversion(new EnumToStringConverter<PlayListStatus>());
        }
    }
}
