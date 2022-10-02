Console.Clear();
Console.WriteLine("Ведите a:");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Ведите b:");
int b = Convert.ToInt32(Console.ReadLine());

if (a > b)
{
    Console.WriteLine($"max a = {a}");
}
else
{
    Console.WriteLine($"max b = {b}");
}
