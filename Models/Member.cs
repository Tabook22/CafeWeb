using System;
using System.ComponentModel.DataAnnotations;
namespace cafeWeb.Models

{
    public class Member
    {
        [Key]
        public int meId { get; set; }   
        public string name { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }   
        public DateTime DOB { get; set; }   
        public  int AccNo {get;set;}

    }
}