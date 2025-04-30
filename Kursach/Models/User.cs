using Microsoft.Extensions.Hosting;
using System.ComponentModel.DataAnnotations;

namespace Kursach.Models
{
    public class User
    {
        [Key]
        public int IdUser { get; set; }

        [Required]
        [StringLength(20)]
        public string Login { get; set; }

        [Required]
        [StringLength(20)]
        public string Password { get; set; }
        public string FIO { get; set; }

        [Required]
        [StringLength(20)]
        public string Status { get; set; }
    }
}
