// Спирально заполнить двумерный массив:

Console.Clear();

Console.Write("Введите размерность массива: ");
int n = int.Parse(Console.ReadLine());

int[,] array = new int[n, n];
int temp = 1;
int i = 0;
int j = 0;
while (temp <= n * n)
{
    array[i,j] = temp;
    if (i <= j + 1 && i + j < n - 1)
        ++j;
    else if (i < j && i + j >= n - 1)
        ++i;
    else if (i >= j && i + j > n - 1)
        --j;
    else
        --i;
    ++temp;
}
for (int a = 0; c < array.GetLength(0); a++)
{
    for (int b = 0; d < array.GetLength(1); b++)
    {
        Console.Write( $"{array[a,b]}\t ");
    }
    Console.WriteLine();
}
Console.WriteLine();
