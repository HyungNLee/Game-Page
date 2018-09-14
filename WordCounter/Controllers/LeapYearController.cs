using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using WordCounter.Models;

namespace WordCounter.Controllers
{
  public class LeapYearController : Controller
  {
    [HttpGet("/leapyear")]
    public ActionResult Index()
    {
      List<LeapYear> pastInputs = LeapYear.GetPastInputs();
      return View(pastInputs);
    }

    [HttpPost("/leapyear/check")]
    public ActionResult Check()
    {
      LeapYear newCheck = new LeapYear(Request.Form["year"]);
      return View(newCheck);
    }
  }
}
