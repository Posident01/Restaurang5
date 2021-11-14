using System;

namespace cl
{
    public class Class1
    {
        public static void cal(int dish, int money, string name, int Price)
        {
            if (money >= dish * Price)
            {
                int total;
                total = money - dish * Price;
                Console.WriteLine("\n\t{1} Need To Pay {0}", dish * Price, name);
                Console.WriteLine("\n\t{1} pay {0} Baht.", money, name);
                Console.WriteLine("\n\t{1} Get change For {0} Baht.", total, name);
                Console.WriteLine("\n\t{1} Get {0} Thousand banknotes Baht.", total / 1000, name);
                Console.WriteLine("\n\t{1} Get {0} Five Hundreds Banknotes Baht.", total % 1000 / 500, name);
                Console.WriteLine("\n\t{1} Get {0} One Hundreds Banknotes Baht.", total % 1000 % 500 / 100, name);
                Console.WriteLine("\n\t{1} Get {0} Fifty Nanknotes Baht.", total % 1000 % 500 % 100 / 50, name);
                Console.WriteLine("\n\t{1} Get {0} Twenty Banknotes Baht.", total % 1000 % 500 % 100 % 50 / 20, name);
                Console.WriteLine("\n\t{1} Get {0} Ten coin Baht.", total % 1000 % 500 % 100 % 50 % 20 / 10, name);
                Console.WriteLine("\n\t{1} Get {0} Five coin Baht.", total % 1000 % 500 % 100 % 50 % 20 % 10 / 5, name);
                Console.WriteLine("\n\t{1} Get {0} One coin Baht.", total % 1000 % 500 % 100 % 50 % 20 % 10 % 5, name);
            }
            else if (money <= dish * Price)
            {
                Console.WriteLine("\n\t{1} Need To Pay {0}", dish * Price, name);
                Console.WriteLine("\n\tYour want add money again? ");
                Console.Write("\n\t1.Yes.\n\t2.No.\n\tYou select 1 or 2: ");
                int Choseadd = int.Parse(Console.ReadLine());
                if (Choseadd == 1)
                {
                    do
                    {
                        Console.Write("\n\tHow much will you fill: ");
                        money += Convert.ToInt32(Console.ReadLine());
                    } while (money < dish * Price);
                    int total;
                    total = money - dish * Price;
                    Console.WriteLine("\n\t{1} pay {0} Baht.", money, name);
                    Console.WriteLine("\n\t{1} Get change For {0} Baht.", total, name);
                    Console.WriteLine("\n\t{1} Get {0} Thousand banknotes Baht.", total / 1000, name);
                    Console.WriteLine("\n\t{1} Get {0} Five Hundreds Banknotes Baht.", total % 1000 / 500, name);
                    Console.WriteLine("\n\t{1} Get {0} One Hundreds Banknotes Baht.", total % 1000 % 500 / 100, name);
                    Console.WriteLine("\n\t{1} Get {0} Fifty Nanknotes Baht.", total % 1000 % 500 % 100 / 50, name);
                    Console.WriteLine("\n\t{1} Get {0} Twenty Banknotes Baht.", total % 1000 % 500 % 100 % 50 / 20, name);
                    Console.WriteLine("\n\t{1} Get {0} Ten coin Baht.", total % 1000 % 500 % 100 % 50 % 20 / 10, name);
                    Console.WriteLine("\n\t{1} Get {0} Five coin Baht.", total % 1000 % 500 % 100 % 50 % 20 % 10 / 5, name);
                    Console.WriteLine("\n\t{1} Get {0} One coin Baht.", total % 1000 % 500 % 100 % 50 % 20 % 10 % 5, name);
                }
            }
        }
    }
}
