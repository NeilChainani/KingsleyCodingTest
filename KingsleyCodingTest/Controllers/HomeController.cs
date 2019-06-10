
using System.Web.Mvc;
using UniqueWordCounter;
namespace KingsleyCodingTest.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            UniqueCounter.countUnique("This is a kingsley kingsley");
            return View();
        }
        [HttpPost]
        public ActionResult MyAction(string button)
        {
            string words = Request.Form["words"];
            string countedWords = UniqueCounter.countUnique(words);
            ViewBag.Message = countedWords;
            return View();
        }

    }
}