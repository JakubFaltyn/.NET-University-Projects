using Lab3___aplikacja.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding;

namespace Lab3___aplikacja.Controllers
{
    public class ContactController : Controller
    {
        static List<Contact> _contacts = new List<Contact>();


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
                    int id = _contacts.Count != 0 ? _contacts.Max(c => c.Id) : 0;
                    model.Id = id + 1;
                    _contacts.Add(model);

                    return RedirectToAction("Index");
            }
            return View();
        }

        [HttpGet]
        public IActionResult Update(int id)
        {
            var contact = _contacts.Find(c => c.Id == id);
            if (contact != null)
            {
                return View(contact);
            }
            else
            {
                return NotFound();
            }
        }

        [HttpPost]
        public IActionResult Update(Contact model)
        {
            if (ModelState.IsValid)
            {
                var existingContact = _contacts.Find(c => c.Id == model.Id);
                if (existingContact != null)
                {
                    // Update the existing contact with the new data
                    existingContact.Name = model.Name;
                    existingContact.Email = model.Email;
                    existingContact.Birth = model.Birth;
                    existingContact.Phone = model.Phone;
                    existingContact.Priority = model.Priority;

                    return RedirectToAction("Index");
                }
            }
            return View(model);
        }


        [HttpGet]
        public IActionResult Details(int id)
        {
            var contact = _contacts.Find(c => c.Id == id);
            if (contact != null)
            {
                return View(contact);
            }
            else
            {
                return NotFound();
            }
        }

        [HttpGet]
        public IActionResult Delete(int id)
        {
            var contact = _contacts.Find(c => c.Id == id);
            if (contact != null)
            {
                _contacts.Remove(contact);
                return RedirectToAction("Index");
            }
            else
            {
                return NotFound();
            }
        }
    }
}
