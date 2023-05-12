// Car description
int? door = null;
int? wheels = null;
String? brand = null;
int ITVyear;
Console.WriteLine("Introduce yor car details: ");
Console.WriteLine("Number of doors: ");
door = Convert.ToInt16(Console.ReadLine());
Console.WriteLine("Number of wheels: ");
wheels = Convert.ToInt16(Console.ReadLine());
Console.WriteLine("Car Brand: ");
brand = Console.ReadLine();
Console.WriteLine("ITV year: ");
ITVyear = Convert.ToInt16(Console.ReadLine());
Console.WriteLine("Yor car has : " + door + "doors wheels:" + wheels + "is from: " + brand + "the last ITV: " + ITVyear);