// Задача: Написать программу, 
// 1. которая из имеющегося массива строк  
// 2. формирует новый массив из строк, длина которых меньше, либо равна 3 символам. 
// Первоначальный массив можно ввести с клавиатуры, 
// либо задать на старте выполнения алгоритма. 
// При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.

// Примеры:
// [“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]
// [“1234”, “1567”, “-2”, “computer science”] → [“-2”]
// [“Russia”, “Denmark”, “Kazan”] → []


// Поле методов

// Метод перевода строки в массив символов 
// на основе символов строки (тип string) формируем массив символов (тип char[]). 
// метод строки ToCharArray() можно использовать, но мы тут его не использовали, т.к. ещё не умеем.
// по схеме “Hello!” => [‘H’, ‘e’, ‘l’, ‘l’, ‘o’, ‘!’ ]
char[] StringToCharArray(string s)
{
    char[] strArray = new char[s.Length];
    for (int i = 0; i < s.Length; i++)
    {
        strArray[i] = s[i];
    }
    return strArray;
}

// Метод печати массива строк
void PrintArray(string[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        if (i < array.Length - 1)
            Console.Write($"{array[i]}, ");
        else
            Console.Write($"{array[i]}");
    }
    Console.WriteLine("]");
}

// задаем массив 

// получение массива строк от пользователя
// ввод одной сторки
// Console.WriteLine("Введите строку ");
// string str = Console.ReadLine();

// Тестирование по первому набору данных +
// string[] strArray = new string[4] { "Hello", "2", "world", ":-)" };

// Тестирование по второму набору данных +
// string[] strArray = new string[4] { "1234", "1567", "-2", "computer science" };

// Тестирование по третьему набору данных
string[] strArray = new string[3] { "Russia", "Denmark", "Kazan" };

// Проверить, что выводит на печать 
// Console.WriteLine(strArray);

// берем по порядку строки из массива строк
int numThreeString = 0;
for (int i = 0; i < strArray.Length; i++)
{
    // string str = strArray[i]; попытка упростить запись строки ниже
    int numString = StringToCharArray(strArray[i]).Length;
    if (numString <= 3)
    {
        numThreeString++;
    }
}
// объявляем массив со строками длиной менее трех символов
string[] strThreeArray = new string[numThreeString];

// заполняем массив strThreeArray
int k = 0;
for (int j = 0; j < strArray.Length; j++)
{
    int numString = StringToCharArray(strArray[j]).Length;
    if (numString <= 3)
    {
        strThreeArray[k] = strArray[j];
        k++;
    }
}

// печать массива

PrintArray(strArray);
Console.WriteLine(); // Печать пустой строки
PrintArray(strThreeArray);

// Final