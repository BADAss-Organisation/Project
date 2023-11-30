using static System.Net.Mime.MediaTypeNames;
using System.ComponentModel.DataAnnotations;

namespace WannaBuy.Models.Entities
{
    public class Product
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public int CategoryId { get; set; }
        public Category Category { get; set; }
        public int Application_id { get; set; }
        public Application Application { get; set; }
    }
}
