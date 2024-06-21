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

// 1 
// Метод перевода строки в массив символов 
// на основе символов строки (тип string) формируем массив символов (тип char[]). 
// по схеме “World” => [‘W’, ‘o’, ‘r’, ‘l’, ‘d’]
char[] StringToCharArray(string s)
{
    char[] strArray = new char[s.Length];
    for (int i = 0; i < s.Length; i++)
    {
        strArray[i] = s[i];
    }
    return strArray;
}

// 2
// Метод печати массива строк
void PrintArray(string[] array)
{
    Console.Write("[");
    for (int j = 0; j < array.Length; j++)
    {
        if (j < array.Length - 1)
            Console.Write($"\"{array[j]}\", ");
        else
            Console.Write($"\"{array[j]}\"");
    }
    Console.WriteLine("]");
}

// Поле программы 


// Тестирование по готовому набору данных

// Тестирование по первому набору данных +
// string[] strArray = new string[4] { "Hello", "2", "world", ":-)" };

// Тестирование по второму набору данных +
// string[] strArray = new string[4] { "1234", "1567", "-2", "computer science" };

// Тестирование по третьему набору данных +
// string[] strArray = new string[3] { "Russia", "Denmark", "Kazan" };

// Ввод массива строк с клавиатуры
// ввод размера массива строк
Console.Write("Введите размер массива строк: ");
int lengthArray = Convert.ToInt32(Console.ReadLine());

// ввод строк массива с клавиатуры
string[] strArray = new string[lengthArray];
Console.WriteLine("Поочередно введите строки массива строк: ");
for (int k = 0; k < lengthArray; k++)
{
    strArray[k] = Convert.ToString(Console.ReadLine());
}

// определяем количество элементов массива с длиной строки менее или равной трем
int numThreeString = 0;
for (int l = 0; l < strArray.Length; l++)
{
    int numString = StringToCharArray(strArray[l]).Length;
    if (numString <= 3)
    {
        numThreeString++;
    }
}

// объявляем массив, содержащий только строки длиной менее или равной трем
string[] strThreeArray = new string[numThreeString];

// заполняем массив strThreeArray строками длиной менее или равной трем
int m = 0;
for (int n = 0; n < strArray.Length; n++)
{
    int numString = StringToCharArray(strArray[n]).Length;
    if (numString <= 3)
    {
        strThreeArray[m] = strArray[n];
        m++;
    }
}

// Печатаем исходный массив
PrintArray(strArray);
Console.WriteLine(); // Печать пустой строки

// Печатаем массив строк с длиной менее или равной трем
PrintArray(strThreeArray);

// Конец