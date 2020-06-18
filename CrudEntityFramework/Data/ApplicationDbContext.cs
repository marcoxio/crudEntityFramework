using CrudEntityFramework.Models;
using Microsoft.EntityFrameworkCore;

namespace CrudEntityFramework.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base (options)
        {

        }


        public DbSet<Usuario> Usuario {get; set;}
        
    }
}