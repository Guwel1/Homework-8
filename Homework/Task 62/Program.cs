// Напишите программу, которая заполнит спирально массив 4 на 4.

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write(matrix[i, j] + " \t");
        }
        Console.WriteLine();
    }
}


Console.Clear();
Console.Write("Введите размер матрицы: ");
int[] size = Console.ReadLine().Split(" ").Select(x => int.Parse(x)).ToArray();
int[,] matrix = new int[size[0], size[1]];
int num = 1;
int i = 0;
int j = 0;

while (num <= size[0] * size[1])
{
    matrix[i, j] = num;
    if (i <= j + 1 && i + j < size[0] - 1)
        j++;
    else if (i < j && i + j >= size[0] - 1)
        i++;
    else if (i >= j && i + j > size[0] - 1)
        j--;
    else
        i--;
    num++;
}
PrintMatrix(matrix);

