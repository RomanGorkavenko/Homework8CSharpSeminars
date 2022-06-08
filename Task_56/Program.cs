int[,] randomArray = GetFillArray(4, 4);
PrintArray(randomArray);
Console.WriteLine();
int[] sumElementsArray = SumElementsRow(randomArray);
PrintOneDimensionalArray(sumElementsArray);
Console.WriteLine();
PrintResult(sumElementsArray, randomArray);
Console.WriteLine();


int[,] GetFillArray(int m, int n)
{
    int[,] array = new int[m, n];
    Random randomElement = new Random();
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = randomElement.Next(10);
        }
    }
    return array;
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j]);
        }
        Console.WriteLine();
    }
}

void PrintOneDimensionalArray(int[] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        Console.WriteLine($"Строка {i + 1} сумма элементов в строке = {array[i]};");
    }
}

int[] SumElementsRow(int[,] array)
{
    
    
    int [] summa = new int[array.GetLength(0)];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        int sum = 0;
        for (int j = 0; j < array.GetLength(1); j++)
        {
            sum += array[i,j];

        }
        summa[i] = sum;
    }
    return summa;
}

void PrintResult(int[] arr, int[,] array)
{
    int indexRow = 0;
    int min = arr[0];
    for (int i = 0; i < arr.Length; i++)
    {
        if (min > arr[i])
        {
            min = arr[i];
            indexRow = i;
        } 
    }
    Console.Write($"Строка с наименьшей суммой элементов ");
    for (int j = 0; j < array.GetLength(1); j++)
    {
        Console.Write($"{array[indexRow, j]}");
    }

}
