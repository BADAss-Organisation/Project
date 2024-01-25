using System.ComponentModel.DataAnnotations;

namespace WannaBuy.Models.Entities
{
    public class Order
    {
        [Key]
        public int Id { get; set; }
        public int UserId { get; set; }
        public User User { get; set; }
        public int ProductId { get; set; }
        public Product Product { get; set; }
        public DateTime DateOfOrder { get; set; }
        public string DeliveryLocation { get; set; }
        public DateTime DeliveryDate { get; set; }
        public decimal Price { get; set; }
    }
}
