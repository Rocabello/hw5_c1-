//Задача 2: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных индексах.

//[3, 7, 23, 12] -> 19

//[-4, -6, 89, 6] -> 0

Console.Clear();

System.Console.WriteLine("Введите размерность массива: ");
int size = int.Parse(Console.ReadLine()!);
int[] array = GetRandomArray(size, 1, 10);
Console.WriteLine($"[{String.Join(",", array)}]");
System.Console.WriteLine($"Cумма: {SumArray(array,size)}");


int SumArray(int[] array, int size)
    {
        int SumArray = 0;
        for (int i = 0; i < array.Length; i+=2)
    {
        SumArray= SumArray + array[i];
    }
        return SumArray;
    }


// -------------------------------Общий метод-------------------------------------------
int[] GetRandomArray(int size, int minValue, int maxValue)
{
    int[] result = new int[size];
    for (int i = 0; i < size; i++)
    {
        result[i] = new Random().Next(minValue, maxValue + 1);
    }
    return result;
}