
using Microsoft.AspNetCore.Mvc;
using WordCounter.Models;

namespace WordCounter.Controllers
{
  public class WordCounterController : Controller
  {
    [HttpGet("/wordcounter")]
    public ActionResult Index()
    {
      return View();
    }

    [HttpPost("/wordcounter")]
    public ActionResult Check()
    {
      RepeatCounter newCheck = new RepeatCounter(Request.Form["word"], Request.Form["sentence"]);
      return View(newCheck);
    }
  }
}
