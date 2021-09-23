using Microsoft.EntityFrameworkCore;
using MyCourseManager1.Models;

namespace MyCourseManager1.Repositories
{
    public class MyCourseManagerDbContext : DbContext
    {
        public MyCourseManagerDbContext(DbContextOptions<MyCourseManagerDbContext> options)
            : base(options)
        {

        }

        public DbSet<Category> Categories { get; set; }
    }
}
