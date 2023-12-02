using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCore.Entities
{
	internal class Customer
	{
		public Guid CustomerID { get; set; }
		public decimal Amount { get; set; }
		public string Name { get; set; }
	}
}
