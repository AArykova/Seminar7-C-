// Задайте двумерный массив размером mхn, заполненный случайными вещественными числами

Console.WriteLine("Введите количество строк:");
int lines = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов:");
int columns = Convert.ToInt32(Console.ReadLine());
double[,] array = new double[lines, columns];

FillArray();
PrintArray();

void FillArray()
{
    Random rand = new Random();
    for (int i = 0; i < lines; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            array[i, j] = rand.NextDouble()*10-10;
        }
    }
}

void PrintArray()
{
    for (int i = 0; i < lines; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine();
    }
}