Console.Write("Enter number of rows of array ");
int rows = int.Parse(Console.ReadLine()!);

Console.Write("Enter number of columns of array ");
int cols = int.Parse(Console.ReadLine()!);

int[,] array = getArray(rows, cols);
printArray(array);

int[,] getArray(int m, int n) {
    int[,] newArray = new int[m, n];
    for (int i = 0; i < m; i++) {
        for (int j = 0; j < n; j++) {
            newArray[i, j] = new Random().Next(-10, 11);
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

Console.Write("Enter i-element of row: ");
int iToFind = int.Parse(Console.ReadLine()!);

Console.Write("Enter i-element of row: ");
int jToFind = int.Parse(Console.ReadLine()!);

int result = resultSearch(array, iToFind, jToFind);

int resultSearch (int[,] array, int iFind, int jFind) {
    int position = 0;
    if (iFind<array.GetLength(0) && jFind<array.GetLength(1)) {
        for (int i = 0; i < array.GetLength(0); i++) {
            for (int j = 0; j < array.GetLength(1); j++) {
                if (i==iFind && j==jFind){
                    position = array[i, j];
                    break;
                }
            }
        }
        Console.WriteLine($"Your element[{iToFind}, {jToFind}] is {position}");
    } else {
        Console.WriteLine("You've inputed incrrect indexes!");
    }
    return position;
}