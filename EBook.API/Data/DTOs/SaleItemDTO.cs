using MessagePack;

namespace EBook.API.Data.DTOs
{
    public class SaleItemDTO
    {
        public int Id { get; set; }

        public string Product { get; set; }
        public int ItemId { get; set; }
        public string UserId { get; set; }

        public int Quantity { get; set; }

        public DateTime SaleDate { get; set; }






    }
}
