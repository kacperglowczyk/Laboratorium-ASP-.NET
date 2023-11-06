using Laboratorium3_App_.Models;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Laboratorium3_App_.Controllers
{
    public class ContactController : Controller
    {
        static readonly Dictionary<int, Contact> _contacts = new Dictionary<int, Contact>();
        static int index = 1;
        public IActionResult Index()
        {
            return View(_contacts);
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Update(int id)
        {
            return View(_contacts[id]);
        }

        [HttpGet]
        public IActionResult Details(int id)
        {
            return View(_contacts[id]);
        }

        [HttpGet]
        public IActionResult Delete(int id)
        {
            return View(_contacts[id]);
        }

        [HttpPost]
        public IActionResult Create(Contact model)
        {
            if (ModelState.IsValid)
            {
                model.Id = index++;
                _contacts[model.Id] = model;
                return RedirectToAction("Index");
            }
            return View();
        }

        [HttpPost]
        public IActionResult Update(Contact model)
        {
            if (ModelState.IsValid)
            {
                _contacts[model.Id] = model;
                return RedirectToAction("Index");
            }
            return View();
        }
    }
}

