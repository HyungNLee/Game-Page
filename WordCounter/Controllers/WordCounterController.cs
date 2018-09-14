using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using WordCounter.Models;

namespace WordCounter.Controllers
{
  public class WordCounterController : Controller
  {
    [HttpGet("/wordcounter")]
    public ActionResult Index()
    {
      Dictionary<string, string> pastInputs = RepeatCounter.GetPastInputs();
      return View(pastInputs);
    }

    [HttpPost("/wordcounter/check")]
    public ActionResult Check()
    {
      RepeatCounter newCheck = new RepeatCounter(Request.Form["word"], Request.Form["sentence"]);
      return View(newCheck);
    }
  }
}
