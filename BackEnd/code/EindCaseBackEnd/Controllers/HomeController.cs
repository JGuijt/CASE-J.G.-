using EindCaseBackEnd.Data;
using EindCaseBackEnd.Models;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using TextInputMods;

namespace EindCaseBackEnd.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HomeController : ControllerBase
    {

        private readonly CursusContext cursusContext;
        private IWebHostEnvironment _webHostEnvironment;        
        private string readOutput;

        public HomeController(CursusContext context, IWebHostEnvironment webHostEnvironment)
        {
            cursusContext = context;
            _webHostEnvironment = webHostEnvironment;
        }

        [HttpGet]
        public List<Cursus> GetCursus()
        {
            var data = cursusContext.Cursussen.Include(ci => ci.CursusInstanties).ToList();
            return data;

        }


        [HttpPost, DisableRequestSizeLimit]
        public async Task<IActionResult> UploadFile()
        {
            try
            {
                
                var file = Request.Form.Files[0];
               

                FileReader read = new FileReader();
                readOutput = await read.ReadFile(file);               
               
                
                
                return StatusCode(200);

            }
            catch (System.Exception x)
            {
                return StatusCode(500, x.Message);
            }
        }




    }
}
