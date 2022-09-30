// Задача 2. Напишите программу, которая на вход принимает одно число (N), а на выходе показывает все целые числа в промежутке от -N до N.

Console.Write("Input a number: ");
int number = Convert.ToInt32(Console.ReadLine());

int current;

if(number > 0)
{
    current = -number;
}
else
{
    current = number;
    number *= -1;
}
while(current <= number)
{
    Console.Write(current + " " );
    current++;
}
/* 253 % 10 -> 3
   253 % 100 -> 53
   253 % 1000 -> 253

   253 / 10 -> 25
   */