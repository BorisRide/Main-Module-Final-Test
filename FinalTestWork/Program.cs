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

// задаем массив 

string[] strArray = new string[3];
strArray = { "Hello", "2", "world", ":-)"};
// Проверить, что выводит на печать 
Console.WriteLine(strArray);



// 1. На основе символов строки (тип string) 
// 2. сформировать массив символов (тип char[]). 

// Метод строки ToCharArray() можно использовать, но мы тут его не использовали, т.к. ещё не умеем.

// Пример
// “Hello!” => [‘H’, ‘e’, ‘l’, ‘l’, ‘o’, ‘!’ ]

// Поле методов

// создадим метод перевода строки в массив символов
char[] StringToCharArray(string s)
{
    char[] strArray = new char[s.Length];
    for (int i = 0; i < s.Length; i++)
    {
        strArray[i] = s[i];
    }
    return strArray;
}

// получим строку от пользователя
Console.WriteLine("Введите строку ");
string str = Console.ReadLine();

// вызываем метод преобразования из строки в массив символов
char[] resArray = StringToCharArray(str);

//Далее 
// берём один элемент массива строк, уже переведённый в массив символов и проверяем количество символов в этой строке. Если количество символов в строке три, сохраняем в элемент нового массива 
// (задать массив strThreeCharArray)
if resArray.Lenght == 3
	strThreeCharArray[i] = resArray

// Пример цикла 1)
void PrintArray(char[] array)
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

//Пример цикла 2)
int CountVowels(string str)
{
    string vowels = "aeiouy";
    int count = 0;
    for (int i = 0; i < str.Length; i++)
    {
        for (int j = 0; j < vowels.Length; j++)
        {
            if (str[i] == vowels[j])
            {
                count++;
            }
        }
    }
    return count;
}

// Пример 3 
// строку Hello my world разбиваем на отдельные строки и ...(разворачиваем?)
static string ReverseWord(string strNew)
{
    string[] strNewSplit = strNew.Split(); // ["Hello", "my", "world"]

    string res = "";

    for (int i = strNewSplit.Length - 1; i >= 0; i--)
    {
        res += strNewSplit[i] + " ";
    }

    return res;
}

string strNew = "Hello my world";
string res = ReverseWord(strNew);
Console.WriteLine(res);

