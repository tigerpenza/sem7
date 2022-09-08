// CЕМИНАр ЗАДАЧА В ОБЩЕМ ЗАЛЕ 
// Задайте двумерный массив размером m×n, заполненный случайными целыми числами.

// int[,] CreateRandom2Array(int rows, int columns, int minValue, int maxValue)
// {
//     int[,] newArray = new int[rows, columns];

//     for(int i = 0; i < rows; i++)
//     {
//         for(int j = 0; j < columns; j++)
//         {
//             newArray[i,j] = new Random().Next(minValue, maxValue + 1);   
//         }
//     }

//     return newArray;
// }

// void ShowArray2(int[,] array)
// {
//     for(int i = 0; i < array.GetLength(0); i++)
//     {
//         for(int j = 0; j < array.GetLength(1); j++)
//             Console.Write(array[i,j] + " ");

//         Console.WriteLine();
//     }
// }

// Console.WriteLine("Input number of rows: ");
// int m = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Input number of colums: ");
// int n = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Input the min possible value: ");
// int min = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Input the max possible value: ");
// int max = Convert.ToInt32(Console.ReadLine());

// int[,] newArray = CreateRandom2Array(m, n, min, max);
// ShowArray2(newArray);





// Задайте двумерный массив размера m на n, каждый элемент в массиве находится по формуле: Aij = i+j. Выведите полученный массив на экран.
// Задайте двумерный массив. Найдите элементы, у которых оба индекса чётные, и замените эти элементы на их квадраты.
// Задайте двумерный массив. Найдите сумму элементов, находящихся на главной диагонали (с индексами (0,0); (1;1) и т.д.

// 1z. Аргумент строка.столбец. Итог массив. 2з - массив -массив (метод преобразования). 3з - инт сумму элементов найти.


// int[,] Create2dArray()  
// {
//     Console.WriteLine("Введите количество строк: ");
//     int m = Convert.ToInt32(Console.ReadLine());
//     Console.WriteLine("Введите количество столбцов: ");
//     int n = Convert.ToInt32(Console.ReadLine());
//     Console.WriteLine("Введите минимальное значение в массиве: ");
//     int minValue = Convert.ToInt32(Console.ReadLine());
//     Console.WriteLine("Введите максимальное значение в массиве: ");
//     int maxValue = Convert.ToInt32(Console.ReadLine());

//     int[,] newArray = new int[m, n];

//     for (int i = 0; i < m; i++)
//     {
//         for (int j = 0; j < n; j++)
//         {
//             newArray[i, j] = i + j;
//         }
//     }
//     return newArray;
// }

// void Show2dArray(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//             Console.Write(array[i, j] + "  ");
//         Console.WriteLine();
//     }
//     Console.WriteLine();
// }
// int[,] newArray = Create2dArray();
// Show2dArray(newArray);


// Задайте двумерный массив. Найдите элементы, у которых оба индекса чётные, и замените эти элементы на их квадраты.


// int[,] Create2dArray()
// {
//     Console.WriteLine("Введите количество строк: ");
//     int m = Convert.ToInt32(Console.ReadLine());
//     Console.WriteLine("Введите количество столбцов: ");
//     int n = Convert.ToInt32(Console.ReadLine());
//     Console.WriteLine("Введите минимальное значение в массиве: ");
//     int minValue = Convert.ToInt32(Console.ReadLine());
//     Console.WriteLine("Введите максимальное значение в массиве: ");
//     int maxValue = Convert.ToInt32(Console.ReadLine());

//     int[,] newArray = new int[m, n];

//     for (int i = 0; i < m; i++)
//     {
//         for (int j = 0; j < n; j++)
//         {
//             newArray[i, j] = new Random().Next(minValue, maxValue + 1);
//         }
//     }
//     return newArray;
// }

// void Show2dArray(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//             Console.Write(array[i, j] + "  ");
//         Console.WriteLine();
//     }
//     Console.WriteLine();
// }

// int[,] NewArray(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             if (i % 2 == 0 && j % 2 == 0) array[i, j] *= array[i, j];
//         }

//     }
//     return array;
// }

// int[,] newArray = Create2dArray();
// Show2dArray(newArray);

// Show2dArray(NewArray(newArray));



// Задайте двумерный массив. Найдите сумму элементов, находящихся на главной диагонали (с индексами (0,0); (1;1) и т.д.


// int[,] Create2dArray()
// {
//     Console.WriteLine("Введите количество строк: ");
//     int m = Convert.ToInt32(Console.ReadLine());
//     Console.WriteLine("Введите количество столбцов: ");
//     int n = Convert.ToInt32(Console.ReadLine());
//     Console.WriteLine("Введите минимальное значение в массиве: ");
//     int minValue = Convert.ToInt32(Console.ReadLine());
//     Console.WriteLine("Введите максимальное значение в массиве: ");
//     int maxValue = Convert.ToInt32(Console.ReadLine());

//     int[,] newArray = new int[m, n];

//     for (int i = 0; i < m; i++)
//     {
//         for (int j = 0; j < n; j++)
//         {
//             newArray[i, j] = new Random().Next(minValue, maxValue + 1);
//         }
//     }
//     return newArray;
// }
// void Show2dArray(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//             Console.Write(array[i, j] + "  ");
//         Console.WriteLine();
//     }
//     Console.WriteLine();
// }

// int Sum (int[,] array)
// {
//     int sum = 0;
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             if (i == j) sum += array[i,j];
//         }

//     }
//     return sum;
// }

// int[,] newArray = Create2dArray();
// Show2dArray(newArray);

// Console.WriteLine(Sum(newArray));





// int a = 5;
// Shownum(a);

// Console.WriteLine (a);
// Console.WriteLine ("---------");

// int [] arr = {3, 15, 7};
// ChangeArray(arr);
// Console.WriteLine (arr [0]);

// void Shownum( int num)
// {
//     num+=5;
//     Console.WriteLine (num);

// }


// void ChangeArray(int [] array)
// {
//     array [0] += 5;
//     Console.WriteLine (array [0]);


// }



// ДЗ  Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

double[,] GreateArray2()
{

    // Console.WriteLine("введите максимально число массива: ");
    // int max = Convert.ToInt32(Console.ReadLine());
    // Console.WriteLine("введите минимальное число массива: ");
    // int min = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("введите колличество столбцов: ");
    int n = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("введите колличество строк ");
    int m = Convert.ToInt32(Console.ReadLine());

    double[,] newArray = new double[m, n];

    for (int i = 0; i < n; i++)
    {
        for (int j = 0; j < m; j++)
        {
            newArray[i, j] = new Random().NextDouble() + new Random().Next(1, 9);
            newArray[i, j] = Math.Round(newArray[i, j], 3);
        }
    }
    return newArray;
}

void ShowArray(double[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {

            System.Console.Write(array[i, j] + " ");
        }
    } System.Console.WriteLine();


}

double [,] ArrB = GreateArray2();
ShowArray (ArrB);








// {
//     Console.WriteLine("Введите количество строк: ");
//     int m = Convert.ToInt32(Console.ReadLine());
//     Console.WriteLine("Введите количество столбцов: ");
//     int n = Convert.ToInt32(Console.ReadLine());
//     Console.WriteLine("Введите минимальное значение в массиве: ");
//     int minValue = Convert.ToInt32(Console.ReadLine());
//     Console.WriteLine("Введите максимальное значение в массиве: ");
//     int maxValue = Convert.ToInt32(Console.ReadLine());

//     int[,] newArray = new int[m, n];

//     for (int i = 0; i < m; i++)
//     {
//         for (int j = 0; j < n; j++)
//         {
//             newArray[i, j] = new Random().Next(minValue, maxValue + 1);
//         }
//     }
//     return newArray;
// }

// void Show2dArray(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//             Console.Write(array[i, j] + "  ");
//         Console.WriteLine();
//     }
//     Console.WriteLine();
// }

// int[,] NewArray(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             if (i % 2 == 0 && j % 2 == 0) array[i, j] *= array[i, j];
//         }

//     }
//     return array;
// }

// int[,] newArray = Create2dArray();
// Show2dArray(newArray);

// Show2dArray(NewArray(newArray));

