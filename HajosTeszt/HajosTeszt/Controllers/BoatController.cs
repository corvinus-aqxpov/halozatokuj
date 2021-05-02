using HajosTeszt.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HajosTeszt.Controllers
{
    //[Route("api/[controller]")]
    [ApiController]
    public class BoatController : Controller
    {
        [HttpGet]
        [Route("questions/all")]
        public IActionResult Index()
        {
            HajostesztContext context = new HajostesztContext();
            var kérdések = from x in context.Questions select x.QuestionText;

            return new JsonResult(kérdések);
            return View();
        }
        [HttpGet]
        [Route("questions/count")]
        public int M4() //Tetszőleges metódusnév
        {
            HajostesztContext context = new HajostesztContext();
            int kérdésekSzáma = context.Questions.Count();

            return kérdésekSzáma;
            
        }

        }
}
