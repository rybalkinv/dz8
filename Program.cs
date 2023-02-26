int programm, num;
Boolean begin = true;
 
while (begin)
{
Console.WriteLine("------");
Console.WriteLine("Введите число для соответствующей задачи или иное для выхода:");
Console.WriteLine("1.Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.");
Console.WriteLine("2.Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.");
Console.WriteLine("3.Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц");
Console.WriteLine("4.Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.");
Console.WriteLine("5.Напишите программу, которая заполнит спирально массив 4 на 4.");
programm = Convert.ToInt32(Console.ReadLine());
 
switch (programm)
{
case 1:
//Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
Console.WriteLine("введите количество строк");
int linesVol = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введите количество столбцов");
int columnsVol = Convert.ToInt32(Console.ReadLine());
int[,] numbers = new int[linesVol, columnsVol];
FillArrayRandomNumbers(numbers);
Console.WriteLine();
Console.WriteLine("Массив до изменения");
PrintArray(numbers);

for (int i = 0; i < numbers.GetLength(0); i++)
{
    for (int j = 0; j < numbers.GetLength(1) - 1; j++)
    {
        for (int z = 0; z < numbers.GetLength(1) - 1; z++)
        {
            if (numbers[i, z] < numbers[i, z + 1]) //для изменения сортировки поменять знак < на противоположный
            {
                int temp = 0;
                temp = numbers[i, z];
                numbers[i, z] = numbers[i, z + 1];
                numbers[i, z + 1] = temp;
            }
        }
    }
}
Console.WriteLine();
Console.WriteLine("Массив с упорядоченными значениями");
PrintArray(numbers);

void FillArrayRandomNumbers(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(0, 10);
        }
    }
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        Console.Write("[ ");
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.Write("]");
        Console.WriteLine("");
    }
}
 

 
break;

case 2:
// Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
Console.WriteLine("введите размер прямоугольного массива");
int massVol = Convert.ToInt32(Console.ReadLine());
int[,] numbers1 = new int[massVol, massVol];
FillArrayRandomNumbers(numbers1);
PrintArray(numbers1);
int minsum = Int32.MaxValue;
int indexLine = 0;

for (int i = 0; i < numbers1.GetLength(0); i++)
{
    int sum = 0;
    for (int j = 0; j < numbers1.GetLength(1); j++)
    {
        sum = sum + numbers1[i, j];        
    }
    if (sum < minsum)
    {
        minsum = sum;
        indexLine++;
    }
}

Console.WriteLine("строка с наименьшей суммой елементов под номером: " + (indexLine) + ", с суммой елементов равной: " + (minsum));

void FillArrayRandomNumbers12(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(0, 10);
        }
    }
}

void PrintArray12(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        Console.Write("[ ");
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.Write("]");
        Console.WriteLine("");
    }
}

break;

case 3:
// Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
int InputInt(string output)
{
    Console.Write(output);
    return int.Parse(Console.ReadLine());
}

void FillArrayRandomNumbers1(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(1, 5); 
        }
    }
}

void PrintArray1(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        Console.Write("[ ");
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.Write("]");
        Console.WriteLine("");
    }
}

int size = InputInt("размерность матриц: ");
int[,] matrixA = new int[size, size];
int[,] matrixB = new int[size, size];
FillArrayRandomNumbers1(matrixA);
FillArrayRandomNumbers1(matrixB);
int[,] matrixC = new int[size, size];

for (int i = 0; i < size; i++)
{
    for (int j = 0; j < size; j++)
    {
        for (int l = 0; l < size; l++)
        {
            matrixC[i, j] = matrixC[i, j] + (matrixA[i, l] * matrixB[l, j]);
        }
    }
}
Console.WriteLine("Матрица - А");
PrintArray1(matrixA);
Console.WriteLine();
Console.WriteLine("Матрица - В");
PrintArray1(matrixB);
Console.WriteLine();
Console.WriteLine("Произведение матриц А*В");
PrintArray1(matrixC);

break;

case 4:
//Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.

int deep1 = InputInt("Введите размерность 1: ");
int deep2 = InputInt("Введите размерность 2: ");
int deep3 = InputInt("Введите размерность 3: ");
int countNums = 89;

if (deep1 * deep2 * deep3 > countNums)
{
    Console.Write("Массив слишком большой");
    return;
}

int[,,] resultNums = Create3DMassive(deep1, deep2, deep3);

for (int i = 0; i < resultNums.GetLength(0); i++)
{
    for (int j = 0; j < resultNums.GetLength(1); j++)
    {
        for (int p = 0; p < resultNums.GetLength(2); p++)
        {
            Console.WriteLine($"[{i},{j},{p}] - {resultNums[i, j, p]}");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}


int[,,] Create3DMassive(int size1, int size2, int size3)
{
    int[,,] array = new int[size1, size2, size3];
    int[] values = new int[countNums];
    int num
     = 10;
    for (int i = 0; i < values.Length; i++)
        values[i] = num
        ++;

    for (int i = 0; i < values.Length; i++)
    {
        int randomInd = new Random().Next(0, values.Length);
        int temp = values[i];
        values[i] = values[randomInd];
        values[randomInd] = temp;
    }

    int valueIndex = 0;

    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(2); k++)
            {
                array[i, j, k] = values[valueIndex++];
            }
        }
    }
    return array;
}


int InputInt1(string output)
{
    Console.Write(output);
    return int.Parse(Console.ReadLine());
}
break;

case 5:
//Напишите программу, которая заполнит спирально массив 4 на 4.

Console.WriteLine("Введите размер массива");
int size1 = Convert.ToInt32(Console.ReadLine());

int[,] nums = new int[size1, size1];

int num1 = 1;
int t = 0;
int k = 0;

while (num1 <= size1 * size1)
{
    nums[t, k] = num1;
    if (t <= k + 1 && t + k < size1 - 1)
        ++k;
    else if (t < k && t + k >= size1 - 1)
        ++t;
    else if (t >= k && t + k > size1 - 1)
        --k;
    else
        --t;
    ++num1;
}

PrintArray(nums);

void PrintArray13(int[,] array)
{
    for (int t = 0; t < array.GetLength(0); t++)
    {
        Console.Write("[ ");
        for (int k = 0; k < array.GetLength(1); k++)
        {
            Console.Write(array[t, k] + " ");
        }
        Console.Write("k");
        Console.WriteLine("");
    }
}
break;

default:
begin = false;
break;
}
}