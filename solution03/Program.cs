﻿// Написать программу, которая из имеющегося массива строк формирует массив из строк, 
// длина которых меньше либо равна 3 символа. 
// Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. 
// При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.

string[] ArrayThreeChar(string[] array)
{
    string[] result = new string[array.Length];
    int realsize = 0;
    foreach (string item in array)
    {
        if (item.Length <= 3)
        {
            result[realsize] = item;
            realsize++;
        }
    }
    return result;
}

void Print(string[] Array)
{
    for (int i = 0; i < Array.Length; i++)
    {
        Console.WriteLine(Array[i]);
    }
    Console.WriteLine();
}
string[] new_array = { "hello", "2", "world", ":-)", "145", "cat", "3233", "que" };
string[] array = ArrayThreeChar(new_array);
Print(array);