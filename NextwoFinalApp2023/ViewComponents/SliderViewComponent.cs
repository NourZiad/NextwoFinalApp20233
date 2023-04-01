using Microsoft.AspNetCore.Mvc;
using NextwoFinalApp2023.Data;

namespace NextwoFinalApp2023.ViewComponents
{
    public class SliderViewComponent : ViewComponent
    {
        private FinalDbContext db;

        public SliderViewComponent(FinalDbContext _db)
        {
            db = _db;
        }
        public IViewComponentResult Invoke()
        {
            var data = db.Sliders.OrderByDescending(x => x.UserId).Take(6);
            return View(data);
        }
    }
}
