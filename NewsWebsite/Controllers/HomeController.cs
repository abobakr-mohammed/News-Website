using CoreLogic;
using DataContextLogic;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace NewsWebsite.Controllers
{
    public class HomeController : Controller
    {
        private readonly DataContext context;

        public HomeController(DataContext context)
        {
            this.context = context;
        }
        [HttpGet]
        public IActionResult Index()
        {
            var cat = context.categories.ToList();
            return View(cat);
        }

        [HttpGet]
        public IActionResult News(int id)
        {
            Category c = context.categories.Find(id);
            ViewData["Cat"] = c.Name;
            var news  = context.news.Where(ww => ww.CategoryID == id).OrderByDescending(w=>w.Date ).ToList();
            return View(news);
        }
        [HttpGet]
        public IActionResult DeleteNews(int id)
        {
            News N = context.news.Find(id);
            context.Remove(N);
            context.SaveChanges();
            return RedirectToAction("Index");
        }
        public IActionResult About()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Contact()
        {
            return View();
        }

        [HttpPost]
        public IActionResult SaveContact(ContactUs contact)
        {
            context.Add(contact);
            context.SaveChanges();
            return RedirectToAction("Index");
        }

        public IActionResult Privacy()
        {
            return View();
        }
    }
}
