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
      return Content("Here are some cars Available:"+"\n"+
      "1.Audi\n"+
      "2.BMW\n"+
      "3.Ford\n"+
      "4.Honda\n");
    }
    public IActionResult ShowJSON()
    {
      return  Json(new {name="Audi", price="$130,000",name1="BMW", price1="$140,0000",name2="Ford",price2="$150,000",name3="Honda",price3="160,000"});
    }
    public IActionResult ShowHTML()
    {
      var h = "<!DOCTYPE html><html><body>Here are some cars Available<br> 1.Audi<br> 2.BMW<br> 3.Ford<br> 4.Honda</body></html>";
      return Content(h, "text/html");
    }

    public IActionResult ShowView()
    {
      return View();
    }
    }
}
