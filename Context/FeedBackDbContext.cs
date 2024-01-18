using LOGINWEBAPI.models;
using Microsoft.EntityFrameworkCore;

namespace LOGINWEBAPI.Context{
    
    public class FeedBackDbContext:DbContext{

       
        public FeedBackDbContext(DbContextOptions<FeedBackDbContext> options) : base(options)
        {
        }

        public DbSet<FeedBack>feedBacks{get;set;}

        protected override void OnModelCreating(ModelBuilder modelBuilder){

            modelBuilder.Entity<FeedBack>().ToTable("feedBacks");
        }

    }

}