double[,] array = new double[5, 5];
for (int i = 0; i < array.GetLength(0); i++)
{
    for (int j = 0; j < array.GetLength(1); j++)
    {
        array[i, j] = new Random().NextDouble() * 10;
        System.Console.Write($"{array[i, j]} ");

    }
    System.Console.WriteLine();
}