using Microsoft.AspNetCore.Mvc.RazorPages.Infrastructure;
using System.ComponentModel.DataAnnotations;

namespace Wanna_Buyl.Models.Domain
{
    public class Comment
    {
        [Key]
        public int Id { get; set; }
        public string CommentText { get; set; }
        public int Application_id { get; set; }
        public Application Application { get; set; }
    }
}
