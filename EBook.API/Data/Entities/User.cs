namespace EBook.API.Data.Entities
{
    public class User
    {

        public int Id { get; set; }
        public String Name { get; set; }

        public String Email { get; set; }

        public String Password { get; set; }

        public AuthLevel AuthLevel { get; set; }

    }
}
