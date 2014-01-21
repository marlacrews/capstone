using System.Data.Entity;

namespace MarlaCapstone.Models
{
    public class Guestbook
    {
        public int entry_num { get; set; }
        public string first_name { get; set; }
        public string last_name { get; set; }
        public string city { get; set; }
        public string state_abbrev { get; set; }
        public string email { get; set; }
        public string comment_area { get; set; }
    }

    public class GuestbookDbContext : ApplicationDbContext
    {
        public DbSet<Guestbook> Guestbook { get; set; }
    }
}