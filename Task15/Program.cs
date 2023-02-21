// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

// 6 -> да
// 7 -> да
// 1 -> нет

// Console.Clear();
// Console.WriteLine("Задача 15 ");

// Console.Write("Введи цифру, обозначающую день недели: ");
// int dayNumber = Convert.ToInt32(Console.ReadLine());

// void CheckingTheDayOfTheWeek(int dayNumber)
// {
//     if (dayNumber == 6 || dayNumber == 7)
//     {
//         Console.WriteLine("(Этот день выходной) -> да");
//     }
//     else { Console.WriteLine("(Этот день не выходной) -> нет"); }
// }

// CheckingTheDayOfTheWeek(dayNumber);
// // void можно использовать в качестве возвращаемого типа void (или локальной функции) для определения того, что метод не возвращает значение. 




// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.


Console.WriteLine("введите количество строк");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введите количество столбцов");
int m = Convert.ToInt32(Console.ReadLine());

int[,] numbers = new int[n, m];
FillArrayRandomNumbers(numbers);


for (int j = 0; j < numbers.GetLength(1); j++)
{
    double avarage = 0;
    for (int i = 0; i < numbers.GetLength(0); i++)
    {
        avarage = (avarage + numbers[i, j]);
    }
    avarage = avarage / n;
    Console.Write(avarage + "; ");
}
Console.WriteLine();
PrintArray(numbers);



void FillArrayRandomNumbers(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(0, 10);
        }
    }
}

void PrintArray(int[,] array)
{

    for (int i = 0; i < array.GetLength(0); i++)
    {
        Console.Write("[ ");
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.Write("]");
        Console.WriteLine("");
    }
}