/* Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

[3, 7, 23, 12] -> 19
[-4, -6, 89, 6] -> 0 */

class Program
{
    static void WriteArray(int[] array)
    {
        int sum = 0;
        for (int i = 0; i < array.Length; i++)
        {
            Console.Write(array[i] + " ");
            if (i % 2 != 0)
            {
                sum += array[i];
            }
        }
        Console.Write($" -> {sum} ");
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

    }
}