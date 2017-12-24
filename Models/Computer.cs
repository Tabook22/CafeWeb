using System.ComponentModel.DataAnnotations;
namespace cafeWeb.Models
{
    public class Computer
    {
        [Key]
        public int ComId { get; set; }  
        public string Name { get; set; }
        public int SesId { get; set; }
    }
}