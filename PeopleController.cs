using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVCDemo.Models;

namespace MVCDemo.Controllers
{
    public class PeopleController : Controller
    {
        // GET: People
        public ActionResult Index()
        {
            
            return View();
        }

        public ActionResult ListPeople()
        {
            List<PersonModel> people = new List<PersonModel>();
            people.Add(new PersonModel { FirstName = "Rose", LastName = "Anderson", Age = 20 });
            people.Add(new PersonModel { FirstName = "Ashka", LastName = "Thomas", Age = 33 });
            people.Add(new PersonModel { FirstName = "Dawn", LastName = "Robins", Age = 45 });

            return View(people);
        }
    }
}