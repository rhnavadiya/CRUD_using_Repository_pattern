using CRUD_using_Repository_pattern.Models;
using Microsoft.EntityFrameworkCore;

namespace CRUD_using_Repository_pattern.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> option) : base(option)
        {
            
        }

        public DbSet<User> Users { get; set; }
    }
}
