using System.ComponentModel.DataAnnotations;

namespace Wanna_Buyl.Models.Domain
{
    public class User
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string FirstName { get; set; }
        [Required]
        public string LastName { get; set; }
        [Required]
        public string Email { get; set; }
        [Required]
        public string Location { get; set; }
        [Required]
        public string Password { get; set; }
        [Required]
        public string PhoneNumber { get; set; }
        [Required]
        public int Age { get; set; }
        public ICollection<Application> Applications { get; set; } = new List<Application>();
        public ICollection<Order> Orders { get; set; } = new List<Order>();
    }
}
