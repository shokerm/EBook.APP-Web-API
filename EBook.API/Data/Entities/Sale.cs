using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EBook.API.Data.Entities
{
    public class Sale
    {
        [Key]
        public int Id { get; set; }
        

        public string UserId { get; set; }

        public int ItemId { get; set; }
   


        public DateTime SaleDate { get; set; }

        public int Quantity { get; set; }



    }
}
