﻿using System.ComponentModel.DataAnnotations;

namespace WannaBuy.Models.Domain
{
    public class Category
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        public ICollection<Product> Products { get; set; } = new List<Product>();
    }
}
