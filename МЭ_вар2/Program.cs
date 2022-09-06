
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Windows.Forms;

namespace МЭ_вар2
{
    public class Program
    {
        public static List<User_income> user_income = new List<User_income>();
        static void Main(string[] args)
        {
            Console.WriteLine("Введите начальную сумму");
            User user = new User(Convert.ToInt32(Console.ReadLine()));
            User_contribution contribution = new User_contribution(user.money);

            for (int i = 1; i <= user.month; i++)
            {
                contribution.all_money += contribution.Get_persentMoney();
                if (i == user.month)
                {
                    Console.WriteLine($"Итого");
                    Console.WriteLine($"{contribution.all_money}  % - {contribution.percent}");
                }
                else
                {
                    Console.WriteLine($"Месяц {i}");
                    Console.WriteLine($"{contribution.all_money}  % - {contribution.percent}");
                    Console.WriteLine("_________________________________");
                }

                if (i % 3 == 0)
                {
                    contribution.Update_percent();
                }
            }
            Console.WriteLine("Расчитать максимальный максимальный доход при вложении до 1.000.000?");
        sw:
            switch (Console.ReadLine().ToLower())
            {
                case "да":
                    Console.Clear();
                    Get_maxIncome();
                    break;
                case "нет":
                    Console.Clear();
                    break;
                default:
                    Console.MoveBufferArea(0, 38, Console.BufferWidth, 1, Console.BufferWidth, 38, ' ', Console.ForegroundColor, Console.BackgroundColor);
                    Console.SetCursorPosition(0, 38);

                    goto sw;
                    break;
            }

            Console.ReadKey();
        }

        public static void Get_maxIncome()
        {
  
            TextWriterTraceListener tr2 = new TextWriterTraceListener(System.IO.File.CreateText("../../../Output.txt"));

            Debug.Listeners.Add(tr2);
            for (int i = 50000; i <= 1000000; i += 1000)
            {
                User user = new User(i);
                User_contribution contribution = new User_contribution(user.money);

                for (int m = 1; m <= user.month; m++)
                {
                    contribution.all_money += contribution.Get_persentMoney();
                    if (i % 3 == 0)
                    {
                        contribution.Update_percent();
                    }
                }
                user_income.Add(new User_income(user.money, contribution.all_money));
            }

            var income = user_income.OrderByDescending(u => u.end_money);
            Console.WriteLine($"\nмаксимальный доход -------- начальная сумма - {income.First().start_money}, конечная сумма - {income.First().end_money}");
            Debug.WriteLine($"\nмаксимальный доход -------- начальная сумма - {income.First().start_money}, конечная сумма - {income.First().end_money}");
            Debug.Flush();
        }
    }
}
