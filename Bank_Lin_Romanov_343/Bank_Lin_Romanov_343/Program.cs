using System;

namespace DepositCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите сумму вклада: ");
            double sum = Convert.ToDouble(Console.ReadLine());

            Console.Write("Введите срок вклада (в днях): ");
            int days = Convert.ToInt32(Console.ReadLine());

            while (days < 31 || days > 365)
            {
                Console.WriteLine("Ошибка: срок должен быть от 31 до 365 дней.");
                Console.Write("Введите срок вклада (в днях) заново: ");
                days = Convert.ToInt32(Console.ReadLine());
            }

            double rate = 0;

            if (days >= 31 && days <= 91)
            {
                rate = 11.50;
            }
            else if (days > 91 && days <= 181)
            {
                rate = 11.75;
            }
            else if (days > 181 && days <= 365)
            {
                rate = 12.50;
            }

            int months = days / 30;

            double totalIncome = 0;

            for (int i = 1; i <= months; i++)
            {
                double monthlyIncome = (sum * rate / 100) / 12;

                totalIncome = totalIncome + monthlyIncome;

                sum = sum + monthlyIncome;
            }

            Console.WriteLine($"Итоговый доход: {totalIncome:F2}");
            Console.WriteLine($"Итоговая сумма: {sum:F2}");
        }
    }
}