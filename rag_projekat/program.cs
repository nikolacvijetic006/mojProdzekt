Console.WriteLine("Hello, World!");
Console.WriteLine("This is a sample C# program.");
int a = Convert.ToInt32(Console.ReadLine());
if (a < 0)
{
    Console.WriteLine("The value is negative.");
}
else if (a == 0)
{
    Console.WriteLine("The value is zero.");
}
else
{
    Console.WriteLine("The value is positive.");
}