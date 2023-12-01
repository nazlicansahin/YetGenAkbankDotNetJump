using EFCore.Entities;
using EFCore.Persistence;

Console.WriteLine("EFrameWork");

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
