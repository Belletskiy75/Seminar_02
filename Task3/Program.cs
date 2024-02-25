// Напишите программу, которая будет принимать на вход два числа и выводить,
// является ли второе число кратным первому.
//Если вторре число некратно первому то программа выволит  остаток от деления.

int N1 = int.Parse(Console.ReadLine()!);
int N2 = int.Parse(Console.ReadLine()!);
if (N1 % N2 == 0)
    Console.WriteLine("yes");
else
    Console.WriteLine(N1 % N2);
