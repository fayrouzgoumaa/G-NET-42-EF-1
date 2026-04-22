using Microsoft.Identity.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
namespace G_NET_42_EF_1.Data
{
    internal class AppDbContext: DbContext
    {
        public DbSet<Book> Books { get; set; }
        public DbSet<Author> Authors{ get; set; }
        public DbSet <Category> Categories { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
            
        {
            optionsBuilder.UseSqlServer("Server=FAYROUZGOUMAA;Database=BookStore;Trusted_Connection=true;TrustServerCertificate=true");

        }
    }
}
