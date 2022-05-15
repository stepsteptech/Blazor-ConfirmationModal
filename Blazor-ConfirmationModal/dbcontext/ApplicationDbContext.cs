using Blazor_ConfirmationModal.Models;
using Microsoft.EntityFrameworkCore;

namespace Blazor_ConfirmationModal.dbcontext
{
    public class ApplicationDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) => optionsBuilder.UseSqlite(@"Data Source=database\Demo.db");
        public DbSet<Employee> employees { get; set; }
    }
}
