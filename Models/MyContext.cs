using Microsoft.EntityFrameworkCore;

namespace BeltExam.Models
{
    public class MyContext : DbContext
    {
        public MyContext(DbContextOptions options) : base(options) { }

        public DbSet<UserReg> Users {get; set;}

        public DbSet<Activities> Activities {get; set;}

        public DbSet<Response> Responses {get; set;}
    }
}