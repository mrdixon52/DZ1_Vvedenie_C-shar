Console.Clear();
Console.WriteLine("Enter number: ");
double n = Convert.ToInt32(Console.ReadLine());
double check = n % 2;
if (check == 0) 
{
    Console.WriteLine("Even number"); // четное число
}
else 
{
    Console.WriteLine("Odd number"); // нечетное число
}
