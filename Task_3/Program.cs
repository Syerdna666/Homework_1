System.Console.WriteLine("Введите число: ");
int number = int.Parse(Console.ReadLine());

if (number % 2 == 0)
{
    System.Console.WriteLine($"{number} - чётное");
}
else
{
    System.Console.WriteLine($"Число {number} - нечётное");
}