using System;
using cl;

namespace Compro2
{
    public class Program
    {
        public static void Main(string[] args)
        {


            bool again = true, success;

            int select;

            while (again)
            {
                Console.Clear();
                string[] menu = { "1.Rice Chiken.", "2.Khao mun kai.", "3.Kao ka moo.", "4.Noodle Ped", "5.Pad ka prao." };
                int[] Price = { 40, 50 };
                int money = 0;
                int dish, bath = 0;
                int order;



                // bool success;   // use for no error input
                // success = Int32.TryParse(Console.ReadLine(), out select);   // input select

                string[] user = { "Posident", "1234" };


                string enter = ""; // not null

                Console.Write("\n\tPlease Enter Your ID : ");
                enter = Console.ReadLine();


                while (true)
                {

                    if (enter == user[0])
                    {
                        break;  // exsit loop
                    }

                    else
                    {   // กรอกผิด
                        Console.WriteLine("\n\tThe ID and password are entered incorrectly. Please enter again ");
                        Console.Write("\n\tPlease Enter Your ID : ");
                        enter = Console.ReadLine();
                    }

                }


                Console.Write("\n\tPlease Enter Your Password : ");
                enter = Console.ReadLine();

                while (true)
                {

                    if (enter == user[1])
                    {
                        break;  // exsit loop
                    }

                    else
                    {
                        Console.WriteLine("\n\tThe ID and password are entered incorrectly. Please enter again ");
                        Console.Write("\n\tPlease Enter Your Password : ");
                        enter = Console.ReadLine();
                    }

                }



                Console.Clear();
                //ฟังก์ชั่น เลือกเมนูอาหารและใส่ชื่อ**

                Console.WriteLine("\n\tWelcome to Restaurant.");
                Console.WriteLine("\n\t1.Rice Chiken 40 Baht \n\t2.Khao mun gai 50 Baht\n\t3.Kao pad moo 40 Baht\n\t4.Noodle Ped 50 Baht\n\t5.Pad Ka Prao 40 Baht\n\t6.Exit. ");
                Console.Write("\n\tEnter your name: ");
                string name = Console.ReadLine();
                Console.Write("\n\tHow Much Money Do You Have: ");
                money = int.Parse(Console.ReadLine());
                Console.Write($"\n\t{name} please select order: ");


                order = int.Parse(Console.ReadLine());
                
                
                if (order == 6)
                {
                    System.Environment.Exit(0);
                }


                Console.WriteLine($"\n\t{name} have {money} baht.");

               

                if (order == 1 || order == 3 || order == 5)
                {
                    bath = 0;  // Price = 40 Baht
                }

                else
                {
                    bath = 1;  // Price = 50 Baht
                }

                order--;

                //ฟังชั้น เลือกจาน**
                Console.WriteLine("\n\t{2} select {0} this {1} baht.", menu[order], Price[bath], name);

                Console.Write("\n\tHow Many Dishes Would You Like To Order? ");
                dish = int.Parse(Console.ReadLine());

                Class1.cal(dish, money, name, Price[bath]);


                Console.WriteLine("\n\t****************************");

                //ฟังชั้น ทำซํ้าให้เข้าไป สั่งอาหารใหม่
                Console.WriteLine("Do you want order agian");
                Console.WriteLine("1.Yes / 2.No ");

                success = Int32.TryParse(Console.ReadLine(), out select);   // input select

                
                int userInput = 1;
                while (userInput != 0)
                {


                    if (select == 1)
                    {
                        userInput--;
                        again = true;
                        Console.Clear();
                    }

                    else if (select == 2)
                    {
                        userInput--;
                        again = false;

                        Console.WriteLine("Thank you for using the service.");

                    }

                    else
                    {
                        Console.WriteLine("You Must Select 1 Or 2 Only");
                        Console.WriteLine("Do you want order agian");
                        Console.WriteLine("1.Yes / 2.No ");

                        success = Int32.TryParse(Console.ReadLine(), out select);   // input select          
                    }
                    Console.Clear();

                } // while select end

            } //while end

        }// main end

    }
}