// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

// [3 7 22 2 78] -> 76
// Отсортируйте массив методом вставки

double[] GenerationArray(int len, int minValue, int maxValue)// Метод - генерация массива
{
    double[] arr = new double[len];
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = new Random().Next(minValue, maxValue + 1) + (new Random().NextDouble());
        arr[i] = Math.Round(arr[i], 4);
    }
    return arr;
}

void Print1DArr(double[] arr) // Метод - печать массива
{
    Console.Write(" [");
    for (int i = 0; i < arr.Length - 1; i++)
    {
        Console.Write(arr[i] + ", ");
    }
    Console.WriteLine(arr[arr.Length - 1] + "] ");
}

void BubbleSort(double[] array) // Метод - сортировка
{
    for (int i = 0; i < array.Length; i++)
    {
        for (int j = 0; j < array.Length - i - 1; j++)
        {
            if (array[j] > array[j + 1])
            {
                double buf = array[j];
                array[j] = array[j + 1];
                array[j + 1] = buf;
            }
        }
    }
}

double[] tesatArray = GenerationArray(123, 0, 50);
Print1DArr(tesatArray);
BubbleSort(tesatArray);
Print1DArr(tesatArray);
Console.WriteLine(tesatArray[tesatArray.Length - 1] - tesatArray[0]);
