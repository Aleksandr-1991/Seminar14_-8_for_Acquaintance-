// №53. Прога в 2d-массиве мен местами 1 и последнюю строки массива.

int Promt (string text){
    Console.WriteLine(text);
    return int.Parse(Console.ReadLine()!);
}

int [,] GetMatrix()
{
    int m = Promt("Введите значение m, отвечающее за кол-во строк: ");
    int n = Promt("Введите значение n, отвечающее за кол-во столбцов: ");
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

void InvertedMatrix(int [,] matrix)
{
    for (int j = 0; j < matrix.GetLength(1); j++){
        int temp = matrix [0, j];
        matrix [0, j] = matrix [matrix.GetLength(0) - 1, j];
        matrix [matrix.GetLength(0) - 1, j] = temp;
    }
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

int [,] matrix = GetMatrix();
PrintMatrix(matrix);
InvertedMatrix(matrix);
PrintMatrix(matrix);