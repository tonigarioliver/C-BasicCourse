// See https://aka.ms/new-console-template for more information
//Exercise1
Console.WriteLine("Introduce los siguientes datos:");
Console.WriteLine("Nombre: ");
String name = Console.ReadLine();
Console.WriteLine("Email:");
String email = Console.ReadLine();
Console.WriteLine("Introduce si o no para cupon descuento:");
bool cupon = Convert.ToBoolean(Console.ReadLine());
double price = 10.5;
double descuento = 10;
if (cupon == false)
{
    Console.WriteLine("Useted no tiene descuento por tanto el precio es de: " + price);
}
else
{
    price = price * ((100 - descuento) * 0.01);
    Console.WriteLine("Useted  tiene descuento por tanto el precio es de: " + price);
}
