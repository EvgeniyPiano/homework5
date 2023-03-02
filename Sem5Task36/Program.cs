// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0


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
    int sumNegativ = 0;
    while (i < inputArray.Length - 1)
    {
        if (inputArray[i] % 2 == 0)
        {
            result++;
        }
        else
        {
            sumNegativ = i + sumNegativ;
        }
        return sumNegativ;
    }
    i++;
    return result;
}


int[] testArray = GenerationArray(5, 1, 9);
Print1DArr(testArray);
int result = EvenNum(testArray);
PrintData(result.ToString());
int sumNegativ = EvenNum(testArray);
PrintData(sumNegativ.ToString());