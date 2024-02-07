// Условие:
// Задайте произвольный массив. Выведете его элементы, начиная с конца. Использовать рекурсию, не использовать циклы.


int[] СreatingArrayDigitInt() // Функция генерации масива с размером 10 из случайных целых чисел в диапазоне от -100 до 100.
{
    int[] array = new int[10]; 
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(-100, 101);
    }
    return array;
}

void ShowArray(int[] array, int indexLastElemet) // Рекурсивная функция вывода элементов массива, начиная с конца. 
{
    if (indexLastElemet == 0) // Базовый случай.
    {
         Console.Write(array[indexLastElemet]);
         return;
    }
    Console.Write($"{array[indexLastElemet]} ");
    ShowArray(array, indexLastElemet - 1);
}

int[] array = СreatingArrayDigitInt();
Console.WriteLine($"Сгенерированный масив: [{String.Join(", ", array)}]");
ShowArray(array, array.Length - 1);
