using System.ComponentModel.DataAnnotations;

namespace SudiptoAPI.Models
{
    public class Menu
    {
        [Key]
        public int MenuId { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string Image { get; set; }
    }
}
