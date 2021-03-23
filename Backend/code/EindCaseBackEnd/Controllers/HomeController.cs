using EindCaseBackEnd.Data;
using EindCaseBackEnd.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EindCaseBackEnd.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HomeController : ControllerBase
    {

        private readonly CursusContext cursusContext;

        public HomeController(CursusContext context)
        {
            cursusContext = context;
        }

        [HttpGet]
        public List<Cursus> GetCursus()
        {
            
            
            
            return cursusContext.getCursus();
           


        }





    }
}
