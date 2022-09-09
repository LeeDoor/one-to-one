using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace one_to_one
{
    public class CardConfiguration : IEntityTypeConfiguration<Card>
    {
        public void Configure(EntityTypeBuilder<Card> builder)
        {
            builder.HasKey(n => n.Id);
            builder.HasAlternateKey(n => n.SerialNumber);
            builder.Property(n => n.SerialNumber).IsRequired();
        }
    }
}
