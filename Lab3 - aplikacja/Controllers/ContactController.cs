using Lab3___aplikacja.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding;

namespace Lab3___aplikacja.Controllers
{
    public class ContactController : Controller
    {
        static Dictionary<int, Contact> _contacts = new Dictionary<int, Contact>();
        
        public IActionResult Index()
        {
            return View(_contacts);
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Contact model)
        {
            if(ModelState.IsValid)
            {
                    int id = _contacts.Keys.Count != 0 ? _contacts.Keys.Max() : 0;
                    model.Id = id + 1;
                    _contacts[model.Id] = model;

                    return RedirectToAction("Index");
                }
            return View();
        }

        [HttpGet]
        public IActionResult Update()
        {
            if (_contacts.Keys.Contains(id))
            {
                return View(_contacts[id]);
            }
            else
            {
                return NotFound();
            };
        }

        [HttpPost]
        public IActionResult Update(Contact model)
        {
            if (ModelState.IsValid)
            {
                _contacts[model, Index] = model;
                return RedirectToAction("Index");
            }
            return View();

        }

        [HttpGet]
        public IActionResult Details()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Delete()
        {
            return View();
        }
    }
}
