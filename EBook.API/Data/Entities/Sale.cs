using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EBook.API.Data.Entities
{
    public class Sale
    {
        [Key]
        public int Id { get; set; }
        
        [ForeignKey(nameof(UserId))]
        public virtual User User { get; set; }

        public int UserId { get; set; }

        [ForeignKey(nameof(ItemId))]
        public virtual Item Item { get; set; }
        public int ItemId { get; set; }


        public DateTime SaleDate { get; set; }

        public int Quantity { get; set; }



    }
}
