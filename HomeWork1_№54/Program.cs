// № 54 Дом. 1.  Прога задаёт 2d массив и сортирует чтобы элементы в каждой строке шли по убыванию.

int GetNumber(string message)
{
    Console.WriteLine(message);
    bool isCorrect = false;
    int result = 0;
    while (!isCorrect)
        if (int.TryParse(Console.ReadLine()!, out result))
            isCorrect = true;
        else
            Console.WriteLine("Введено не число. Повторите ввод.");

    return result;
}
int[,] CreateRandomMatrix(int n, int m)
{
    int[,] array2d = new int[n, m];
    for (int i = 0; i < array2d.GetLength(0); i++)
    {
        for (int j = 0; j < array2d.GetLength(1); j++)
        {
            array2d[i, j] = new Random().Next(100);
        }
    }
    return array2d;
}
void PrintArray2d(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j]:f0}\t");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

int count = 0;
int[,] SortRowsDescending(int[,] matrix)
{
// /*
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1) - 1; j++)
        {
            for (int k = matrix.GetLength(1) - 1; k > j; k--)
            {
                count++;
                if (matrix[i, k] > matrix[i, k - 1])
                {
                    int temp = matrix[i, k];
                    matrix[i, k] = matrix[i, k - 1];
                    matrix[i, k - 1] = temp;
                }
            }
        }
    }
//*/

// 
/*
        for (int i = 0; i < matrix.GetLength(0); i++) {
            for (int j = 0; j < matrix.GetLength(1) - 1; j++) {
                int max = j;
                for (int k = j + 1; k < matrix.GetLength(1); k++) {
                    count++;
                    if (matrix[i, max] < matrix[i, k]) max = k;
                }
                var temp = matrix[i, max];
                matrix[i, max] = matrix[i, j];
                matrix[i, j] = temp;
            }
        }
//*/
    return matrix;
}
int n = GetNumber("Введите число n, отвечающее за количество строк: ");
int m = GetNumber("Введите число m, отвечающее за количество столбцов: ");

int[,] matrix = CreateRandomMatrix(n, m);
PrintArray2d(matrix);
int[,] resultMatrix = SortRowsDescending(matrix);
PrintArray2d(resultMatrix);
Console.Write($"Кол-во проверок if = {count}");