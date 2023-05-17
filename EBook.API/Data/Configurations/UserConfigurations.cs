using EBook.API.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EBook.API.Data.Configurations
{
    public class UserConfigurations : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.HasData(
                new User
                {
                    Id = 1,
                    Name = "User 1",
                    Email = "user1@gmail.com",
                    Password = "User1234",
                    AuthLevel = AuthLevel.User

                },
                new User
                {
                    Id = 2,
                    Name = "User 2",
                    Email = "user2@gmail.com",
                    Password = "User4321",
                    AuthLevel = AuthLevel.User

                },
                  new User
                  {
                      Id = 3,
                      Name = "User 3",
                      Email = "user3@gmail.com",
                      Password = "User35678",
                      AuthLevel = AuthLevel.User

                  }

                );
        }
    }
}
