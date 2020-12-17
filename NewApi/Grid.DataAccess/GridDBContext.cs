using Microsoft.EntityFrameworkCore;
using Grid.Common;
using Grid.Model;
using Grid.Model.Entities;
namespace Grid.DataAccess
{
    public class GridDBContext : DbContext
    {
        
        public GridDBContext(DbContextOptions<GridDBContext> opts): base(opts)
        {}

        public DbSet<Movie> Movies { get; set; }
        public DbSet<Customer> Customers { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //optionsBuilder.UseSqlServer("Server=(localdb)\\MSSQLLocalDB;Initial Catalog=DBName;Integrated Security=True");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder){
             
             modelBuilder.Entity<Movie>().ToTable("Movies");

        }
    }
}