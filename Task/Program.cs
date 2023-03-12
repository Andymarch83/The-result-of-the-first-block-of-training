/* 
написать программу, которая из имеющегося массива строк 
формирует массив из строк, длина которых меньше либо равна 3 символа. 
Первоначальный массив можно ввести с клавиатуры, либо задать на старте 
выполнения алгоритма. При решении не рекомендуется пользоваться 
коллекциями, лучше обойтись исключительно массивами.
["hello","2","world",":-)"]->["2",":-)"]
["1234","1567","-2","computer science"]->["-2"]
["Russia","Denmark","Kazan"]->[]
*/

string[] array = { "hello", "2", "world", ":-)" }; // Вводим массив из строк

Console.Write("[");
void PrintArray(string[] array) // Метод вывода на экран вводимого массива
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.Write("] -> ");
}

void FillNewArray(string[] array) // Метод создания массива из строк, длина которых меньше либо равна 3 символа из введённого массива
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3) Console.Write($"{array[i]} ");
    }
    Console.Write("]");
}
PrintArray(array);
FillNewArray(array);