Console.Clear();
Console.WriteLine("Enter first number: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter second number: ");
int b = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter third number: ");
int c = Convert.ToInt32(Console.ReadLine());
int max = 0;
int max1 = 0;

if (a < b)
{
    max = b;
}
else 
{
    max = a;
}

if (max < c) 
{
    max1 = c;
}
else 
{
    max1 = max;
}
Console.Write("Largest of 3 numbers = "); 
Console.Write(max1);