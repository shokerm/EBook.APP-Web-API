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
                    Id= 1,
                    ImageUrl= "../../../../assets//Images/store-images/javascript-book.jpg",
                    ImageAlt= "javascript-book",
                    Name= "JavaScript",
                    Price= 99.90,
                  },
                  new Item
                  {
                    Id= 2,
                    ImageUrl= "../../../../assets//Images/store-images/entity-framework-book.jpg",
                    ImageAlt= "entity-framework-book",
                    Name= "Entity Framework",
                    Price= 79.90,
     
                  },
                  new Item
                  {
                    Id= 3,
                    ImageUrl= "../../../../assets//Images/store-images/jquery-book.jpg",
                    ImageAlt= "jQuery",
                    Name= "jQuery",
                    Price= 59.90,
                  },
                  new Item
                  {
                    Id= 4,
                    ImageUrl= "../../../../assets//Images/store-images/powershell-book.jpg",
                    ImageAlt= "Powershell",
                    Name= "Powershell",
                    Price= 49.90,
                  },
                  new Item
                  {
                    Id= 5,
                    ImageUrl= "../../../../assets//Images/store-images/reactjs-book.jpg",
                    ImageAlt= "ReactJS",
                    Name= "ReactJS",
                    Price= 299.90,
                  },
                  new Item
                  {
                    Id= 6,
                    ImageUrl= "../../../../assets//Images/store-images/git-book.jpg",
                    ImageAlt= "Git",
                    Name= "Git",
                    Price= 99.90,
                  },
                  new Item
                  {
                     Id= 7,
                     ImageUrl= "../../../../assets//Images/store-images/ruby-on-rails-book.jpg",
                     ImageAlt= "Ruby on Rails",
                     Name= "Ruby on Rails",
                     Price= 99.90,
                  },
                  new Item
                  {
                     Id= 8,
                     ImageUrl= "../../../../assets//Images/store-images/oracle-database-book.jpg",
                     ImageAlt= "Oracle Database",
                     Name= "Oracle Database",
                     Price= 99.90,
                  },
                  new Item
                  {
                     Id= 9,
                     ImageUrl= "../../../../assets//Images/store-images/ios-developer-book.jpg",
                     ImageAlt= "image-3",
                     Name= "IOS Developer ",
                     Price= 149.90,
                  },
                  new Item
                  {
                     Id= 10,
                     ImageUrl= "../../../../assets//Images/store-images/visual-basic-dotnet-book.jpg",
                     ImageAlt= "Visual Basic .NET",
                     Name= "Visual Basic .NET",
                     Price= 49.90,
                   }
                );
        }
    }
}
