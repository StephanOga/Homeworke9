public static class Library3Darrays
{
    public static int[,,] Create3Darray(int rows, int columns, int depth)
    {
        return new int[rows, columns, depth];
    }

    public static int GetValueFromUser(string text)
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

    public static void Fill3DArrayWithRandomNumbers(int[,,] array3D)
    {
        for (int i = 0; i < array3D.GetLength(0); i++)
        {
            for (int j = 0; j < array3D.GetLength(1); j++)
            {
                for (int k = 0; k < array3D.GetLength(2); k++)
                {
                    array3D[i, j, k] = new Random().Next(10, 100);
                }
            }
        }
    }

    public static string Print3D(int[,,] array3D)
    {
        string result = String.Empty;
        for (int k = 0; k < array3D.GetLength(2); k++)
        {
            for (int i = 0; i < array3D.GetLength(0); i++)
            {
                for (int j = 0; j < array3D.GetLength(1); j++)
                {
                    result += $"{array3D[i, j, k],3} ({i}, {j}, {k}) ";
                }
                result += "\n";
            }
            result += "\n";
        }
        return result;
    }
}