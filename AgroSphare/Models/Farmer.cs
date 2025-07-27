using System.ComponentModel.DataAnnotations;

namespace AgroSphare.Models
{
    public class Farmer
    {
        [Key]
        public int Id { get; set; }
        
        [Required]
        [StringLength(100)]
        public string FullName { get; set; }
        
        [Required]
        [EmailAddress]
        public string Email { get; set; }
        
        [Required]
        public string Password { get; set; }

        public string Region { get; set; }
        
        // Navigation properties can be added here if needed
    }
}