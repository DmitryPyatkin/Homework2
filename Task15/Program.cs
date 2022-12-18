// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

// 6 -> да
// 7 -> да
// 1 -> нет

Console.Clear();
Console.WriteLine("Задача 15 ");

Console.Write("Введи цифру, обозначающую день недели: ");
int dayNumber = Convert.ToInt32(Console.ReadLine());

void CheckingTheDayOfTheWeek(int dayNumber)
{
    if (dayNumber == 6 || dayNumber == 7)
    {
        Console.WriteLine("(Этот день выходной) -> да");
    }
    else { Console.WriteLine("(Этот день не выходной) -> нет"); }
}

CheckingTheDayOfTheWeek(dayNumber);
// void можно использовать в качестве возвращаемого типа void (или локальной функции) для определения того, что метод не возвращает значение. 