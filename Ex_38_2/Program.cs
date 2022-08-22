/* Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

[3 7 22 2 78] -> 76 */

class Program
{
    static int MaxNumArray(int[] array)
    {
        {
            int max = array[0];
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] > max)
                {
                    max = array[i];
                }
            }
            return max;
        }
    }

       static int MinxNumArray(int[] array)
    {
        {
            int min = array[0];
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] < min)
                {
                    min = array[i];
                }
            }
            return min;
        }
    }

    static void Main(string[] args)
    {
        int[] array = { 1, 2, 3, 427, 5, 9, 2238, 10, 580, 634, 77 };
        int max = MaxNumArray(array);
        int min = MaxNumArray(array);
        Console.WriteLine(max);
        Console.WriteLine(min);
        Console.WriteLine(max - min);
    }
}