// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2
// * Отсортировать массив методом пузырька
// * Отсортируйте массив методом подсчета
// * Сравнить скорость работы метода пузырька и вставки

int[] GenerationArray(int len, int minValue, int maxValue)// Метод - генерация массива
{
    int[] arr = new int[len];
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = new Random().Next(minValue, maxValue + 1);
    }
    return arr;
}

void PrintData(string res) // Метод -  выводящий на печать данные пользователю
{
    Console.WriteLine(res);
}

void Print1DArr(int[] arr) // Метод - печать массива
{
    Console.Write(" [");
    for (int i = 0; i < arr.Length - 1; i++)
    {
        Console.Write(arr[i] + ", ");
    }
    Console.WriteLine(arr[arr.Length - 1] + "] ");
}

int EvenNum(int[] inputArray)// Метод - считает количество чётных элементов  
{
    int result = 0;
    int i = 0;
    while (i < inputArray.Length - 1)
    {
        if (inputArray[i] % 2 == 0)
        {
            result++;
        }
        i++;
    }
    return result;
}

void BubbleSort(int[] array) // Метод - сортировка
{
    for (int i = 0; i < array.Length; i++)
    {
        for (int j = 0; j < array.Length - i - 1; j++)
        {
            if (array[j] > array[j + 1])
            {
                int buf = array[j];
                array[j] = array[j + 1];
                array[j + 1] = buf;
            }
        }
    }
}

int[] testArray = GenerationArray(100, 100, 999);
BubbleSort(testArray);
Print1DArr(testArray);
int result = EvenNum(testArray);
PrintData(result.ToString());
