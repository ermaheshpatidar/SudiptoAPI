using System.ComponentModel.DataAnnotations;
namespace SudiptoAPI.Models
{
    public class SubMenu
    {
        [Key]
        public int SubMenuId { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string Description { get; set; }
        [Required]
        public decimal Price { get; set; }
        [Required]
        public string Image { get; set; }
        
    }
}
