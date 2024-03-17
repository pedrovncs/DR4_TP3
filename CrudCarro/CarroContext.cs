using Microsoft.EntityFrameworkCore;
using CrudCarro.Models;
using CrudCarro.Mapping;


namespace CrudCarro
{
    public class CarroContext : DbContext
    {
      public DbSet<Carro> Carros { get; set; }

        public CarroContext(DbContextOptions<CarroContext> options) 
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new CarroMapping());

            base.OnModelCreating(modelBuilder);
        }
    }
}
