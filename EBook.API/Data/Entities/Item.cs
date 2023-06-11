﻿namespace EBook.API.Data.Entities
{
    public class Item
    {

        public int Id { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public string ImageUrl { get; set; }
        public string ImageAlt { get; set; }
        public int Quantity { get; set; }
        public string LikeToggleStatus { get; set; }



       
    }
}
