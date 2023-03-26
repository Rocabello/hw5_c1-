//Задача 3: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
//[3, 7.4, 22.3, 2, 78] -> 76
Console.Clear();
Console.WriteLine("Введите размер массива  ");
int size = Convert.ToInt32(Console.ReadLine());
double[] array = new double[size];
System.Console.Write("Массив: ");
GetRandomArray(array);
Console.WriteLine($"[{String.Join(" | ", array)}]");
MinMax(array); 
double Rez1 = MinMax(array); 
string Rez2 = Rez1.ToString("0.00"); 
System.Console.WriteLine($"Разница между минимальным и максимальным элементом: {Rez2}");

//==============Основной метод====================

double MinMax(double[] x)
{
double min = Int32.MaxValue;
double max = Int32.MinValue;
for (int z = 0; z < array.Length; z++)

{
     if (array[z] > max)
        {
            max = array[z];
        }
 
     if (array[z] < min)
        {
            min = array[z];            
        }
    }
return max-min;
}

//==============Задание массива====================

void GetRandomArray(double[] numbers)
{
    for(int i = 0; i < numbers.Length; i++)
        {
            numbers[i] = Convert.ToDouble(new Random().Next(100,1000)) / 100;
        }
}


