using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using NextwoFinalApp2023.Models;

namespace NextwoFinalApp2023.Data
{
    public class FinalDbContext : IdentityDbContext
    {


        public FinalDbContext(DbContextOptions<FinalDbContext> options) : base(options)
        {
            
        }
        public DbSet<Blog> Blogs { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Client> Clients { get; set; }
        public DbSet<Course> Courses { get; set; }
        public DbSet<Instructor> Instructors { get; set; }
        public DbSet<Menu> Menus { get; set; }
        public DbSet<Partner> Partners { get; set; }
        public DbSet<Payment> Payments { get; set; }
        public DbSet<Setting> Settings { get; set; }
        public DbSet<Slider> Sliders { get; set; }


    }
}
