// Написать программу, которая из имеющегося массива строк формирует массив из строк, 
// длина которых меньше либо равна 3 символа. 
// Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. 
// При решение не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами

Console.Clear();
string[] array = new string[4] { "Russia", "Denmark", "Kazan", "Ufa"};
string[] newArray = new string[array.Length];
int sizeElements = 3;
ThreeOrLessElementMassive (array, newArray);
PrintArray(newArray);

void ThreeOrLessElementMassive (string[] array, string[] newArray)    
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= sizeElements)
        {
            newArray[count] = array[i];
            count++;
        }
        else
        {
            count++;
        }
    }
}

void PrintArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"[{array[i]}] | ");
    }
}
