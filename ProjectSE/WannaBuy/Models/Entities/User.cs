using static System.Net.Mime.MediaTypeNames;
using System.ComponentModel.DataAnnotations;

namespace WannaBuy.Models.Entities
{
    public class User
    {
        [Key]
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public ICollection<Application> Applications { get; set; } = new List<Application>();
        public ICollection<Order> Orders { get; set; } = new List<Order>();
    }
}
