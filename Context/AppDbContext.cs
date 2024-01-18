using LOGINWEBAPI.models;
using Microsoft.EntityFrameworkCore;

namespace LOGINWEBAPI.Context{
    public class AppDbContext:FoodDonateDbContext{
        public AppDbContext(DbContextOptions<FoodDonateDbContext> options) : base(options)
        {
        }

        public DbSet<user>users{get;set;}

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<user>().ToTable("users");
        }
    }
}