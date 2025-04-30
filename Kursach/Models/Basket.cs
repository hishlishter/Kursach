using System.ComponentModel.DataAnnotations;

namespace Kursach.Models
{
    public class Basket
    {
        [Key]
        public int IdBasket { get; set; }
        public string UserId { get; set; }
        public string ProductId { get; set; }
    }
}
