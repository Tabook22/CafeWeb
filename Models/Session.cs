using System;
using System.ComponentModel.DataAnnotations;
namespace cafeWeb.Models
{
    public class Session
    {
        [Key]
        public int SesId { get; set; }  
        public DateTime sTime { get; set; }
        public DateTime eTime { get; set; }
        public DateTime total {get;set;}
        public int AccNo { get; set; }  
        public int ComId { get; set; }
    }
}