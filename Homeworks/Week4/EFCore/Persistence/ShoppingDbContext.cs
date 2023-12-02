using EFCore.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCore.Persistence
{
	internal class ShoppingDbContext : DbContext
	{
		public DbSet<Order> Orders { get; set; }
		public DbSet<Customer> Customers { get; set; }

		protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
		{

			optionsBuilder.UseInMemoryDatabase("OrderMaster");
		}
	}
}
