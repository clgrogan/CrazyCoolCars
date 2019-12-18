using System.ComponentModel.DataAnnotations;
using System;

namespace CrazyCoolCars.Models
{
  public class Car
  {
    public int Id { get; set; }
    public double SKU { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }
    public int NumberInStock { get; set; }
    public decimal Price { get; set; }
    public DateTime MyProperty { get; set; }
  }
}