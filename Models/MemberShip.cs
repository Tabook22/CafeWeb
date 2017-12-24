using System.ComponentModel.DataAnnotations;
namespace cafeWeb.Models
{
    public class MemberShip
    {
        [Key]
       public int AccNo { get; set; }   
       public string Password { get; set; }
       public int tSolt {get;set;}
       public int MemId { get; set; }
       public int SecId { get; set; }

    }
}