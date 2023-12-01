#region Concat
using LinqMethods.Entities;
using System.Collections.Generic;

Pet pet1 = new Pet("Buddy", "Dog", 5);
Pet pet2 = new Pet("Whiskers", "Cat", 3);
Pet pet3 = new Pet("Charlie", "Dog", 2);
Pet pet4 = new Pet("Lucy", "Dog", 4);
Pet pet5 = new Pet("Cooper", "Cat", 1);
Pet pet6 = new Pet("Daisy", "Cat", 6);
Pet pet7 = new Pet("Rocky", "Cat", 3);
Pet pet8 = new Pet("Luna", "Dog", 2);

List<Pet> petList1 = new List<Pet>() { pet1 , pet2, pet3, pet4 };
List<Pet> petList2 = new List<Pet>() { pet5, pet6 };
List<Pet> petList3 = new List<Pet>() { pet7, pet8 };

IEnumerable<string> query =
	petList1.Select(p => p.Name).Concat(petList2.Select(p => p.Name));

foreach (string p in query)
{
	Console.WriteLine(p);
}
//IEnumerable<string> türü, koleksiyon üzerinde LINQ sorguları çalıştırmak veya döngü işlemleri yapmak gibi çeşitli koleksiyon işlemleri için kullanılabilir.

#endregion

#region Distinct

//Returns distinct elements from a sequence.

Person person1 = new Person(1, "Alice");
Person person2 = new Person(2, "Bob");
Person person3 = new Person(1, "Ali"); // Similar to person1

 List<Person> people = new List<Person> { person1, person2, person3 };

Console.WriteLine("person1 and person2 " + person1.Equals(person2));

Console.WriteLine("person1 and person3 " + person1.Equals(person3));

Console.WriteLine("person3 and person2 " + person3.Equals(person2));

IEnumerable<Person> distinctPeople = people.Distinct(); //compare according to id
foreach (Person person in distinctPeople)
{
	Console.WriteLine($"ID: {person.ID} Name: {person.Name}");
}

#endregion

#region Skip

int[] grades = { 59, 82, 70, 56, 92, 98, 85 };

Console.WriteLine("All grades except the first three:");
foreach (int grade in grades.Skip(3))
{
	Console.WriteLine(grade);
}
//Bypasses a specified number of elements in a sequence and then returns the remaining elements.
#endregion

#region Take

//Returns a specified number of contiguous elements from the start of a sequence.
IEnumerable<int> topThreeGrades =
	grades.OrderByDescending(grade => grade).Take(3);

Console.WriteLine("The top three grades are:");
foreach (int grade in topThreeGrades)
{
	Console.WriteLine(grade);
}


#endregion

#region Join
//Correlates the elements of two sequences based on matching keys.

List<Customer> customers = new List<Customer>
{
	new Customer { CustomerID = 1, Name = "Alice" },
	new Customer { CustomerID = 2, Name = "Bob" },
	new Customer { CustomerID = 4, Name = "Dave" } // CustomerID 4 doesn't exist in orders
};


List<Order> orders = new List<Order>
{
	new Order { CustomerId = 1, OrderID = 101, Amount = 150 },
	new Order { CustomerId = 2, OrderID = 102, Amount = 200 },
	new Order { CustomerId = 1, OrderID = 103, Amount = 100 },
	new Order { CustomerId = 3, OrderID = 104, Amount = 300 }
};

var OwnerOfOrder = customers.Join(
	orders,
	customer => customer.CustomerID,
	order => order.CustomerId,
	(customer, order) => new
	{
		CustomerName = customer.Name,
		OrderID = order.OrderID,
		Amount = order.Amount,
	});
foreach (var result in OwnerOfOrder)
{
	Console.WriteLine("{0} - Order ID: {1}",
			result.CustomerName,
			result.OrderID);
}
#endregion

#region Contains
//Determines whether a sequence contains a specified element by using the default equality comparer.
foreach (var customer in customers)
{
	if (orders.Select(o => o.CustomerId).Contains(customer.CustomerID))
	{ Console.WriteLine($"Customer {customer.Name} has orders."); }
	else
	{
		Console.WriteLine($"Customer {customer.Name} has no orders.");
	}
}

#endregion

#region Average
//Computes the average of a sequence of numeric values.

double average = grades.Average();

Console.WriteLine("The average grade is {0}.", average);

#endregion

#region Select

List<int> numbers = new List<int> { 1, 2, 3, 4, 5 };

IEnumerable<int> multipliedNumbers = numbers.Select(x => x * 2);

foreach (var number in multipliedNumbers)
{
	Console.WriteLine(number);
}

#endregion