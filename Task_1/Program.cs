// Написать программу, которая из имеющегося массива строк формирует 
// новый массив из строк, длина которых меньше, либо равна 3 символам. 
// Первоначальный массив можно ввести с клавиатуры, либо задать на старте 
// выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, 
// лучше обойтись исключительно массивами.

// Примеры:
// [“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]
// [“1234”, “1567”, “-2”, “computer science”] → [“-2”]
// [“Russia”, “Denmark”, “Kazan”] → []


// Блок вывода одномерного массива:
void PrintArray(string[] arr)
{
    int size = arr.Length;
    Console.Write("[");
    for (int i = 0; i < size; i++)
        Console.Write($"{arr[i]} ,");
    Console.Write("]");
}

//Блок формирования одномерного массива 
// (принмает строковые значения):
string[] FillArray()
{
    int size = 4;
    string[] arr = new string[size];
    for (int i = 0; i < size; i++)
    {
        arr[i] = Console.ReadLine()!;
    }
    return arr;
}

// ~ РЕШЕНИЕ ~ :
int GetLength(string[] arr, int sizeNew)
{
    int count = 0;
    for (int k = 0; k < arr.Length; k++)
    {
        if (arr[k].Length <= sizeNew)
            count++;
    }
    return count;
}


string[] CopyMass(string[] NewMassive, int sizeNew)
{
    string[] NewArr = new string[GetLength(NewMassive, sizeNew)];
    for (int i = 0, j = 0; i < NewMassive.Length; i++)
    {
        if(NewMassive[i].Length <= sizeNew)
        {
             NewArr[j] = NewMassive[i];
            j++;
        }
       
    }
    return NewArr;
}

// Блок ввода данных размерности одномерного массива:
Console.WriteLine("Введите текст: ");
string[] mass = FillArray();

PrintArray(mass);

// ~ ВЫВОД РЕЗУЛЬТАТА РЕШЕНИЯ ~ :
Console.WriteLine();
Console.WriteLine(" -> ");
string[] mass2 = CopyMass(mass,3);
PrintArray(mass2);