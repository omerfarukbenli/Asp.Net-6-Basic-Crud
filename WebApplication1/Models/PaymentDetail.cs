using System.ComponentModel.DataAnnotations;

namespace WebApplication1.Models
{
    public class PaymentDetail
    {
        [Key]
        public int PaymentDetaiilId { get; set; }
        public string CardOwnerName { get; set; }
        public string CardNumber { get; set; }
        public string ExpirationDate { get; set; }
        public string SecurityCode { get; set; }
    }
}
