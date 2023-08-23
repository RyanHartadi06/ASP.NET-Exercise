using Microsoft.EntityFrameworkCore;

namespace Exercise_2.Data
{
    public class AppDbContext:DbContext
    {

        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }
    }
}
