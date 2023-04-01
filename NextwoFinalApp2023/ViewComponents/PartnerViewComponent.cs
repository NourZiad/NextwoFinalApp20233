using Microsoft.AspNetCore.Mvc;
using NextwoFinalApp2023.Data;

namespace NextwoFinalApp2023.ViewComponents
{
    public class PartnerViewComponent : ViewComponent
    {
        private FinalDbContext db;
        public PartnerViewComponent(FinalDbContext _db)
        {
            db = _db;
        }
        public IViewComponentResult Invoke()
        {
            var data = db.Partners.OrderByDescending(x => x.UserId).Take(4);
            return View(data);
        }
    }
}
