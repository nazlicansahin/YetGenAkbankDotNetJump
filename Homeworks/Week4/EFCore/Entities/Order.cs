using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCore.Entities
{
	public class Order
	{
		public Guid OrderID { get; set; }
		public decimal Amount { get; set; }
		public string Name { get; set; }

		public Order(string name, decimal amount)
		{
			OrderID = Guid.NewGuid();
			Amount = amount;
			Name = name;
		}
	}
}
