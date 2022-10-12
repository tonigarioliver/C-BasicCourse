// See https://aka.ms/new-console-template for more information

string str = "32";
Console.WriteLine("The string value is: " + str);
int intFromString = Convert.ToInt32(str);
Console.WriteLine("The int value is: " + intFromString);

int? i = null;
Console.WriteLine(i.HasValue);
