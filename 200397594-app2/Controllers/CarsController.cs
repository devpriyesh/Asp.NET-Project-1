using _200397594_app2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace _200397594_app2.Controllers
{
    public class CarsController : Controller
    {
        List<Car> carList = new List<Car>()
        {
            new Car {Id=1 , Brand = "Toyota" , Model = "Corolla" , Type = "Comapact" , Year= 2017} ,
            new Car {Id=1 , Brand = "Toyota" , Model = "Corolla" , Type = "Comapact" , Year= 2017} ,
            new Car {Id=1 , Brand = "Toyota" , Model = "Corolla" , Type = "Comapact" , Year= 2017}
        };
        // GET: Cars
        public ActionResult Index()
        {
            // return Content("/cars: This is the list of all the cars from Content()");
            // return HttpNotFound();
            return View(carList);
            


        }

        //GET : CARS/DETAILS - SINGLE CAR
        public ActionResult Details(int? id)
        {
            if(id == null || id > carList.Count )
            {
                return Content("Invalid car id");
            }
            var ind = Convert.ToInt32(id) - 1;
            var car = carList[ind];

            return View(car);
        }
    }
}