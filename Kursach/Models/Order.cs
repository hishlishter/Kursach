using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Kursach.Models
{
    public class Order
    {
        [Key]
        public int IdOrder { get; set; }
        public int UserId { get; set; }
        public int ProductId { get; set; }
        public DateTime Date { get; set; }
    }
}
