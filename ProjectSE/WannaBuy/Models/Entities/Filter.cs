using static System.Net.Mime.MediaTypeNames;
using System.ComponentModel.DataAnnotations;

namespace WannaBuy.Models.Entities
{
    public class Filter
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public ICollection<Application> Applications { get; set; } = new List<Application>();
    }
}
