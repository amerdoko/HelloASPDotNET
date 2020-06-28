using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace HelloASPDotNET.Controllers
{
    [Route("/helloworld")]
    public class HelloController : Controller
    {
       
        // GET   /helloworld/
        [HttpGet]
        //[Route("/helloworld/")]
        public IActionResult Index()
        {
            //string html = "<h1>Hello World!</h1>";
            string html = "<form method='post' action='/helloworld/'>" +
                "<input type='text' name='name' />" +
                "<input type='submit' value='Greet Me!' />" +
                "</form>";
            return Content(html, "text/html");
        }

        // GET
        //[HttpGet]
        //[Route("/helloworld/welcome/{name?}")]
        [HttpGet("welcome/{name?}")]
        [HttpPost]
        //[Route("/helloworld")]
        public IActionResult Welcome(string name = "World")
        {
            return Content("<h1>Welcome to my app, " + name + "!</h1>", "text/html");
        }
    }
}
