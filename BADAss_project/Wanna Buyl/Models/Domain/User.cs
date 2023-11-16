using System.ComponentModel.DataAnnotations;

namespace Wanna_Buyl.Models.Domain
{
    public class User
    {
        [Key]
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Location { get; set; }
        public HashSet<string> Password { get; set; }
        public string PhoneNumber { get; set; }
        public int Age { get; set; }
    }
}
