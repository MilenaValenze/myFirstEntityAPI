using Microsoft.EntityFrameworkCore;
using PrimeiraAPI.Model;

namespace PrimeiraAPI.Infraestrutura
{
    public class ConnectionContext : DbContext
    {
        public DbSet<Employee> Employees { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
            =>  optionsBuilder.UseNpgsql(
               "Server=localhost;"+
               "Database=minhaAPI;" +
               "Username=postgres;" + //ou user ID? min 4:50
               "Password=postgres;");
        
    }
}
