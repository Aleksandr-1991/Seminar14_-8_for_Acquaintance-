using System;
public class Answer
{
    public static void MultiplyIfPossible(int[,] matrixA, int[,] matrixB)
    { // Введите свое решение ниже
        if (matrixA.GetLength(1) != matrixB.GetLength(0)) {
            Console.WriteLine("It is impossible to multiply.");
        }
        else {
            PrintMatrix(MatrixMultiplication(matrixA, matrixB));
        }
    }
    public static int[,] MatrixMultiplication(int[,] matrixA, int[,] matrixB)
    { // Введите свое решение ниже
        int[,] resultMatrix = new int[matrixA.GetLength(0), matrixB.GetLength(1)];
        for (int i = 0; i < resultMatrix.GetLength(0); i++) {
            for (int j = 0; j < resultMatrix.GetLength(1); j++) {
                for (int k = 0; k < matrixA.GetLength(1); k++) {
                    resultMatrix[i, j] += matrixA[i, k] * matrixB[k, j];
                }
            }
        }
        return resultMatrix;
    }
    public static void PrintMatrix(int[,] matrix)
    {  // Введите свое решение ниже
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                Console.Write($"{matrix[i, j]:f0}\t");
            }
            Console.WriteLine();
        }
    }
    public static void Main(string[] args) // Не удаляйте и не меняйте метод Main!
    {
        int[,] matrix;
        if (args.Length == 0)
        { // Если аргументы не переданы, используем матрицу по умолчанию
            matrix = new int[,]
            {
                    {5, 2, 3},
                    {8, 1, 7}
            };
        }
        else
        { // Иначе, парсим аргументы в двумерный массив
            string[] rows = args[0].Split(';');
            matrix = new int[rows.Length, rows[0].Split(',').Length];
            for (int i = 0; i < rows.Length; i++)
            {
                string[] elements = rows[i].Split(',');
                for (int j = 0; j < elements.Length; j++)
                {
                    if (int.TryParse(elements[j], out int number))
                    {
                        matrix[i, j] = number;
                    }
                    else
                    {
                        Console.WriteLine($"Ошибка при парсинге аргумента {elements[j]}.");
                        return;
                    }
                }
            }
        }
        Console.WriteLine("Исходная матрица:");
        PrintMatrix(matrix);
        int[,] matrixB = {
                {5, 6},
                {7, 8},
                {9, 10}
            };
        Console.WriteLine("\nMatrix B:");
        PrintMatrix(matrixB);
        Console.WriteLine("\nMultiplication result:");
        MultiplyIfPossible(matrix, matrixB);
    }
}