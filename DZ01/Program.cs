Console.Clear();
Console.WriteLine("Enter first number: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter second number: ");
int b = Convert.ToInt32(Console.ReadLine());
int max = 0;
int min = 0;

if (a < b)
{
    max = b;
    min = a;
}
else 
{
    max = a;
    min = b;
}
Console.Write("Largest of 2 numbers = "); 
Console.Write(max);
Console.WriteLine();
Console.Write("Smallest of 2 numbers = "); 
Console.Write(min);