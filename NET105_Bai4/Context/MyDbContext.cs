using Microsoft.EntityFrameworkCore;
using NET105_Bai4.Models;

namespace NET105_Bai4.Context
{
    public class MyDbContext : DbContext
    {
        public MyDbContext()
        {
            
        }

        public MyDbContext(DbContextOptions<MyDbContext> options) : base(options)
        {
            
        }

        public DbSet<Student> Students { get; set; }
        public DbSet<Classes> Classes { get; set; }
    }
}
