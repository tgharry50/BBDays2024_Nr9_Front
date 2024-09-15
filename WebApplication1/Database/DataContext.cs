using Microsoft.EntityFrameworkCore;
using Microsoft.Identity.Client;
using WebApplication1.Models;

namespace WebApplication1.Database
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<MedkitModel>().HasKey(nameof(MedkitModel.id));
            modelBuilder.Entity<RegisterModel>().HasKey(nameof (RegisterModel.id));
        }
        public DbSet<MedkitModel> Medkit { get; set; }
        public DbSet<RegisterModel> Users { get; set; }
    }
}
