using EBook.API.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EBook.API.Data.Configurations
{
    public class ItemConfigurations : IEntityTypeConfiguration<Item>
    {
        public void Configure(EntityTypeBuilder<Item> builder)
        {
            builder.HasData(
                new Item
                {
                   Id = 1,
                   Name = "JavaScript",
                   Price = 99.90


                },
                  new Item
                  {
                      Id = 2,
                      Name = "ASP.NET",
                      Price = 99.90


                  }




                );
        }
    }
}
