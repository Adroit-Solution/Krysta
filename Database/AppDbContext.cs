using Microsoft.EntityFrameworkCore;
using Test_Series.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Test_Series.Repository;

namespace Test_Series.Database
{
    public class AppDbContext : IdentityDbContext<AccountRepo>
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
            
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<ChildViewModel>().HasKey(p => new { p.SubjectId, p.ParentId });
        }

        public DbSet<SubjectViewModel> Subjects { get; set; }
        public DbSet<ParentViewModel> Schemes{ get; set; }
        public DbSet<ChildViewModel> Plans { get; set; }
    }
    
    
}
