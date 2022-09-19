using System;

namespace ErdnievDzhangr21D_1._43
{
    class Program
    {
        static void Main(string[] args)
        {
            double firstNum, secondNum, average, geometricMean;

            Console.WriteLine("Эта программа рассчитывает среднее арифметическое и среднее геометрическое ваших чисел");

            Console.Write("Введи первое число: ");
            firstNum = double.Parse(Console.ReadLine());

            Console.Write("Введи второе число: ");
            secondNum = double.Parse(Console.ReadLine());

            average = (firstNum + secondNum) / 2;
            geometricMean = Math.Round(Math.Sqrt(firstNum * secondNum), 2);

            Console.WriteLine("Среднее арифметическое {0}", average);
            Console.WriteLine("Среднее геометрическое {0}", geometricMean);


        }
    }
}
