using System.ComponentModel.DataAnnotations;

namespace WannaBuy.Models.Entities
{
    public class Order
    {
        [Key]
        public int Id { get; set; }
        public int User_Id { get; set; }
        public User User { get; set; }
        public string DeliveryLocation { get; set; }
        public DateTime DateOfOrder { get; set; }
        public decimal Price { get; set; }
    }
}
