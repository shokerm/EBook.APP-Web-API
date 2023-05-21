using Microsoft.AspNetCore.Identity;

namespace EBook.API.Data.Entities
{
    public class User : IdentityUser
    { 

        public String Password { get; set; }

        public AuthLevels AuthLevel { get; set; }

    }
}
