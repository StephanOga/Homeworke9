// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

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

int Ackermann(int m, int n)
{
    if (m == 0) return n + 1;
    else if (n == 0) return Ackermann(m - 1, 1);
    else return Ackermann(m - 1, Ackermann(m, n - 1));
}

int m = GetValueFromUser("Введите неотрицательное целое число m для вычисления функции Аккермана");
int n = GetValueFromUser("Введите второе неотрицательное целое число n для вычисления функции Аккермана");
int result = Ackermann(m, n);
Console.WriteLine("Вычисляю...");
Console.WriteLine(result);