// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

var lista = new List<string> { "Pepe", "Manu" };
foreach (var item in lista)
{
    Console.WriteLine(item);
}

//Sumar los primeros cien valores enteros
Console.WriteLine("Introduce el limite de la suma");
int limit = Convert.ToInt32(Console.ReadLine());
int resultado = 0;
for (int i = 0; i < limit; i++)
{
    resultado += i;
}
Console.WriteLine($"El resultado es:" + Convert.ToString(resultado));

//Sumar los primeros

int[] array = new int[2];
foreach (var item in array)
{
    Console.WriteLine(item);
}