using System.ComponentModel.DataAnnotations;

namespace ABCEvent.Models
{
    public class User
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(35)]
        public string FirstName { get; set; }

        [Required]
        [StringLength(35)]
        public string LastName { get; set; }

        [Required]
        [StringLength(50)]
        public string EmailId { get; set; }

        [Required]
        [StringLength(15)]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        public bool isActive { get; set; }
    }
}