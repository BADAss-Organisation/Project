using System.ComponentModel.DataAnnotations;

namespace WannaBuy.Models.Domain
{
    public class Order
    {
        [Key]
        public int Id { get; set; }
        public int User_Id { get; set; }
        public User User { get; set; }
        [Required]
        public string DeliveryLocation { get; set; }
        [Required]
        public DateTime DateOfOrder { get; set; }
        [Required]
        public decimal Price { get; set; }
    }
}
