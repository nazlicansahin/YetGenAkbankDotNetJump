using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqMethods.Entities
{
	internal class Pet
	{

		
			public string Name { get; set; }
			public string Species { get; set; }
			public int Age { get; set; }

			// Constructor
			public Pet(string name, string species, int age)
			{
				Name = name;
				Species = species;
				Age = age;
			}

			// Method to display pet information
			public void DisplayInfo()
			{
				Console.WriteLine($"Name: {Name}\nSpecies: {Species}\nAge: {Age} years old");
			}
		}

	
}
