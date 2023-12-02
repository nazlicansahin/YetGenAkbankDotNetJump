using EFCore.Entities;
using EFCore.Persistence;

Console.WriteLine("EFrameWork");

#region Add/ Create
ShoppingDbContext _context = new ShoppingDbContext();
_context.Orders.Add(new("fridge", 1500));
_context.Orders.Add(new("toaster", 5060));
_context.Orders.Add(new("phone", 540));
_context.Orders.Add(new("sthg", 400));
_context.Orders.Add(new("elevator", 5000));

_context.SaveChanges();

List<Order> orders = _context.Orders.ToList();
foreach (Order order in orders)
{
	Console.WriteLine(order.Name);
}


#endregion 

#region Update

var orderToUpdate = _context.Orders.FirstOrDefault(o => o.Name == "phone");

if (orderToUpdate != null)
{
	orderToUpdate.Amount = 0;
	_context.SaveChanges();
}
#endregion

#region Delete

var orderToDelete = _context.Orders.FirstOrDefault(o => o.Name == "sthg");
if (orderToDelete != null)
{
	_context.Orders.Remove(orderToDelete);
	_context.SaveChanges();

}
#endregion

#region Read
var ordersToRead = _context.Orders.ToList();
foreach (Order order in ordersToRead)
{
	Console.WriteLine($"Order ID: {order.OrderID}, Name: {order.Name}, Amount: {order.Amount}");

}

#endregion