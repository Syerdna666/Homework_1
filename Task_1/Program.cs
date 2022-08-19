System.Console.WriteLine("Введите первое число: ");
int number_1 = int.Parse(Console.ReadLine());
System.Console.WriteLine("Введите второе число: ");
int number_2 = int.Parse(Console.ReadLine());

if (number_1 > number_2)
{
    System.Console.WriteLine($"Число {number_1} больше числа {number_2}");
}
else if (number_1 > number_2)
{
    System.Console.WriteLine($"Число {number_2} больше числа {number_1}");
}
else
{
    System.Console.WriteLine($"Число {number_1} равно числу {number_2}");
}