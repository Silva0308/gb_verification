﻿// Написать программу, которая из имеющегося массива строк формирует массив из строк, 
// длина которых меньше либо равна 3 символа. 
// Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. 
// При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.

void ArrayThreeChar (string [] array)
{
    foreach (string item in array)
    {
        if (item.Length == 3)
        {
            Console.WriteLine (item);
        }
    }
}
string [] new_array = {"hello", "2", "world", ":-)","145", "cat"};
ArrayThreeChar (new_array);
