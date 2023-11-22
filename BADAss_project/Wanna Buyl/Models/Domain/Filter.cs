using System.ComponentModel.DataAnnotations;

namespace Wanna_Buyl.Models.Domain
{
    public class Filter
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        public bool PriceAscending { get; set; }
        public bool PriceDescending { get; set; }
        public string PriceRange { get; set; }
        public ICollection<Application> Applications { get; set; } = new List<Application>();
    }
}
