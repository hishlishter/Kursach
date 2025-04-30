using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Kursach.Models
{
    public class Product
    {
        [Key]
        public int IdProduct { get; set; }

        [Required]
        [StringLength(50)]
        public string ProductName { get; set; }

        [Required]
        [StringLength(250)]
        public int Price { get; set; }
        public string Specifications { get; set; }
        public decimal Number { get; set; }

    }
}
