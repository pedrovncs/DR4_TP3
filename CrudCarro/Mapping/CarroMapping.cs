using CrudCarro.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CrudCarro.Mapping
{
    public class CarroMapping : IEntityTypeConfiguration<Carro>
    {
        public void Configure(EntityTypeBuilder<Carro> builder)
        {
            builder.HasKey(c => c.Id);
            builder.Property(c => c.Id).ValueGeneratedOnAdd();

            builder.Property(c => c.Marca).IsRequired().HasMaxLength(20);
            builder.Property(c => c.Modelo).IsRequired().HasMaxLength(20);
            builder.Property(c => c.Ano).IsRequired();
            builder.Property(c => c.Cor).IsRequired().HasMaxLength(20);
            builder.Property(c => c.Preco).IsRequired(); 
        }
    }
}
