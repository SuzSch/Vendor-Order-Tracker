using System.Collections.Generic;

namespace VendorOrderTracker.Models
{
  public class Vendor
  {
    public static void ClearAll()
    {
      _instances.Clear();
    }
    
    private static List<Vendor> _instances = new List<Vendor>();

    public string Name { get; set; }
    public string Type { get; set; }
    public string Email { get; set; }
    public string PhoneNumber { get; set; }
    public int Id { get; }
    public List<Order> Orders { get; set; }

    public Vendor(string name, string type, string email, string phoneNumber)
    {
      Name = name;
      Type = type;
      Email = email;
      PhoneNumber = phoneNumber;
      _instances.Add(this);
      Id = _instances.Count;
      Orders = new List<Order> { };
    }

    public static List<Vendor> GetAll()
    {
      return _instances;
    }

    public static Vendor Find(int searchId)
    {
      return _instances[searchId - 1];
    }

    public void AddOrder(Order order)
    {
      Orders.Add(order);
    }

    
  }


}






