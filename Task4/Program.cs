//Напишите программу, которая будет выводить третью с конца цифру заданого числа
// или сообщать , что трtтьей цифры нет.

int num = int.Parse(Console.ReadLine()!);

if (num<100)
{
Console.WriteLine("Нет третьего числа");
}
else
{
Console.WriteLine((num / 100) %10);
}
