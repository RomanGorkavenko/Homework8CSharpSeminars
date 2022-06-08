

int[] rndArray = RandomArray(90);
int[,,] numberArray = GetFillArray(rndArray);

PrintArray(numberArray);
Console.WriteLine();

int[] RandomArray(int length)
{
    Random rnd = new Random();
    int[] number = new int[length];
    for (int i = 0; i < number.Length; i++)
    {
        int a = rnd.Next(10, 100);
        if (!number.Contains(a))
        {
            number[i] = a;
        }
        else
            i--;
    }
    return number;
}

int[,,] GetFillArray(int[] number)
{
    int[,,] array = new int[2, 2, 2];
    int h = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(2); k++)
            {
                array[i, j, k] = number[h];
                h++;
            }
        }
    }
    return array;
}

void PrintArray(int[,,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(2); k++)
            {
                Console.WriteLine($"Элемент = {array[i, j, k]}; индекс = [{i},{j},{k}] ");
            }
        }
    }
}


