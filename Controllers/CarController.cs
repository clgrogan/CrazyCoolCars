using System.Linq;
using Microsoft.AspNetCore.Mvc;
using CrazyCoolCars.Models;

namespace CrazyCoolCars.Controllers

{
  [ApiController]
  [Route("api[controller]")]
  public class CarController : ControllerBase
  {
    [HttpGet]
    public ActionResult GetAllCars()
    {
      // Get that returns all cars in the database
      var db = new DatabaseContext();
      return Ok(db.Cars.OrderBy(car => car.Make));
    }

    [HttpGet("{id}")]
    public ActionResult GetCarById(int id)
    {
      // Get a particular car from the database by Id
      var db = new DatabaseContext();
      var car = db.Cars.FirstOrDefault(e => e.Id == id);
      if (car == null)
      {
        return NotFound();
      }
      else
      {
        return Ok(car);
      }
    }

    [HttpGet("sku/{sku}")]
    public ActionResult GetCarBySKU(int sku)
    {
      // Get a particular car from the database by Sku
      var db = new DatabaseContext();
      var car = db.Cars.FirstOrDefault(e => e.SKU == sku);
      if (car == null)
      {
        // return NotFound(sku);
        // string returnString = 
        return NotFound("That SKU did not match any cars. SKU: " + sku);
      }
      else
      {
        return Ok(car);
      }
    }

    [HttpGet("outofstock/")]
    public ActionResult GetOutOfStock()
    {
      // Get cars with 0 in stock
      var db = new DatabaseContext();
      return Ok(db.Cars.Where(e => e.NumberInStock == 0));
    }

    [HttpPost]
    public ActionResult CreateCar(Car car)
    {
      var db = new DatabaseContext();
      db.Cars.Add(car);
      db.SaveChanges();
      return Ok(car);
    }
    [HttpPut("{id}")]
    public ActionResult UpdateCar(Car car)
    {
      var db = new DatabaseContext();
      var prevCar = db.Cars.FirstOrDefault(e => e.Id == car.Id);
      if (prevCar == null)
      {
        return NotFound();
      }
      else
      {
        prevCar.SKU = car.SKU;
        prevCar.Year = car.Year;
        prevCar.Make = car.Make;
        prevCar.Model = car.Model;
        prevCar.Description = car.Description;
        prevCar.NumberInStock = car.NumberInStock;
        prevCar.Price = car.Price;

        db.SaveChanges();
        return Ok(prevCar);
      }
    }

    [HttpDelete("{id}")]
    public ActionResult DeleteCar(int id)
    {
      var db = new DatabaseContext();
      var car = db.Cars.FirstOrDefault(e => e.Id == id);
      if (car == null)
      {
        return NotFound();
      }
      else
      {
        db.Cars.Remove(car);
        db.SaveChanges();
        return Ok(car);
      }
    }

  }
}