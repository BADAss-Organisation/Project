using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace WannaBuy.Models.Domain
{
    public class User : IdentityUser<int>
    {
        [Required]
        public string FirstName { get; set; }
        [Required]
        public string LastName { get; set; }
        [Required]
        public string Location { get; set; }
        [Required]
        public string PhoneNumber { get; set; }
        [Required]
        public int Age { get; set; }
        public ICollection<Application> Applications { get; set; } = new List<Application>();
        public ICollection<Order> Orders { get; set; } = new List<Order>();
    }
}
