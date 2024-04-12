// №55. Прога в 2d-массиве мен местами столбцы и строки.

int GetNumber(string message)
{
    Console.WriteLine(message);
    bool isCorrect = false;
    int result = 0;
    while (!isCorrect)
        if (int.TryParse(Console.ReadLine()!, out result))
            isCorrect = true;
        else
            Console.WriteLine("Введено не число (либо не целое число). Повторите ввод.");

    return result;
}

int [,] GetMatrix()
{
    int m = GetNumber("Введите значение m, отвечающее за кол-во строк: ");
    int n = GetNumber("Введите значение n, отвечающее за кол-во столбцов: ");
    int k = 0;
    int [,]  array2d = new int [m, n];
    for (int i = 0; i < m; i++){
        for (int j = 0; j < n; j++){  
            // array2d [i, j] = new Random().Next(1, 10);
            array2d [i, j] = k;
            k++;
        }
    }
    return array2d;
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

int [,] Transposition(int [,] matrix)
{
    int [,] transpositionMatrix = new int [matrix.GetLength(1), matrix.GetLength(0)];
    for (int i = 0; i < matrix.GetLength(1); i++){
        for (int j = 0; j < matrix.GetLength(0); j++){
            transpositionMatrix [i, j] = matrix [j, i];
        }
    }
    return transpositionMatrix;
}

int [,] matrix = GetMatrix();
PrintMatrix(matrix);
int [,] transpositionMatrix = Transposition(matrix);
PrintMatrix(transpositionMatrix);