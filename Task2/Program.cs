// Условие:
// Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n

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

int CalculationsAckermanFunction(int m, int n) // Рекурсивная функция вычисления функции Аккермана
{
    if (m == 0)
    {
        return n + 1;  // Базовый случай
    }
    else if (m > 0 && n == 0)
    {
        return CalculationsAckermanFunction(m -1, 1);
    } 
    else
    {
        return CalculationsAckermanFunction(m - 1, CalculationsAckermanFunction(m, n -1));
    }
}

Console.Clear(); // очистим консоль для красоты вывода.

int firstNumber = RequestingNumber(); // m - в формуле функции Аккермана
int secondNumber = RequestingNumber(); // n - в формуле функции Аккермана

int result = CalculationsAckermanFunction(firstNumber, secondNumber);
Console.WriteLine($"Функция Аккермана от m = {firstNumber} и n = {secondNumber }");
Console.WriteLine("вычисляемая по формуле:");
Console.WriteLine("A(m,n) = n + 1, если m = 0");
Console.WriteLine("A(m,n) = A(m - 1, 1), если m > 0 и n = 0");
Console.WriteLine("A(m,n) = A(m - 1, A(m, n - 1)), если m > 0 и n > 0");
Console.WriteLine($"равна: {result}");