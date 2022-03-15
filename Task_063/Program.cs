// Сформировать трехмерный массив не повторяющимися двузначными числами, 
// показать его построчно на экран, выводя индексы соответствующего элемента

Console.Clear();

Console.Write("Задайте размерность массива, но не более 4: ");
int m = int.Parse(Console.ReadLine());
if(m<=4&& m>=2)
{
int[,,] array = new int[m, m, m];

void Print3DArray(int[,,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(2); k++)
                Console.Write($"[{i}.{j}.{k}] -> {array[i, j, k]}     ");
            Console.WriteLine();
        }
        Console.WriteLine();
    }
}
bool CheckDublicate(int next, int[,,] array) // проверяем сгенерированное число на оригинальность
{
    bool contains = false;
    for (int a = 0; a < array.GetLength(0); a++)
        for (int b = 0; b < array.GetLength(1); b++)
            for (int c = 0; c < array.GetLength(2); c++)
                if (array[a, b, c] == next)
                {
                    contains = true;
                    break;
                }
    return contains;
}

int[,,] Fill3DArray(int[,,] array) // заполняем массив случайными числами
{
    int next;
    for (int i = 0; i < array.GetLength(0); i++)
        for (int j = 0; j < array.GetLength(1); j++)
            for (int k = 0; k < array.GetLength(2); k++)
            {
                do
                    next = new Random().Next(10, 100);
                while (CheckDublicate(next, array));
                array[i, j, k] = next;
            }
    return array;
}
Fill3DArray(array);
Print3DArray(array);
}
else Console.WriteLine("Введенное размерность не находится в диапазоне от 2 до 4!");