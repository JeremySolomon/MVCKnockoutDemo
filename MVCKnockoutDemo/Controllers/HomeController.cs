using MVCKnockoutDemo.ViewModels;
using System;
using System.Collections.Generic;
using System.Web.Mvc;

namespace MVCKnockoutDemo.Controllers
{
    public class HomeController : Controller
    {

        public ActionResult Index()
        {
            ViewBag.Countries = new List<Country>(){
                new Country()
                {
                    Id = 1,
                    Name = "India"
                },
                new Country()
                {
                    Id = 2,
                    Name = "USA"
                },
                new Country()
                {
                    Id = 3,
                    Name = "France"
                }
            };

            var viewModel = new PersonViewModel()
            {
                Id = 1,
                Name = "Naveen",
                DateOfBirth = new DateTime(1990, 11, 21)
            };

            return View(viewModel);
        }

        [HttpPost]
        public JsonResult SavePersonDetails(PersonViewModel viewModel)
        {
            // TODO: Save logic goes here.

            return Json(new { Message = $"{viewModel.Name}: {viewModel.Country.Name}"});
        }


    }
}