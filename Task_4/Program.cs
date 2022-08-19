System.Console.WriteLine("Введите N: ");
int number = int.Parse(Console.ReadLine()!);
if (number > 1)
{
    for (int i = 2; i <= number; i += 2)
    {
        Console.Write(i + " ");
    }
}
else
{
    System.Console.WriteLine("Введите значение N больше 1");
}
