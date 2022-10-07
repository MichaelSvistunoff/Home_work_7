Console.WriteLine("Enter number of rows of array ");
int rows = int.Parse(Console.ReadLine()!);

Console.WriteLine("Enter number of columns of array ");
int cols = int.Parse(Console.ReadLine()!);

int[,] array = getArray(rows, cols);
printArray(array);
sumOfCols(array);

int[,] getArray(int m, int n) {
    int sumOfRow = 0;
    int[,] newArray = new int[m, n];
    for (int i = 0; i < m; i++) {
        for (int j = 0; j < n; j++) {
            newArray[i, j] = new Random().Next(1, 10);
            sumOfRow += newArray[i, j];
        }
    }
    return newArray;
}

void printArray (int[,] array) {
    for (int i = 0; i < array.GetLength(0); i++) {
        for (int j = 0; j < array.GetLength(1); j++) {
            Console.Write($"{array[i,j]} ");
        }
        Console.WriteLine();
    }
}

double sumOfCols (int[,] array) {
    double resultOfCols = 0;
    for (int i = 0; i < array.GetLength(1); i++) {        
        double sum = 0;
        for (int j = 0; j < array.GetLength(0); j++) {  
            sum += array[j, i];
        }
        resultOfCols = sum/rows;
        Console.WriteLine($"Среднее арифметическое строки-{i} = {Math.Round(resultOfCols, 1)}");
    }
    return resultOfCols;
}