using System.ComponentModel.DataAnnotations;
using System;

namespace CrazyCoolCars.Models
{
  public class Car
  {
    public int Id { get; set; }
    public double SKU { get; set; }
    public int Year { get; set; }
    public string Make { get; set; }
    public string Model { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }
    public int NumberInStock { get; set; }
    public decimal Price { get; set; }
    public DateTime DatePurchased { get; set; }
  }
}