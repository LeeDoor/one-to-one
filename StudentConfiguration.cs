using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace one_to_one
{
    internal class StudentConfiguration : IEntityTypeConfiguration<Student>
    {
        public void Configure(EntityTypeBuilder<Student> builder)
        {
            builder.HasKey(n => n.Id);
            builder.Property(n => n.FirstName).HasMaxLength(20);
            builder.Property(n => n.LastName).HasMaxLength(20);
            builder.HasOne(n => n.Card).WithOne(n => n.Student).HasForeignKey<Student>(n => n.CardId);
        }
    }
}
