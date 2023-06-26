using EBook.API.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EBook.API.Data.Configurations
{
    public class SalesConfigurations : IEntityTypeConfiguration<Sale>
    {
        public void Configure(EntityTypeBuilder<Sale> builder)
        {
            builder.HasData(

                new Sale()
                {
                    Id = 1,
                    ItemId = 1,
                    Quantity = 1,
                    UserId = "8e445865-a24d-4543-a6c6-9443d048cdb9",
                    SaleDate = DateTime.Now
                },
                new Sale()
                {
                    Id = 2,
                    ItemId = 2,
                    Quantity = 2,
                    UserId = "8e445865-a24d-4543-a6c6-9443d048cdb9",
                    SaleDate = DateTime.Now
                },
                new Sale()
                {
                    Id = 3,
                    ItemId = 3,
                    Quantity = 1,
                    UserId = "8e445865-a24d-4543-a6c6-9443d048cdb9",
                    SaleDate = DateTime.Now
                },
                new Sale()
                {
                    Id = 4,
                    ItemId = 4,
                    Quantity = 3,
                    UserId = "8e445865-a24d-4543-a6c6-9443d048cdb9",
                    SaleDate = DateTime.Now
                },
                new Sale()
                {
                    Id = 5,
                    ItemId = 5,
                    Quantity = 1,
                    UserId = "8e445865-a24d-4543-a6c6-9443d048cdb9",
                    SaleDate = DateTime.Now
                },
                new Sale()
                {
                    Id = 6,
                    ItemId = 6,
                    Quantity = 1,
                    UserId = "59f65e3a-706c-4056-a0bc-c4597e08599e",
                    SaleDate = DateTime.Now
                },
                new Sale()
                {
                    Id = 7,
                    ItemId = 7,
                    Quantity = 1,
                    UserId = "59f65e3a-706c-4056-a0bc-c4597e08599e",
                    SaleDate = DateTime.Now
                },
                new Sale()
                {
                    Id = 8,
                    ItemId = 8,
                    Quantity = 1,
                    UserId = "59f65e3a-706c-4056-a0bc-c4597e08599e",
                    SaleDate = DateTime.Now
                },
                 new Sale()
                 {
                     Id = 9,
                     ItemId = 9,
                     Quantity = 2,
                     UserId = "4a8a52b2-8c3d-45d2-9fe5-ff01895c5c29",
                     SaleDate = DateTime.Now
                 },
                  new Sale()
                  {
                      Id = 10,
                      ItemId = 10,
                      Quantity = 1,
                      UserId = "4a8a52b2-8c3d-45d2-9fe5-ff01895c5c29",
                      SaleDate = DateTime.Now
                  }
                );
        }
    }
}
