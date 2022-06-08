
// Ввод, кол-во строк и кол-во столбцов: Значения должны быть равны.
int lengthM = 4;
int lengthN = 4;

var randomArray = GetFillArray(lengthM, lengthN);
// PrintArray(randomArray.arrayNumber);
// Console.WriteLine();
var arraySpiral = GetArray(lengthM, lengthN, randomArray.number, randomArray.arrayNumber);
// PrintArray(arraySpiral.arrayNum);
// Console.WriteLine();
int[,] spiral = SpiralCentre(lengthM, lengthN, arraySpiral.num, arraySpiral.arrayNum);
PrintArray(spiral);


(int[,] arrayNumber, int number) GetFillArray(int m, int n)
{
    int[,] array = new int[m, n];
    int number = 1;

    for (int i = 0; i < n; i++)
    {
        array[0, i] = number;
        number++;
    }
    for (int j = 1; j < m; j++)
    {
        array[j, m - 1] = number;
        number++;
    }
    for (int i = n - 2; i >= 0; i--)
    {
        array[m - 1, i] = number;
        number++;
    }
    for (int j = m - 2; j > 0; j--)
    {
        array[j, 0] = number;
        number++;
    }

    return (array, number);
}

(int[,] arrayNum, int num) GetArray(int m, int n, int number, int[,] array)
{
    int i = 1;
    int j = 1;
    while (number < m * n)
    {
        while (array[i, j + 1] == 0)
        {
            array[i, j] = number;
            number++;
            j++;
        }
        while (array[i + 1, j] == 0)
        {
            array[i, j] = number;
            number++;
            i++;
        }
        while (array[i, j - 1] == 0)
        {
            array[i, j] = number;
            number++;
            j--;
        }
        while (array[i - 1, j] == 0)
        {
            array[i, j] = number;
            number++;
            i--;
        }
    }
    return (array, number);
}

int[,] SpiralCentre(int m, int n, int number, int[,] array)
{
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            if (array[i, j] == 0)
            {
                array[i, j] = number;
            }
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
            if (array[i,j] < 10)
            {
                Console.Write($"{array[i, j]}  ");
            }
            else
            {
                Console.Write($"{array[i, j]} ");
            }
        }
        Console.WriteLine();
    }
}
