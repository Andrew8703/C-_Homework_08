// Найти произведение двух матриц

Console.Clear();

Console.Write("Задайте размерность перемножаемых матриц: ");
int m = int.Parse(Console.ReadLine());

int[,] arrayA = new int[m, m];
int[,] arrayB = new int[m, m];
int[,] arrayC = new int[m, m];  // произведение массивов

void FillArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(1, 10);
        }
    }
}
void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]}\t");
        }
        Console.WriteLine();
    }
}

FillArray(arrayA);
FillArray(arrayB);
Console.WriteLine("Первый массив: ");
PrintArray(arrayA);
Console.WriteLine("Второй массив: ");
PrintArray(arrayB);
 
for (int i = 0; i < arrayA.GetLength(0); ++i)
    for (int j = 0; j < arrayB.GetLength(0); ++j)
        for (int k = 0; k < arrayB.GetLength(1); ++k)
            arrayC[i, k] += arrayA[i, j] * arrayB[j, k];

Console.WriteLine("Произведение: ");
PrintArray(arrayC);

Console.WriteLine();
