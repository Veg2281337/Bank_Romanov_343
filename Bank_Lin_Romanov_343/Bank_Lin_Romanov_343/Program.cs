using System;

namespace BankDepositCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("--- Калькулятор вклада ---");

            Console.Write("Введите начальную сумму вклада: ");
            double summa = Convert.ToDouble(Console.ReadLine());

            Console.Write("Введите срок вклада (в днях): ");
            int srok = Convert.ToInt32(Console.ReadLine());

            Console.Write("Введите годовую процентную ставку (%): ");
            double percent = Convert.ToDouble(Console.ReadLine());

            double daily = (summa * percent / 100) / 365;

            double total = daily * srok;

            summa += total;

            Console.WriteLine("--------------------------------");
            Console.WriteLine($"Итоговый доход за {srok} дн.: {total:F2}");
            Console.WriteLine($"Итоговая сумма вклада: {summa:F2}");


            Console.WriteLine("--- Расчет завершен ---");
            Console.ReadKey();
        }
    }
}