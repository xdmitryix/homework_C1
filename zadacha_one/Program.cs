Console.Clear();
Console.Write("введи первое число: ");
int number_one = int.Parse(Console.ReadLine());
Console.Write("введи второе число: ");
int number_two = int.Parse(Console.ReadLine());
if (number_one>number_two)
{
    Console.WriteLine($"число {number_one} больше числа {number_two}");
}
if (number_one<number_two)
{
    Console.WriteLine($"число {number_one} меньше числа {number_two}");
}
if (number_one == number_two)
{
    Console.WriteLine("числа одинаковы");
}
