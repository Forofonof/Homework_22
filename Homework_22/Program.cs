using System;

internal class Program
{
    static void Main(string[] args)
    {
        int arrayLength = 0;
        int[] array = new int[arrayLength];
        string userMesseng;
        const string exit = "exit";
        const string sum = "sum";
        bool isActiveCycle = true;

        while (isActiveCycle)
        {
            Console.WriteLine($"Введите число или команду {sum} / {exit}");
            userMesseng = Console.ReadLine();

            if (userMesseng.ToLower() != $"{exit}" && userMesseng.ToLower() != $"{sum}")
            {
                int numbers = Convert.ToInt32(userMesseng);
                int[] arrayTemp = new int[array.Length + 1];

                for (int i = 0; i < array.Length; i++)
                {
                    arrayTemp[i] = array[i];
                }
                arrayTemp[arrayTemp.Length - 1] = numbers;
                array = arrayTemp;
            }
            else if (userMesseng.ToLower() == $"{sum}")
            {
                int arraySum = 0;

                for (int i = 0; i < array.Length; i++)
                {
                    arraySum += array[i];
                }
                Console.WriteLine($"Сумма массива: {arraySum}");
            }
            else if (userMesseng.ToLower() == $"{exit}")
            {
                isActiveCycle = false;
            }
        }
    }
}