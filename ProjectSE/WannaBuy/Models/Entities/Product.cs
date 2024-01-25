using static System.Net.Mime.MediaTypeNames;
using System.ComponentModel.DataAnnotations;
using WannaBuy.Models.Account;

namespace WannaBuy.Models.Entities
{
    public class Product
    {
        [Key]
        public Guid Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public string Description { get; set; }
        public decimal Amount { get; set; }
        public string Image { get; set; }
        public Guid CategoryId { get; set; }
        public Category Category { get; set; }
        public string UserId { get; set; }
        public ApplicationUser User { get; set; }
    }
}
