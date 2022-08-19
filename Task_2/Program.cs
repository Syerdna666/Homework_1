System.Console.WriteLine("Введите первое число: ");
int number_1 = int.Parse(Console.ReadLine());
System.Console.WriteLine("Введите второе число: ");
int number_2 = int.Parse(Console.ReadLine());
System.Console.WriteLine("Введите третье число: ");
int number_3 = int.Parse(Console.ReadLine());
int max_number = number_1;

if (number_2 > number_1)
{
    max_number = number_2;
}
if (number_3 > max_number)
{
    max_number = number_3;
}
System.Console.WriteLine("Наибольшее из трех чисел: " + max_number);
