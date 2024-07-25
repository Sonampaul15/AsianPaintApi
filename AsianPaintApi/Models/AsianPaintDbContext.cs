using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace AsianPaintApi.Models
{
    public class AsianPaintDbContext:IdentityDbContext<ApplicationUser>
    {
        public AsianPaintDbContext(DbContextOptions<AsianPaintDbContext> options):base(options)
        {
            
        }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
        }
        public DbSet<AsianPaint> AsianPaints { get; set; }

        public DbSet<ApplicationUser> users { get; set; }
    }
}
