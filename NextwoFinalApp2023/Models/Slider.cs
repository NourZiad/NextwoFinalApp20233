using NextwoFinalApp2023.Models.SharedProp;
using System.ComponentModel.DataAnnotations;
using System.Runtime.InteropServices;

namespace NextwoFinalApp2023.Models
{
    public class Slider : CommonProp
    {
        [Display(Name = "Slider Id")]
        public int SliderId { get; set; }
        [Display(Name = "Slider Title")]
        [Required(ErrorMessage ="Enter Title")]
        public string? SliderTitle { get; set; }
        [Display(Name = "Sub Title")]
        [Required(ErrorMessage = "Enter Sub Title")]
        public string? SliderSubTitle { get; set; }
        [Required(ErrorMessage = "Enter Location")]
        public string? Location { get; set; }
        [Display(Name = "Discount")]
        [Required(ErrorMessage = "Enter Discount")]
        public int? DiscountPer { get; set; }
        [Required(ErrorMessage = "Enter Price")]
        [Range(50,5000,ErrorMessage ="Range 50 to 5000 ")]
        public decimal? Price { get; set; }
        [Required(ErrorMessage = "Enter Currency")]
        public string? Currency { get; set; }
        public string? TxtBtn { get; set; }
        public string? UrlBtn { get; set; }
        [Required(ErrorMessage = "Select Image")]
        public string? SliderImg { get; set; }


    }
}
