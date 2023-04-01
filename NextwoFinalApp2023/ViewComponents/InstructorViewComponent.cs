using Microsoft.AspNetCore.Mvc;
using NextwoFinalApp2023.Data;

namespace NextwoFinalApp2023.ViewComponents
{
    public class InstructorViewComponent :ViewComponent
    {
       
            private FinalDbContext db;

            public InstructorViewComponent(FinalDbContext _db)
            {
                db = _db;
            }
            public IViewComponentResult Invoke()
            {
                var data = db.Instructors.OrderByDescending(x => x.UserId).Take(6);
                return View(data);
            }
        
    }
}
