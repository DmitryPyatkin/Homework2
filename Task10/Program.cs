// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

// 456 -> 5
// 782 -> 8
// 918 -> 1

Console.Clear();
System.Console.WriteLine("Задача 10");

System.Console.Write("Введите трёхзначное число: ");
int inputValue = Convert.ToInt32(Console.ReadLine()); // Приобразование стороки в число.
// Метод ReadLine() используется для ввода строки символов типа string. Для преобразования в другой тип, нужно использовать метод Parse() или методы класса Convert.
string stringValue = Convert.ToString(inputValue);
Console.WriteLine("Вторая цифра этого числа -> " + stringValue[1]);
// Метод ToString() приобразует число в стороку.


