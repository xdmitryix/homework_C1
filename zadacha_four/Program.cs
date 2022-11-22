Console.Clear();
Console.Write("введи число: ");
int number = int.Parse(Console.ReadLine());
int count = 1;
while (count < number+1)
{
    if (count%2 == 0)
    {
        Console.WriteLine(count);
        count++;
    }
    else
    {
        count++;
    }
}