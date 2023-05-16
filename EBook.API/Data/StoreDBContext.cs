using EBook.API.Data.Configurations;
using EBook.API.Data.Entities;
using Microsoft.EntityFrameworkCore;

namespace EBook.API.Data
{
    public class StoreDBContext: DbContext
    {
        public DbSet<User>Users { get; set; }
        public DbSet<Item> Items { get; set; }
        public DbSet<Sale> Sales { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder buillder)
        {
            base.OnConfiguring(buillder);
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            builder.ApplyConfiguration(new UserConfigurations());
            builder.ApplyConfiguration(new ItemConfigurations());
        }
    }
}
