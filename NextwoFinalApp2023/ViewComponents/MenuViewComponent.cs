using Microsoft.AspNetCore.Mvc;
using NextwoFinalApp2023.Data;

namespace NextwoFinalApp2023.ViewComponents
{
    public class MenuViewComponent : ViewComponent
    {
        private FinalDbContext db;

        public MenuViewComponent(FinalDbContext _db)
        {
            db = _db;
        }
        public IViewComponentResult Invoke()
        {
            var data = db.Menus;/*.OrderByDescending(x => x.UserId);*/
            return View(data);
        }
    }
    
}
