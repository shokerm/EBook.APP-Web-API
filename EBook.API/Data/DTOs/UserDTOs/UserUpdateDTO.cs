using Microsoft.AspNetCore.Authorization;
using System.ComponentModel.DataAnnotations;
using System.Data;

namespace EBook.API.Data.DTOs.UserDTOs
{
    public class UserUpdateDTO
    {
        //public string Id { get; set; }

        public string UserName { get; set; }
        public string Email { get; set; }

        public string Password { get; set; }

    }
}
