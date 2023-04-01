using Microsoft.AspNetCore.Mvc;
using NextwoFinalApp2023.Data;

namespace NextwoFinalApp2023.ViewComponents { 

    public class CourseViewComponent : ViewComponent
    {
        private FinalDbContext db;

        public CourseViewComponent( FinalDbContext _db)
        {
            db = _db;
        }
        public IViewComponentResult Invoke() 
        {
            var data = db.Courses.OrderByDescending(x => x.UserId).Take(6);
            return View(data);
        }
    }
}
