using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Models
{
    public class UserDetails
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
        public string Password { get; set; }
        [Required]
        public bool isActive { get; set; }

    }
}
