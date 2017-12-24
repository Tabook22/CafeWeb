using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using cafeWeb.Models;
using Microsoft.AspNetCore.Mvc;
namespace cafeWeb.Controllers
{
    [Route("api/[controller]")]
    public class AdminController
    {
        [HttpGet]
        public List<Admin> Get()
        {
            List<Admin> adLst=new List<Admin>();
            adLst.Add(new Admin{admid=1,Name="Nasser Tabook",Password= "Nasser",Email= "nmtabook@gmail.com",Phone= "12345679"});
            adLst.Add(new Admin{admid=2,Name="Nasser Tabook",Password= "Nasser",Email= "nmtabook@gmail.com",Phone= "12345679"});
            adLst.Add(new Admin{admid=3,Name="Nasser Tabook",Password= "Nasser",Email= "nmtabook@gmail.com",Phone= "12345679"});
            return adLst;
        }
    }
}