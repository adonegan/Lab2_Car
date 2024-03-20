using Lab2_Car.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace Lab2_Car.Controllers
{
    public class CarController : Controller
    {
        static Car Auto = new Car() { Make="Nissan", Model="March", Type=EngineType.Petrol, EngineSize="50CC"};

        public ActionResult Display()
        {
            return View(Auto);
        }

        [HttpGet]
        public ActionResult Edit()
        {
            return View(Auto);
        }

        [HttpPost]
        public ActionResult Edit(Car _car)
        {
            if (ModelState.IsValid)
            {
                Auto.Model = _car.Model;
                Auto.Make = _car.Make;
                return RedirectToAction("Display");
            }
            else
            {
                return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
            }
        }

       
    }
}
