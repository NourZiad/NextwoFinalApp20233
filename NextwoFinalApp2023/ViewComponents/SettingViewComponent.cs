using Microsoft.AspNetCore.Mvc;
using NextwoFinalApp2023.Data;

namespace NextwoFinalApp2023.ViewComponents
{
    public class SettingViewComponent : ViewComponent
    {
        private FinalDbContext db;
        public SettingViewComponent(FinalDbContext _db)
        {
            db = _db;
        }
        public IViewComponentResult Invoke()
        {
            var data = db.Settings.OrderByDescending(x => x.UserId).Take(6);
            return View(data);
        }
    }
}
