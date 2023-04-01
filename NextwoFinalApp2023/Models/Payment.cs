using NextwoFinalApp2023.Models.SharedProp;

namespace NextwoFinalApp2023.Models
{
    public class Payment : CommonProp
    {
        public Guid PaymentId { get; set; }
        public string? InvoiceId { get; set; }
        public decimal? Total { get; set; } 
        public bool IsSuccess { get; set; }

    }
}
