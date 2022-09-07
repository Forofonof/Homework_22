using System;

internal class Program
{
    static void Main(string[] args)
    {
        string messeng;
        bool isExit = true;
        int arrayLength = 0;
        int[] array = new int[arrayLength];

        while (isExit)
        {
            Console.WriteLine("Введите число или команду sum / exit");
            messeng = Console.ReadLine();

            if (messeng != "exit" && messeng != "sum")
            {
                int numbers = Convert.ToInt32(messeng);
                int[] arrayTemp = new int[array.Length + 1];
                array = new int[array.Length];

                for (int i = 0; i < array.Length; i++)
                {
                    arrayTemp[i] = array[i];
                }
                arrayTemp[arrayTemp.Length - 1] = numbers;
                array = arrayTemp;
                Console.WriteLine(numbers);
            }
            else if (messeng == "sum")
            {
                int arraySum = 0;

                for (int i = 0; i < array.Length; i++)
                {
                    arraySum += array[i];
                }
                Console.WriteLine($"Сумма массива: {arraySum}");
            }
            else if (messeng == "exit")
            {
                isExit = false;
            }
        }
    }
}