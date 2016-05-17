using System;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace SampleRC2WebApp
{
    public class HomeController : Controller
    {
       
        public HomeController()
        {
            throw new Exception(); // this is never thrown
        }
        
        public ActionResult Index()
        {
            return Redirect("http://bing.com");
        }
    }
}