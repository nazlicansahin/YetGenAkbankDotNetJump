#region Concat
using LinqMethods.Entities;

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