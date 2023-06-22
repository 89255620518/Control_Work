// Задача
// Написать программу, которая из имеющегося массива строк формирует 
// новый массив из строк, длина которых меньше, либо равна 3 символам.
// Первоначальный массив можно ввести с клавиатуры, либо задать на старте 
// выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, 
// лучше обойтись исключительно массивами.
// Примеры:
// [“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]
// [“1234”, “1567”, “-2”, “computer science”] → [“-2”]
// [“Russia”, “Denmark”, “Kazan”] → []

// Решение 1 (с использованием двух массивов):
/*
string[] array1 = new string[5] {"123", "23", "hello", "world", "res"};
string[] array2 = new string[array1.Length];
void SecondArrayWithIF(string[] array1, string[] array2)
{
    int count = 0;
    for (int i = 0; i < array1.Length; i++)
    {
    if(array1[i].Length <= 3)
        {
        array2[count] = array1[i];
        count++;
        }
    }
}

SecondArrayWithIF(array1, array2);
PrintArray(array2);
*/

// РЕШЕНИЕ 2 (с использованием одного массива)
/*
Console.Write("Сколько элементов Вы хотите ввести? ");
int size = Convert.ToInt32(Console.ReadLine());

string [] array = new string[size];
int len = 3;
int pos = 0;

void Array (string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.WriteLine($"Введите {i+1}-й элемент: ");
        string count = Convert.ToString(Console.ReadLine());

        if (count.Length <= len)
        {
           
           array[pos] = count;
           pos++;
        }
    }
}

Array(array);
PrintArray(array);
*/


// _____________Блок вспомогательных методов_____________
//_______________________________________________________
/*
void PrintArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}
*/


