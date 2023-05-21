namespace EBook.API.Data.Entities
{
    public class Item
    {

        public int Id { get; set; }
        public String Name { get; set; }
        public double Price { get; set; }
        public String ImageUrl { get; set; }
        public String ImageAlt { get; set; }

        public Item(int Id, string Name, double Price, string ImageUrl, string ImageAlt)
        {
            this.Id = Id;
            this.Name = Name;
            this.Price = Price;
            this.ImageUrl = ImageUrl;
            this.ImageAlt = ImageAlt;
        }
    }
}
