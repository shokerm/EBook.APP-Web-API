using EBook.API.Data;
using EBook.API.Data.Entities;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;


namespace StoreApp.API.Data.Configurations
{
    public class UserConfigurations : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            var hasher = new PasswordHasher<IdentityUser>();
            builder.HasData(
                 new User
                 {
                     Id = "8e445865-a24d-4543-a6c6-9443d048cdb9",
                     UserName = "Admin",
                     NormalizedUserName = "ADMIN",
                     Email = "admin@email.com",
                     NormalizedEmail = "ADMIN@EMAIL.COM",
                     PasswordHash = hasher.HashPassword(null, "123!Qaz123"),
                     EmailConfirmed = true,
                     AuthLevel = AuthLevels.Admin,
                     SecurityStamp = Guid.NewGuid().ToString("D")
                 },
                 new User
                 {
                     Id = "59f65e3a-706c-4056-a0bc-c4597e08599e",
                     UserName = "Yoni",
                     NormalizedUserName = "YONI",
                     Email = "yoni@email.com",
                     NormalizedEmail = "YONI@EMAIL.COM",
                     PasswordHash = hasher.HashPassword(null, "123!Qaz123"),
                     EmailConfirmed = true,
                     AuthLevel = AuthLevels.User,
                     SecurityStamp = Guid.NewGuid().ToString("D")

                 }
             );
        }
    }
}
