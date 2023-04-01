using NextwoFinalApp2023.Models.SharedProp;
using System.ComponentModel.DataAnnotations;

namespace NextwoFinalApp2023.Models
{
    public class Partner : CommonProp
    {
        public int PartnerId { get; set; }
        [Required]
        public string? PartnerName { get; set; }
        [Required]
        public string? PartnerImg { get; set; }

    }
}
