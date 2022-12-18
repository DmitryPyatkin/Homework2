// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

Console.Clear();
Console.WriteLine("Задача 13 ");

Console.Write("Введи число: ");
int inputValue  = Convert.ToInt32(Console.ReadLine());
string stringValue = Convert.ToString(inputValue);
if (stringValue.Length > 2){
  Console.WriteLine("Третья цифра -> " + stringValue[2]);
}
else {
  Console.WriteLine("-> третьей цифры нет");
}
