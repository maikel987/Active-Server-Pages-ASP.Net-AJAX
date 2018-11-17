using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplicationAgasha.Models;

namespace WebApplicationAgasha.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }


        [OutputCache(Duration = 3600)]
        public ActionResult _ShowCity()
        {
            List<City> result;
            using (MyDBEntities context = new MyDBEntities())
            {
                var cities = from c in context.City select c;
                result = cities.ToList();
            }

            return PartialView(result);
        }
        [OutputCache(Duration = 3600)]
        public ActionResult _ShowClient()
        {
            List<Client> result;
            using (MyDBEntities context = new MyDBEntities())
            {
                var clients = from c in context.Client select c;
                result = clients.ToList();
            }

            return PartialView(result);
        }
    }
}