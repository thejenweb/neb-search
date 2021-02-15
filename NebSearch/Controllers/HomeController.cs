using Microsoft.AspNetCore.Mvc;
using NebSearch.Models;

namespace NebSearch.Controllers
{
  public class HomeController : Controller
  {
    [Route("/")]
    public ActionResult Index()
    {
      return View();
    }

  }
}