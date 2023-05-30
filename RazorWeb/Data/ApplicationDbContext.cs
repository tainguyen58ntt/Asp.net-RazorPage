using Microsoft.EntityFrameworkCore;
using RazorWeb.Models;

namespace RazorWeb.Data
{
    public class ApplicationDbContext: DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }
        public DbSet<Category> Category { get; set; } 
    }
}
