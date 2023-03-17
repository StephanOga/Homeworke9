// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

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

int SumRecursion(int little, int big)
{
    if (little == big) return big;
    else return little + SumRecursion(little+1, big);
}

bool CheckingNumbers(int little, int big)
{
    if (little <= big) return true;
    else return false;
}

int m = GetValueFromUser("Введите натуральное число");
int n = GetValueFromUser("Введите натуральное число, большее предыдущего");

int sum = 0;
bool check = CheckingNumbers(m,n);
if (check)
{
    sum = SumRecursion(m,n);
    Console.WriteLine("суммf этих чисел и всех натуральных чисел в промежутке между ними: " + sum);
}
else Console.WriteLine("Второе число должно  быть больше предыдущего");