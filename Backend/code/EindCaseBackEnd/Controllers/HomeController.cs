using EindCaseBackEnd.Data;
using EindCaseBackEnd.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
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



            var data = cursusContext.Cursussen.Include(ci => ci.CursusInstanties).ToList();

            //return cursusContext.getCursus();
            return data;
           


        }





    }
}
