using ContactManagerCSharp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ContactManagerCSharp.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            //use singleton to add people to DB
            // Single.Instance.People.Add();
            //creating a view model
            HomeVM model = new HomeVM();
            model.People = Singleton.Instance.People;
            return View(model);
        }

        [HttpGet]
        public ActionResult AddContact()
        {
            return View();
        }

        [HttpPost]
        public ActionResult AddContact(Person person)
        {
            Singleton.Instance.People.Add(person);

            return RedirectToAction("Index");
        }
       
        [HttpGet]
        public ActionResult UpdateContact(int Id)//Might neeed to add int Id back in
        {
            return View();
        }

        [HttpPost]
        public ActionResult UpdateContact(Person person)
        {
            var index = Singleton.Instance.People.FindIndex(x => x.ID == person.ID);//we are trying to get the index of the people
            
            //adding person back
            //overriding the person  in the current index with the new data
            Singleton.Instance.People[index] = person;

            return RedirectToAction("Index");
        }

        public ActionResult DeleteContact(int Id)
        {
            var index = Singleton.Instance.People.FindIndex(x => x.ID == Id);
            Singleton.Instance.People.RemoveAt(index);
            return RedirectToAction("Index");
        }
    }
}