using Microsoft.AspNetCore.Identity;

namespace EBook.API.Data.Entities
{
    public class User : IdentityUser
    { 


        public AuthLevels AuthLevel { get; set; }

    }
}
