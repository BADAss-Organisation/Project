using System.ComponentModel.DataAnnotations;

namespace Wanna_Buyl.Models.Domain
{
    public class Filter
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public bool PriceAscending { get; set; }
        public bool PriceDescending { get; set; }
        public string PriceRange { get; set; }
    }
}
