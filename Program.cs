/*Напишите программу, которая на вход принимает позиции элемента
 в двумерном массиве, и возвращает значение этого элемента или же указание, 
что такого элемента нет.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
17 -> такого числа в массиве нет*/

int GetNumber(string message)

{

    Console.WriteLine(message);
    int number = int.Parse(Console.ReadLine()!);
    return number;
}

int[,] InitMatrix(int m, int n)
{
    int[,] resultMatrix = new int[m, n];
    Random rnd = new Random();

    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            resultMatrix[i, j] = rnd.Next(-10, 10);
        }
    }

    return resultMatrix;
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)

        {

            Console.Write($"{matrix[i, j]}       ");
        }

        Console.WriteLine();
    }
}


int m = GetNumber("Введите число m:");
int n = GetNumber("Введите число n:");
int[,] matrix = InitMatrix(m, n);
int k = GetNumber("Введите номер в сторке:");
int l = GetNumber("Введите номер в столбце:");
PrintMatrix(matrix);

if (k <= m || l <= n) Console.WriteLine($"Число с таким индексом в массиве есть-->{matrix[k-1,l-1]}");
else
{
    Console.WriteLine($"Число с таким индексом в массиве отсутствует     {k}{l} ");
}
