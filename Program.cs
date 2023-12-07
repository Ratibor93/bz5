
//  Задача 1: Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
//  и возвращает значение этого элемента или же указание, что такого элемента нет.


// Создаем двумерный массив (матрицу) для примера
// int[,] matrix = 
//     {
//     {1, 2, 3},
//     {4, 5, 6},
//     {7, 8, 9}
//     };

// // Получаем размеры массива
// int rows = matrix.GetLength(0);
// int cols = matrix.GetLength(1);

// // Запрашиваем позиции элемента
// Console.Write("Введите номер строки: ");
// int rowPosition = Convert.ToInt32(Console.ReadLine());

// Console.Write("Введите номер столбца: ");
// int colPosition = Convert.ToInt32(Console.ReadLine());

// // Проверяем, находятся ли введенные позиции в пределах массива
// if (rowPosition >= 0 && rowPosition < rows && colPosition >= 0 && colPosition < cols)
//     {
// // Выводим значение элемента
//     int element = matrix[rowPosition, colPosition];
//     Console.WriteLine($"Значение элемента на позиции ({rowPosition}, {colPosition}): {element}");
//     }
//     else
//     {
//     Console.WriteLine("Указанные позиции находятся за пределами массива.");
//     }
    
// Задача 2: Задайте двумерный массив. Напишите программу, которая поменяет местами первую и последнюю строку массива.

// // Создаем двумерный массив (матрицу) для примера
// int[,] matrix = 
//     {
//     {1, 2, 3},
//     {4, 5, 6},
//     {7, 8, 9}
//     };

// // Вывод исходной матрицы
// Console.WriteLine("Исходная матрица:");
// PrintMatrix(matrix);

// // Меняем местами первую и последнюю строки
// SwapRows(matrix, 0, matrix.GetLength(0) - 1);

// // Вывод измененной матрицы
// Console.WriteLine("\nМатрица после обмена:");
// PrintMatrix(matrix);


// static void SwapRows(int[,] matrix, int row1, int row2)
//     {
//     int cols = matrix.GetLength(1);

//     for (int col = 0; col < cols; col++)
//         {
//         int temp = matrix[row1, col];
//         matrix[row1, col] = matrix[row2, col];
//         matrix[row2, col] = temp;
//         }
//     }

// static void PrintMatrix(int[,] matrix)
//     {
//     int rows = matrix.GetLength(0);
//     int cols = matrix.GetLength(1);

//     for (int i = 0; i < rows; i++)
//         {
//         for (int j = 0; j < cols; j++)
//             {
//             Console.Write($"{matrix[i, j]} ");
//             }
//             Console.WriteLine(); // Добавлен переход на новую строку после каждой строки матрицы
//         }
//     }


//  Задача 3: Задайте прямоугольный двумерный массив. Напишите программу, 
//  которая будет находить строку с наименьшей суммой элементов.


// Задаем прямоугольный двумерный массив
        int[,] array = {
            {13, 43, 42},
            {4, 5, 6},
            {7, 8, 9},
            {10, 11, 12}
        };

// Выводим исходный массив
        Console.WriteLine("Исходный массив:");
        PrintArray(array);

// Находим строку с наименьшей суммой элементов
        int minSumRow = FindMinSumRow(array);

// Выводим результат
Console.WriteLine($"\nСтрока с наименьшей суммой элементов: {minSumRow + 1}");
    

static void PrintArray(int[,] array)
    {
    int rows = array.GetLength(0);
    int cols = array.GetLength(1);

     for (int i = 0; i < rows; i++)
        {
        for (int j = 0; j < cols; j++)
            {
            Console.Write($"{array[i, j]} ");
            }
        Console.WriteLine();
        }
    }

static int FindMinSumRow(int[,] array)
    {
    int rows = array.GetLength(0);
    int cols = array.GetLength(1);

    int minSum = int.MaxValue;
    int minSumRow = -1;

    for (int i = 0; i < rows; i++)
        {
        int currentSum = 0;

            for (int j = 0; j < cols; j++)
            {
            currentSum += array[i, j];
            }

            if (currentSum < minSum)
            {
            minSum = currentSum;
            minSumRow = i;
            }
        }

    return minSumRow;
    }


