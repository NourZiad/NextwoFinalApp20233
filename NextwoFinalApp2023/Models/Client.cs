using NextwoFinalApp2023.Models;
using NextwoFinalApp2023.Models.SharedProp;

namespace NextwoFinalApp2023.Models
{
    public class Client : CommonProp
    {
        public int ClientId { get; set; }
        public string? ClientName { get; set; }
        public string? ClientPosition { get; set; }
        public string? Img { get; set; }


    }
}
