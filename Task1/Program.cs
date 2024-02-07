// Условие:
// Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N. 
// Использовать рекурсию, не использовать циклы.

bool IsAllDigits(string enterLine ) // Функция проверки, что ввели число.
{
    foreach (char symbol in enterLine)
    {
        if (!char.IsDigit(symbol))  
            return false;
    }
    return true;
}

int RequestingNumber() // функция запроса у пользователя числа.
{
    string enterLine;
    int number;
    Console.Write("Введите целое неотрицательное число:");
    while (true)
    {
        enterLine = Console.ReadLine()!; // NULL проверка в следующей строке
        if (IsAllDigits(enterLine) && enterLine!="")
        {
            number = Convert.ToInt32(enterLine);
            return number;
        }
        else
        {
            Console.WriteLine("Вы ввели некоректное значение, повторите ввод!");
        }
    }
}

void ShowNumbers(int start, int end) // Рекурсивная функция печати чисел
{
    if (start == end) // Базовый случай
    {
        if (start != 0) Console.Write(start); // Исключаем печать "0", так как он не является натуральным числом.
        return; 
    }
    if (start != 0) Console.Write(start + " "); // Исключаем печать "0", так как он не является натуральным числом.
    ShowNumbers(start + 1, end);
}

Console.Clear(); // очистим консоль для красоты вывода.

int firstNumber = RequestingNumber();
int secondNumber = RequestingNumber();

if (firstNumber < secondNumber)
{
    ShowNumbers(firstNumber, secondNumber);
}
else
{
    ShowNumbers(secondNumber,firstNumber);
}