using System.ComponentModel.DataAnnotations;

namespace cafeWeb.Models
{
    public class Admin
    {
        [Key]
        public int admid { get; set; }
        public string Name { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
    }
}
