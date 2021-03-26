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

namespace EindCaseBackEnd.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HomeController : ControllerBase
    {

        private readonly CursusContext cursusContext;
        private IWebHostEnvironment _webHostEnvironment;
        private byte[] res;

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
        public ActionResult UploadFile()
        {
            try
            {
                
                var file = Request.Form.Files[0];
                string folderName = "Upload";
                //string webRootPath = _webHostEnvironment.WebRootPath;
                string localPath = "C:/Users/Joapie/Desktop";
                string newPath = Path.Combine(localPath, folderName);
                if (!Directory.Exists(newPath))
                {
                    Directory.CreateDirectory(newPath);
                }

                if (file.Length > 0)
                {
                    string fileName = ContentDispositionHeaderValue.Parse(file.ContentDisposition).FileName.Trim('"');
                    string fullPath = Path.Combine(newPath, fileName);
                    

                    using (FileStream stream = new FileStream(fullPath, FileMode.Create))
                    {
                        file.CopyTo(stream);                       

                    }
                }
                
                return Content("it did");

            }
            catch (System.Exception x)
            {
                return Content("Upload Failed" + x.Message);
            }
        }



        //[HttpPost, DisableRequestSizeLimit]
        //public IActionResult UploadFile()
        //{
        //    try
        //    {
        //        var file = Request.Form.Files[0];
        //        var folderName = Path.Combine("res", "img");
        //    }


        //}





    }
}
