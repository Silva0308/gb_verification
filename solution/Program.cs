// Написать программу, которая из имеющегося массива строк формирует массив из строк, 
// длина которых меньше либо равна 3 символа. 
// Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. 
// При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.

string [] ArrayThreeChar (string [] array)
{
    string[] newarr = new string[array.Length];
    for (int i=0; i<array.Length; i++)
    {
        if (array[i].Length <= 3)
        {
            newarr[i]=array[i];
        }
    }
    return newarr;
}
void Print(string [] Array)
{
    for (int i=0; i<Array.Length; i++)
    {
        Console.WriteLine(Array[i]);
    }
    Console.WriteLine();
}
string [] new_array = {"hello", "2", "world","123", ":-)"};
string [] array = ArrayThreeChar (new_array);
Print (array);