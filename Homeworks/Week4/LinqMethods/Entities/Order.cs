using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqMethods.Entities
{
	internal class Order
	{

	
			public int OrderID { get; set; }
			public decimal Amount { get; set; }
			public int CustomerId { get; set; }
	}
}
