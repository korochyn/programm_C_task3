// Задача 6: Напишите программу, которая на вход принимает число и выдаёт,
// является ли число чётным (делится ли оно на два без остатка).
Console.WriteLine("Введите число");
int number = int.Parse(Console.ReadLine()!);
int result_1 = number / 2;
int result_2 = number - result_1*2;
// Console.WriteLine(result_2);
if (result_2 == 0) {Console.WriteLine("Число четное");}
else {Console.WriteLine("Число  не четное");}
