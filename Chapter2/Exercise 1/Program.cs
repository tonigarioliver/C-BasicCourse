// Car description
String? name = null;
String? surname = null;
int? age = null;
bool? programer = null;
Console.WriteLine("Introduce yor person details: ");
Console.WriteLine("Name: ");
name = Console.ReadLine();
Console.WriteLine("Surname: ");
surname = Console.ReadLine();
Console.WriteLine("Age: ");
age = Convert.ToInt16(Console.ReadLine());
Console.WriteLine("Is he a programmer? ");
programer = Convert.ToBoolean(Console.ReadLine());
Console.WriteLine("Yor person is: " + name + " " + surname + "is: " + age + "old and is it a programer?: " + programer);