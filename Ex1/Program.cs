//Задача 1: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.

//[345, 897, 568, 234] -> 2

Console.Clear();

System.Console.WriteLine("Введите размерность массива: ");
int size = int.Parse(Console.ReadLine()!);
int[] array = GetRandomArray(size, 100, 1000);
Console.WriteLine($"[{String.Join(",", array)}]");
System.Console.WriteLine("Четных чисел в массиве: " + Even(array, size));

//----------------------------Поиск четного-------------------------------
int Even(int[] array, int size)
{
    int Even = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] % 2 == 0) Even++;
    }
    return Even;
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
