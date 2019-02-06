using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Web.Models;

namespace Web.Controllers
{
    public class CarController : Controller
    {
         public IActionResult ShowText()
    {
      return Content("This is a new car");
    }
    public IActionResult ShowJSON()
    {
      return  Json(new {name="New car", car="This is my new car."});
    }
    public IActionResult ShowHTML()
    {
      var h = "<!DOCTYPE html><html><body>This is a new car.</body></html>";
      return Content(h, "text/html");
    }

    public IActionResult ShowView()
    {
      return View();
    }
    }
}
