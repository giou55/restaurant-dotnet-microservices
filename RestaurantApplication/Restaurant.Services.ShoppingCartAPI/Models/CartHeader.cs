using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Restaurant.Services.ShoppingCartAPI.Models
{
    public class CartHeader
    {
        [Key]
        public int CartHeaderId { get; set; }
        public string? UserId { get; set; }
        public string? CouponCode { get; set; }

        [NotMapped] // this field will not be created in database
        public double Discount { get; set; }
        [NotMapped] // this field will not be created in database
        public double CartTotal { get; set; }
    }
}
