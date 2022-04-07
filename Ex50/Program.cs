//  Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
//и возвращает значение этого элемента или же указание, что такого элемента нет.

Console.WriteLine("Введите количество строк:");
int lines = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов:");
int columns = Convert.ToInt32(Console.ReadLine());
int[,] array = new int[lines, columns];

FillArray();
PrintArray();

Console.WriteLine("Введите номер строки элемента");
int newI = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите номер столбца элемента");
int newJ = Convert.ToInt32(Console.ReadLine());

if (newI >= lines || newJ >= columns)
    {
        Console.WriteLine("Элемента с таким индексом нет");
    }
else
{
    Console.WriteLine("Ваш элемент равен = " + array[newI, newJ]);
}

void FillArray()
{
    Random rand = new Random();
    for (int i = 0; i < lines; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            array[i, j] = rand.Next(0, 10);
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
