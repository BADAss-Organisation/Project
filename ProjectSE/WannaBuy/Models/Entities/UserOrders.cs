using WannaBuy.Models.Account;

namespace WannaBuy.Models.Entities
{
    public class UserOrders
    {
        public Guid OrderId { get; set; }
        public Order Order { get; set; }
        public string UserId { get; set; }
        public ApplicationUser User { get; set; }
    }
}
