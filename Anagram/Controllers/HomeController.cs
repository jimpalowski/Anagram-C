using System.Collections.Generic;
using System;
using Microsoft.AspNetCore.Mvc;
using Anagram.Models;

namespace Anagram.Controllers
{
  public class HomeController : Controller
  {
    [HttpGet("/")]
    public ActionResult Index()
    {

      return View();
    }
    [HttpGet("/create-form")]
      public ActionResult CreateForm()
      {
        return View();
      }

      [HttpPost("/Result")]
      public ActionResult Result()
      {
        Solution newAnagram = new Solution(Request.Form["anagramOne"], Request.Form["anagramTwo"]);
        newAnagram.Save();
        List<Solution> allSolutions = Solution.GetAll();
        return View("Result", allSolutions);
      }
  }
}
