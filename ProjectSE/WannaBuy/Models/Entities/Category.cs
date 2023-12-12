using System.ComponentModel.DataAnnotations;

namespace WannaBuy.Models.Entities
{
    public class Category
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string PriceRange { get; set; }
        public ICollection<Product> Products { get; set; } = new List<Product>();
    }
}
