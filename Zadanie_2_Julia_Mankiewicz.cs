using System;
using System.Linq.Expressions;

namespace Table.ConsoleApp
{
    class Table
    {
        static void Main()
        {
        
            int rotate;
            bool success;
            string retry = "n";

            char[,] a = new char[6, 6]
            {
                {'#', '#', '#', '%', '%', '%'},
                {'#', '#', '#', '%', '%', '%'},
                {'#', '#', '#', '%', '%', '%'},
                {'*', '*', '*', '+', '+', '+'},
                {'*', '*', '*', '+', '+', '+'},
                {'*', '*', '*', '+', '+', '+'},
            };
            for (int i = 0; i < 6; i++)
            {
                for (int j = 0; j < 6; j++)
                {
                    Console.Write(" "+ a[i, j]);
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        start:
            Console.WriteLine("Jaki obrót wykonać? Do wyboru:");
            Console.WriteLine("\n1. Obrót o 90 stopni");
            Console.WriteLine("2. Obrót o 180 stopni");
            Console.WriteLine("3. Obrót o 270 stopni");
            Console.WriteLine("4. Zresetuj układ\n");
            do
            {
                Console.WriteLine("Wybierz liczbę od 1 do 4:");
                success = int.TryParse(Console.ReadLine(), out rotate);
            }
            while ((rotate < 1 || rotate > 4));

            switch (rotate)
            {

                case 1:
                    Console.WriteLine("Rotate 90");
                    for (int i = 0; i < 6; i++)
                    {
                        for (int j = 0; j < 6; j++)
                        {
                            Console.Write(" " + a[5 - j, i]);
                        }
                        Console.WriteLine();
                    }
                    Console.WriteLine();
                    break;
                case 2:
                    Console.WriteLine("Rotate 180");

                    for (int i = 0; i < 6; i++)
                    {
                        for (int j = 0; j < 6; j++)
                        {
                            Console.Write(" " + a[5 - i, 5 - j]);
                        }
                        Console.WriteLine();
                    }
                    Console.WriteLine();
                    break;
                case 3:
                    Console.WriteLine("Rotate 270");
                    for (int i = 0; i < 6; i++)
                    {
                        for (int j = 0; j < 6; j++)
                        {
                            Console.Write(" " + a[j, 5 - i]);
                        }
                        Console.WriteLine();
                    }
                    Console.WriteLine();
                    break;
                case 4:
                    Console.WriteLine("Zresetuj układ");
                    for (int i = 0; i < 6; i++)
                    {
                        for (int j = 0; j < 6; j++)
                        {
                            Console.Write(" " + a[i, j]);
                        }
                        Console.WriteLine();
                    }
                    Console.WriteLine();
                    break;
            }
            Console.WriteLine("Uruchomić program ponownie? t/n");
            retry = Console.ReadLine();
            if (retry == "t")
            {
                goto start;
            }
            Console.ReadKey();
        }
    }
}

