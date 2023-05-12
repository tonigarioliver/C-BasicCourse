//Exercice1
Console.WriteLine("Introduce multiply table: ");
int table = Convert.ToInt32(Console.ReadLine());
int iterator = 0;
while (iterator < 10)
{
    int result = (iterator + 1) * table;
    Console.WriteLine(table + " x" + (1 + iterator) + "=" + result);
    iterator++;
}

//Exercise2
int numsigned = 0;
do
{
    Console.WriteLine("Introduce a value let's check sign:");
    numsigned = Convert.ToInt32(Console.ReadLine());
    if (numsigned > 0)
    {
        Console.WriteLine("Positive Value");
    }
    else if (numsigned < 0)
    {
        Console.WriteLine("Negative value");
    }

} while (numsigned != 0); // 0 value to abort

bool finished = false;
void rellenarfila(bool fill, int width, int height, int row)
{
    for (int i = 0; i < width; i++)
    {
        if (fill == true)
        {
            Console.Write("*");
        }
        else
        {
            if (row == 0 || row + 1 == height)
            {
                Console.Write("*");
            }
            else
            {
                if (i == 0 || i + 1 == width)
                {
                    Console.Write("*");
                }
                else
                {
                    Console.Write(" ");
                }
            }

        }
    }

    for (int j = 0; j < width; j++)
    {

    }
}
do
{
    Console.WriteLine("Introduce width: ");
    int width = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Introduce heigh: ");
    int heigh = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Introduce boolean: ");
    bool full = Convert.ToBoolean(Console.ReadLine());
    if (width == 0 || heigh == 0)
    {
        finished = true;
    }
    else
    {
        for (int i = 0; i < heigh; i++)
        {
            rellenarfila(full, width, heigh, i);
            Console.WriteLine();
        }
    }

} while (finished == false);