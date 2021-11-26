int[,] CreateArray = new int[5, 10];
for (int i = 0; i < CreateArray.GetLength(0); i++)
{
    for (int j = 0; j < CreateArray.GetLength(1); j++)
    {
        CreateArray[i, j] = new Random().Next(1, 10);

        System.Console.Write($"{CreateArray[i, j]} ");
    }
    System.Console.WriteLine();
}

