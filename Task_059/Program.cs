// В прямоугольной матрице найти строку с наименьшей суммой элементов.

Console.Clear();

Console.Write("Задайте количество строк в массиве: ");
int m = int.Parse(Console.ReadLine());
Console.Write("Задайте количество столбцов в массиве: ");
int n = int.Parse(Console.ReadLine());

int[,] array = new int[m, n];
int indexMin = 0;
int sum = 0;
int min = 0;

void FillArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(1, 100);
        }
    }
}
void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        sum=0;
        for (int j = 0; j < array.GetLength(1); j++)
        {
            sum += array[i, j];
            Console.Write($"{array[i, j]}\t");
        }
        Console.WriteLine($"Сумма: {sum}");
        if (i == 0)
        {   min = sum;
            indexMin = i;
        }
        else if (sum < min) 
        {
            min = sum;
            indexMin = i;
        }
    }
}

FillArray(array);
PrintArray(array);
Console.WriteLine($"минимальная сумма строки {min}, номер строки {indexMin+1}");

Console.WriteLine();
