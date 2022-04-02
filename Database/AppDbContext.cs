using Microsoft.EntityFrameworkCore;

namespace Test_Series.Database
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
            
        }
    }
    
    
}
