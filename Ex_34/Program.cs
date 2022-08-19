/* Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
Напишите программу, которая покажет количество чётных чисел в массиве.

[345, 897, 568, 234] -> 2 */

class Program
{
    static void WriteArray(int[] array)
    {
        int N = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] % 2 == 0)
            {
                N++;
            }
            Console.Write(array[i] + " ");
        }
        Console.Write($" -> {N} ");
        Console.WriteLine(" ");
    }

    static void Main(string[] args)
    {
        int[] array = new int[0];
        while (true)
        {
            Console.Write("Введите значение массива: ");
            string meaning = Console.ReadLine();
            if (meaning.Length != 3)
            {
                Console.WriteLine("Вы ввели не трехзначное число");
            }
            else if (meaning != "end")
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

    }
}