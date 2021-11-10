using System;
using cl;

namespace Compro2
{
    public class Program
    {
        public static void Main(string[] args)
        {
            string[] menu = { "1.Rice Chiken.", "2.Khao mun kai.", "3.Kao ka moo.", "4.Noodle Ped", "5.Pad ka prao." };
            int[] Price = { 40, 50 };
            int[] money = new int[2] { 1, 2 };
            int dish, bath = 0;
            int order;
            
            
            // bool success;   // use for no error input
            // success = Int32.TryParse(Console.ReadLine(), out select);   // input select

            string[] user = {"Posident","1234"};
            
            string enter = ""; // not null

            Console.Write("Please Enter Your ID : ");
            enter = Console.ReadLine();
            
        
            while(true){
            
            if(enter == user[0])
            {
                break;  // exsit loop
            }

            else{   // กรอกผิด
                Console.WriteLine("The ID and password are entered incorrectly. Please enter again ");
                Console.Write("Please Enter Your ID : ");
                enter = Console.ReadLine();
                }

            }


            Console.Write("Please Enter Your Password : ");
            enter = Console.ReadLine();

            while(true){
            
            if(enter == user[1])
            {
                break;  // exsit loop
            }

            else{
                Console.WriteLine("The ID and password are entered incorrectly. Please enter again ");
                Console.Write("Please Enter Your Password : ");
                enter = Console.ReadLine();
                }

            }
                

                
            Console.Clear();

          
                Console.WriteLine("Welcome to Restaurant.");
                Console.WriteLine("1.Rice Chiken 40 Baht \n2.Khao mun gai 50 Baht\n3.Kao pad moo 40 Baht\n4.Noodle Ped 50 Baht\n5.Pad Ka Prao 40 Baht\n6.Exit. ");
                Console.Write("Enter your name: ");
                string name = Console.ReadLine();
                Console.Write("How much many do you have: ");
                money[0] = int.Parse(Console.ReadLine());
                Console.Write($"{name} please select order: ");
               
               
                order = int.Parse(Console.ReadLine());

                if (order == 6) {
                    System.Environment.Exit(0);
                }


                Console.WriteLine($"{name} have {money[0]} baht.");

                if (order == 1 || order == 3 || order == 5)
                {
                    bath = 0;  // Price = 40 Baht
                }

                else
                {
                    bath = 1;  // Price = 50 Baht
                }

                order--;

                Console.WriteLine("You select {0} this {1} baht.", menu[order], Price[bath]);
                                           
                Console.Write("How many dishes would you like to order? ");
                dish = int.Parse(Console.ReadLine());

                Class1.cal(dish, money[order], name, Price[bath]);

                        Console.WriteLine("****************************");

            




        }

    }
}
