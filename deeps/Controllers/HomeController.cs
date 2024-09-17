using deeps.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace deeps.Controllers
{
    public class HomeController : Controller
    {
        

        public IActionResult About()
        {
            return View();
        }
        public IActionResult Admin()
        {
            return View();
        }


        public IActionResult Department()
        {
            return View();
        }

        [Route ("")]
        [Route("Home/Admin")]

        [Route("")]
        [Route("Home/About")]


        [Route("")]
        [Route("Home/Department")]

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
