Console.Clear();
Console.WriteLine("Enter number greater than 1: ");
int n = Convert.ToInt32(Console.ReadLine());
int d = 2;
if (n <= 1)
{
    Console.WriteLine("Wrong! Please enter a number greater than 1!");
}
else 
{
    Console.Write("Even numbers between 1 and N: ");
    while (d <= n)
    {
        Console.Write(d);
        Console.Write(", "); // Я пытался найти способ убрать запятую у последней цифры в терминале, но не нашел(
        d = d + 2;           // Надеюсь, зачтете) Я знаю как это сделать только с типом данных string.
    }
}