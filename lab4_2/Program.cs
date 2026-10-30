Random rnd = new Random();
int m = 3;
int n = 4;
int[,] a = new int[m, n];
Console.WriteLine("Исходная матрица:");
for (int i = 0; i < m; i++)
{
    for (int j = 0; j < n; j++)
    {
        a[i, j] = rnd.Next(-10, 21);
        Console.Write(a[i, j] + "");
    }
    Console.WriteLine();
}
int[] b = new int[m * n];
int k = 0;
long p = 1;
for (int i = 0; i < m; i++)
{
    for (int j = 0; j < n; j++)
    {
        if (a[i, j] >= 1 && a[i, j] <= 10)
        {
            b[k] = a[i, j];
            k++;
        }
    }
}
Console.WriteLine("\nОдномерный массив:");
for (int i = 0; i < k; i++)
{
    Console.Write(b[i] + " ");
    p *= b[i];
}
Console.WriteLine("\nПроизведение элементов: " + p);