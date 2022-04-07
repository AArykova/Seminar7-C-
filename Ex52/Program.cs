// Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

Console.WriteLine("Введите количество строк:");
int lines = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов:");
int columns = Convert.ToInt32(Console.ReadLine());
int[,] array = new int[lines, columns];

FillArray();
PrintArray();
ArithArray();

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

void ArithArray()
 {
     
     for (int j = 0; j < columns; j++)
    {
        int arith = 0;
        for (int i = 0; i < lines; i++)
        {
           arith += array[i,j];    
          
        }
        double middle = arith/lines;    
        int count = j + 1;
        Console.WriteLine("Сумма элементов в столбце " + count + " равна " + arith);  
        Console.WriteLine("Среднее арифметическое в столбце " + count + " равно " + middle); 
    }
 }
