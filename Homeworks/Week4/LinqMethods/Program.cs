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
Person person3 = new Person(1, "Alice"); // Similar to person1

 List<Person> people = new List<Person> { person1, person2, person3 };

IEnumerable <int> distinctPerson = people.Count.Distinct(); 



#endregion