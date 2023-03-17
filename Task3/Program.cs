// Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. 
// Выполнить с помощью рекурсии.
// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

int GetValueFromUser(string text)
{
    int value = 0;
    bool flag = false;
    while (!flag)
    {
        Console.WriteLine(text);
        flag = int.TryParse(Console.ReadLine(), out value);
    }
    return value;
}

string NumberRecursion(int number)
{
    if (number == 1) return $"{1}";
    else if (number > 1) return number + ", " + NumberRecursion(number - 1) + " ";
    else return String.Empty;
}

int n = GetValueFromUser("Введите натуральное число: ");
string s = NumberRecursion(n);
Console.WriteLine(s);