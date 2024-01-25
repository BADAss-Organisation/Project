using System.ComponentModel.DataAnnotations;
using WannaBuy.Models.Account;

namespace WannaBuy.Models.Entities
{
    public class Order
    {
        [Key]
        public Guid Id { get; set; }
        public DateTime DateOfOrder { get; set; }
        public string DeliveryLocation { get; set; }
        public DateTime DeliveryDate { get; set; }
        public decimal Price { get; set; }
        public ICollection<UserOrders> UserOrders { get; set; } = new List<UserOrders>();
    }
}
