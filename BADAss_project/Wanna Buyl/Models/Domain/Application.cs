using System.ComponentModel.DataAnnotations;

namespace Wanna_Buyl.Models.Domain
{
    public class Application
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Amount { get; set; }
        public byte[] Image { get; set; }
        public Product Product { get; set; }
        public int Filter_id { get; set; }
        public Filter Filter { get; set; }
        public int User_Id { get; set; }
        public User User { get; set; }
        public ICollection<Comment> Comments { get; set; } = new List<Comment>();
    }
}
