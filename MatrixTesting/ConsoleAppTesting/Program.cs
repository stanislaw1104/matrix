using System;
using System.Runtime.CompilerServices;
///Задание:
///Консольное приложение.
///Программа запрашивает у пользователя ввод двух чисел
///Отслеживание некорректного ввода
///По двум числам нужно составить матрицу умножения
///x = 3, y = 4
///[1, 2, 3, 1x1 1x2 1x3
/// 2, 4, 6, 2x1 2x2 2x3
/// 3, 6, 9, ...
/// 4, 8, 12]
[assembly:InternalsVisibleTo("ConsoleInputOutputHandler")]
namespace ConsoleAppTesting
{
    internal class Program
    {
        internal static void Main(string[] args)
        {
            

            string inputX = Console.ReadLine();
            string inputY = Console.ReadLine();

            int x;
            int y;

            if (!int.TryParse(inputX, out x) || !int.TryParse(inputY, out y) || (x <= 0) || (y <= 0))
            {
                Console.WriteLine("некорректный ввод");

            }


            else
            {
                int[,] mass = new int[x, y];
                for (int i = 0; i < x; i++)
                {
                    
                    for (int j = 0; j < y; j++)
                    {

                        mass[i,j] = (i + 1) * (j + 1);
                    }
                    
                }

                for (int i = 0; i < x; i++)
                {
                    Console.WriteLine();
                    for (int j = 0; j < y; j++)
                    {

                        Console.Write(mass[i, j] + " ");
                    }

                }
            }
        }
    }
}