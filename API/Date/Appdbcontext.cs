using API.Models;
using Microsoft.EntityFrameworkCore;

namespace API.Date
{
    public class Appdbcontext : DbContext
    {
        public Appdbcontext(DbContextOptions options) : base(options)
        {
        }
        public DbSet<Prodect> Prodects { get; set; }
        public DbSet<Card> Cards { get; set; }
        public DbSet<Users> Users { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Users>().HasData(
            new Users
            {
                Id = 1,
                FristName = "John",
                LastName = "Doe",
                Age = 30,
                Email = "john.doe@example.com",
                Password = "Strong@123",
                Phone = "123-456-7890",
                Location = "New York"
            },
            new Users
            {
                Id = 2,
                FristName = "Jane",
                LastName = "Smith",
                Age = 25,
                Email = "jane.smith@example.com",
                Password = "Secure@456",
                Phone = "987-654-3210",
                Location = "Los Angeles"
            });
        }
    }
}
