using EBook.API.Data.Configurations;
using EBook.API.Data.Entities;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using StoreApp.API.Data.Configurations;
using System.Reflection.Emit;

namespace EBook.API.Data
{
    public class StoreDBContext : IdentityDbContext<User>
    {


        public DbSet<User>Users { get; set; }
        public DbSet<Item> Items { get; set; }
        public DbSet<Sale> Sales { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder buillder)
        {
            base.OnConfiguring(buillder);
            buillder.UseSqlServer("Server=MOSHE-DELL-PC;Database=EBookDB;Trusted_Connection = True;TrustServerCertificate= True;");
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            builder.ApplyConfiguration(new UserConfigurations());
            builder.ApplyConfiguration(new RoleConfugurations());
            builder.ApplyConfiguration(new UserRoleConfigurations());
            builder.ApplyConfiguration(new ItemConfigurations());
        }
    }
}
