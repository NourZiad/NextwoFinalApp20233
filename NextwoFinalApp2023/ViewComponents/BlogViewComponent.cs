using Microsoft.AspNetCore.Mvc;
using NextwoFinalApp2023.Data;

namespace NextwoFinalApp2023.ViewComponents
{
    public class BlogViewComponent : ViewComponent
    {
        private FinalDbContext db;
        public BlogViewComponent(FinalDbContext _db)
        {
            db = _db;
        }
        public IViewComponentResult Invoke()
        {
            var data = db.Blogs.OrderByDescending(x => x.UserId).Take(6);
            return View(data);
        }
    }
}
