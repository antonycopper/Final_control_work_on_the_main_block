﻿/*
Задача: Написать программу, которая из имеющегося массива
строк формирует новый массив из строк, 
длина которых меньше, либо равна 3 символам. 
Первоначальный массив можно ввести с клавиатуры, 
либо задать на старте выполнения алгоритма. 
При решении не рекомендуется пользоваться коллекциями, 
лучше обойтись исключительно массивами.

Пример ввода:

Введите массив строк через пробел:
abcd ef g hijkl mn


Пример вывода:

Новый массив строк:
ef g mn

Пример кода на C#:
*/


using System;

class Program
{
    static void Main(string[] args)
    {
        // ввод исходного массива строк с клавиатуры
        Console.WriteLine("Введите массив строк через пробел:");
        string[] array = Console.ReadLine().Split();

        // создание нового массива с длиной строки <= 3
        string[] newArray = new string[array.Length];
        int count = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i].Length <= 3)
            {
                newArray[count] = array[i];
                count++;
            }
        }

        // вывод нового массива на экран
        Console.WriteLine("\nНовый массив строк:");
        for (int i = 0; i < count; i++)
        {
            Console.Write(newArray[i] + " ");
        }
    }
}
