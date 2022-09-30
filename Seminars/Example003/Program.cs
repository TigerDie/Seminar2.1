// Задача 3. Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает последнюю цифру этого числа.

Console.Write("Input three-digit number ");
int n = Convert.ToInt32(Console.ReadLine());

if(n >= 100 && n < 1000)
{
    int lastDigit = n % 10;
    Console.WriteLine($"Last Digit of {n} is {lastDigit}");
}
else
{
    Console.WriteLine("Uncorrect input!");
}