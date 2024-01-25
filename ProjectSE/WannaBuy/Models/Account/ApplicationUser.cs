using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;
using WannaBuy.Models.Entities;

namespace WannaBuy.Models.Account
{
    public class ApplicationUser : IdentityUser
    {
        [StringLength(20)]
        public string? FirstName { get; set; }
        [StringLength(20)]
        public string? LastName { get; set; }
        public string? Location { get; set; }
        public ICollection<Product> Products { get; set; } = new List<Product>();
        public ICollection<UserOrders> UserOrders { get; set; } = new List<UserOrders>();
    }
}
