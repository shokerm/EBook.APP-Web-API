using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace StoreApp.API.Data.Configurations
{
    public class UserRoleConfigurations : IEntityTypeConfiguration<IdentityUserRole<string>>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<IdentityUserRole<string>> builder)
        {
            builder.HasData(
                new IdentityUserRole<string>
                {
                    RoleId = "c32f66ed-c960-4cb7-a468-90662e1fb37a",
                    UserId = "8e445865-a24d-4543-a6c6-9443d048cdb9"
                },
                 new IdentityUserRole<string>
                 {
                     RoleId = "ddc1ddb9-2495-40d6-b278-633bc6ca29c6",
                     UserId = "59f65e3a-706c-4056-a0bc-c4597e08599e"
                 }
                );
        }
    }
}
