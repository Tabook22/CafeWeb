using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
namespace cafeWeb.Models
{
    public class myDbContext : DbContext
    {
        public DbSet<Admin> Admins { get; set; }
        public DbSet<Computer> Computers { get; set; }
        public DbSet<Session> Sessions { get; set; }
        public DbSet<Member> Members { get; set; }
        public DbSet<MemberShip> MemberShips { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
	    //The line optionsBuilder.UseSqlite("Data Source=blogging.db"); tells EF to use Sqlite as DB with the appropriate file to persist the data.
            optionsBuilder.UseSqlite("Data Source=Coffee.db");
        }
    }
}