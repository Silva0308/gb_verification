// Написать программу, которая из имеющегося массива строк формирует массив из строк, 
// длина которых меньше либо равна 3 символа. 
// Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. 
// При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.

string[] ArrayThreeChar(string[] array)
{
    int realsize = 0;
    foreach (string item in array)
    {
        if (item.Length <= 3)
        {
            realsize++;
        }
    }
    string[] result = new string[realsize];
    for (int i = 0; i < realsize; i++)
    {
        foreach (string item in array)
        {
            if (item.Length <= 3)
            {
                result[i] = item;
                i++;
            }
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
string[] new_array = { "hello", "2", "world", ":-)", "145", "cat" };
string[] array = ArrayThreeChar(new_array);
Print(array);