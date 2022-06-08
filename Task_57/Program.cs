int[,] randomArray = GetFillArray(5, 5);
PrintArray(randomArray);
Console.WriteLine();
var dictionary = FrequencyDictionary(randomArray);
// PrintOneDimensionalArray(dictionary.number);
// Console.WriteLine();
// PrintOneDimensionalArray(dictionary.countNumber);
Console.WriteLine();
PrintDictionary(dictionary.number, dictionary.countNumber);



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
            Console.Write($"{array[i, j]} ");
        }
        Console.WriteLine();
    }
}

void PrintOneDimensionalArray(int[] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        Console.Write($"{array[i]} ");
    }
}

(int[] number, int[] countNumber) FrequencyDictionary(int[,] array)
{
    int count = 0;
    int[] number = new int[array.GetLength(0) * array.GetLength(1)];
    int[] countNumber = new int[array.GetLength(0) * array.GetLength(1)];
    int g = 0;

    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            count = 0;
            for (int k = 0; k < array.GetLength(0); k++)
            {
                for (int h = 0; h < array.GetLength(1); h++)
                {
                    if (array[i, j] == array[k, h])
                    {
                        count++;
                    }

                }
            }
            countNumber[g] = count;
            number[g] = array[i, j];
            g++;



        }
    }
    return (number, countNumber);
}

void PrintDictionary(int[] number, int[] countNumber)
{
    bool flag = false;
    bool flag1 = true;
    for (int i = 0; i < number.Length; i++)
    {
        flag1 = true;

        for (int h = 0; h < i; h++)
        {
            if (number[i] == number[h])
            {
                flag1 = false;
            }
        }
        if (flag1)
        {
            flag = false;
            for (int j = 0; j < number.Length; j++)
            {
                if (number[i] == number[j])
                {
                    if (!flag)
                    {
                        string score = "раз";
                        if(countNumber[i] > 1 && countNumber[i] < 5) score = "раза";
                        Console.WriteLine($"{number[i]} встречается {countNumber[i]} {score}");
                        flag = true;
                    }
                }
            }
        }
    }
}
