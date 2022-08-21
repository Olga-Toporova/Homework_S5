/* Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

[3 7 22 2 78] -> 76 */

class Program
{
    static void WriteArray(int[] array)
    {
        for (int i = 0; i < array.Length; i++)
        {
            Console.Write(array[i] + " ");
        }
        Console.WriteLine(" ");
    }

    static void Main(string[] args)
    {
        int[] array = new int[0];
        while (true)
        {
            Console.Write("Введите значение массива: ");
            string meaning = Console.ReadLine();
            if (meaning != "end")
            {
                int number = Convert.ToInt32(meaning);
                int[] newArray = array;
                array = new int[array.Length + 1];
                for (int i = 0; i < newArray.Length; i++)
                {
                    array[i] = newArray[i];
                }
                array[array.Length - 1] = number;
            }
            else
            {
                break;
            }
            WriteArray(array);

        }
        int max = array.Max();
        int min = array.Min();
        Console.WriteLine($"{max} - {min} = {max - min}");
    }
}