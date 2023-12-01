using System;

namespace LinqMethods.Entities
{
	internal class Person : IEquatable<Person>
	{
		public int ID { get; set; }
		public string Name { get; set; }

		public Person(int id, string name)
		{
			ID = id;
			Name = name;
		}

		public override bool Equals(object obj)
		{
			return Equals(obj as Person);
		}

		public bool Equals(Person other)
		{
			if (other == null)
				return false;

			return ID == other.ID;//&& Name == other.Name
		}
		/* Why we use Equals()
		 * to creating own equal methods
		 * in this code when we use equals method it will compare two instances
		 * Name and Id properties two of the is same it returns true */


public override int GetHashCode()
{
	return HashCode.Combine(ID);  //Name
}

/* Why we use getHashCode()
 * In the above example, the GetHashCode() method is overridden 
 * to generate a hash code based on the ID and Name properties of
 * the Person class. This ensures that if two Person objects are
 * considered equal according to their properties (defined in the 
 * Equals() method), they produce the same hash code when GetHashCode() 
 * is called, maintaining consistency for hash-based collections.*/
	}
}
