using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqMethods.Entities
{
	internal class Person
	{
		public int ID { get; set; }
		public string Name { get; set; }

		public Person(int id, string name)
		{
			ID = id;
			Name = name;
		}

	}
}
