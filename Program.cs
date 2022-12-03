/*
Задание:
Написать программу, которая из имеющегося массива строк 
формирует массив из строк, 
длинна которых меньше либо равна 3 символа. 
Первоначальный массив можно ввести с клавиатуры, 
либо задать на старте выполнения алгоритма. 
При решении не рекомендуется пользоватся коллекциями, 
лучше обойтись исключительно массивами.

Примеры:

["hello", "2", "world", ":-)"] -> ["2", ":-)"]
["1234", "1567", "-2", "computer science"] -> ["-2"]
["Russian", "Denmark", "Kazan"] -> []```
 */

 string[] arrayString = { "hello", "2", "world", ":-)" };
//string[] arrayString2 = { "1234", "1567", "-2", "computer science" };
//string[] arrayString3 = { "Russian", "Denmark", "Kazan" };

// метод проверят массив на длинну элемента не больше 3 символов
string[] СhekArrayThreeCharacters(string[] array)
{
    int count = 0;
    string[] resultNewArray = new string[array.Length];
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3)
        {
            resultNewArray[count] = array[i];
            count++;
        }
    }
    return resultNewArray;
}

// метод выводит массив на экран
void ShowStringArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}

ShowStringArray(arrayString);
string[] result = СhekArrayThreeCharacters(arrayString);
ShowStringArray(result);
