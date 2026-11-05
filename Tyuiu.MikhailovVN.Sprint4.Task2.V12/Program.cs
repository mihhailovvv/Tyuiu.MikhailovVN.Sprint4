
using Tyuiu.MikhailovVN.Sprint4.Task2.V12.Lib;
namespace Tyuiu.MikhailovVN.Sprint4.Task2.V12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random();
            DataService ds = new DataService();

            Console.Title = "Спринт #4 | Выполнил: Михайлов В. Н. | Группа: ИСТНб-26-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* СПРИНТ #4                                                               *");
            Console.WriteLine("* Тема: Одномерные массивы (генератор чисел)                              *");
            Console.WriteLine("* Задание #2                                                              *");
            Console.WriteLine("* Вариант #12                                                             *");
            Console.WriteLine("* Выполнил: Михайлов В. Н. | ИСТНб-26-1                                   *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Дан одномерный целочисленный массив на 14 элементов, заполненный        *");
            Console.WriteLine("* случайными в диапазоне от 4 до 9. Подсчитать сумму нечетных элементов.  *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            int[] numsArray = { 4, 6, 7, 5, 8, 9, 4, 5, 6, 7, 8, 9, 4, 5 };

            Console.WriteLine("Исходный массив: ");
            for (int i = 0; i < numsArray.Length; i++)
            {
                Console.Write(numsArray[i] + " ");
            }
            Console.WriteLine();
            Console.WriteLine("Количество элементов: " + numsArray.Length);

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            int res = ds.Calculate(numsArray);

            Console.WriteLine("Сумма нечетных элементов массива = " + res);
            Console.ReadKey();
        }
    }
}
