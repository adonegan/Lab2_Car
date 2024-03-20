using Lab2_Car.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Lab2_Car.Controllers
{
    public class CarController : Controller
    {
       
        public ActionResult Display()
        {
            Car car = new Car() { Make="Nissan", Model="March", Type=EngineType.Petrol, EngineSize="50CC"};
            return View(car);
        }

       
    }
}
