using System.ComponentModel.DataAnnotations;
namespace SudiptoAPI.Models
{
    public class Reservation
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string Email { get; set; }
        [Required]

        public string Phone { get; set; }
        [Required]
        public Int32 TotalPeople { get; set; }
        [Required]
        public DateOnly Date { get; set;}
        public TimeOnly Time { get; set; }
    }
}
