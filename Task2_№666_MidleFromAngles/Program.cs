// №666. Прога считает среднее-арифм меж эл-тами в углах 2d-массива.

int Promt (string text){
    Console.WriteLine(text);
    return int.Parse(Console.ReadLine()!);
}

int[,] GenerateRandomMatrix()
{
    int m = Promt("Введите значение m, отвечающее за кол-во строк: ");
    int n = Promt("Введите значение n, отвечающее за кол-во столбцов: ");
    int[,] array = new int[m, n];
    for (int i = 0; i < m; i++){
        for (int j = 0; j < n; j++){
            array[i, j] = new Random().Next(0, 10);
        }
    }
    return array;
}

void PrintMatrix (int [,]  matrix){
    Console.Write("[");
    for (int i = 0; i < matrix.GetLength(0); i++){
        if (i == matrix.GetLength(0) - 1){
            for (int j = 0; j < matrix.GetLength(1); j++){
                if (j == matrix.GetLength(1) - 1)  Console.Write($"{matrix[i, j]:f1}");
                else Console.Write ($"{matrix[i, j]:f1}\t");
            }
            Console.WriteLine("]");
        }
        else{
            for (int j = 0; j < matrix.GetLength(1); j++) Console.Write($"{matrix[i, j]:f1}\t");
        }
        Console.WriteLine();
    }
}

int[,] array = GenerateRandomMatrix();
PrintMatrix(array);
Console.Write("Среднее арифметическое меж эл-тами в углах массива равно: ");
Console.Write((array[0, 0] 
+ array[array.GetLength(0) - 1, 0] 
+ array[array.GetLength(0) - 1, array.GetLength(1) - 1] 
+ array[0, array.GetLength(1) - 1])/4.0);