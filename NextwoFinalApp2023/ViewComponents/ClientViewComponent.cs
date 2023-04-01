using Microsoft.AspNetCore.Mvc;
using NextwoFinalApp2023.Data;

namespace NextwoFinalApp2023.ViewComponents
{
    public class ClientViewComponent :ViewComponent
    {
        private FinalDbContext db;
        public ClientViewComponent(FinalDbContext _db)
        {
            db = _db;
        }
        public IViewComponentResult Invoke()
        {
            var data = db.Clients.OrderByDescending(x => x.UserId).Take(6);
            return View(data);
        }
    }
}
