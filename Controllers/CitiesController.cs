using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using PlacesToGo.Models;

namespace PlacesToGo.Controllers
{
    public class CitiesController : Controller
    {

        [HttpGet("/cities")]
        public ActionResult Index()
        {
            List<City> allCities = City.GetAll();
            return View(allCities);
        }

        [HttpGet("/cities/new")]
        public ActionResult CreateForm()
        {
            return View();
        }
        [HttpPost("/cities")]
        public ActionResult Create()
        {
          City newCity = new City (Request.Form["new-country"], Request.Form["new-city"], Request.Form["new-image"]);
          newCity.Save();
          List<City> allCities = City.GetAll();
          return View("Index", allCities);
        }

        [HttpPost("/cities/delete")]
        public ActionResult DeleteAll()
        {
            City.ClearAll();
            return View();
        }

    }
}
