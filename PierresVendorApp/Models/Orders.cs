using System;
using System.Collections.Generic;

namespace PierresVendorApp.Models
{
  public class Order
  {
    public string Title { get; set; }
    public string Description { get; set; }
    public int Price { get; set; }
    public DateTime OrderPlacedDate { get; set; }
    public int Id { get; }
    private static int IdCounter = 0;
    private static List<Order> _orders = new List<Order>();
    public Order(string title, string description, int price, DateTime orderPlacedDate)
    {
      Title = title;
      Description = description;
      Price = price;
      OrderPlacedDate = orderPlacedDate;
      IdCounter += 1;
      Id = IdCounter;
      _orders.Add(this);
    }

    public static List<Order> GetAllOrders()
    {
      return _orders;
    }
  }
}
