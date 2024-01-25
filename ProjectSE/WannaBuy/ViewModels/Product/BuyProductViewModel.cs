using WannaBuy.Models.Entities;

namespace WannaBuy.ViewModels.Product
{
    public class BuyProductViewModel
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public string Description { get; set; }
        public decimal Amount { get; set; }
        public string Image { get; set; }
        public Guid CategoryId { get; set; }
        public string UserId { get; set; }
    }
}
