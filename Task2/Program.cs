// Напишите програмку, которая принимае на вход трёхзначнре число
// и возводит вторую цифру этого числа
// в степень равную третьей цифре.

int num1 = int.Parse(Console.ReadLine()!);
int num2 = num1/10%10;
int num3= num1%10;
Console.WriteLine(Math.Pow(num2,num3));
