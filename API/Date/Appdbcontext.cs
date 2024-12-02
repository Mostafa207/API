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
    }
}
