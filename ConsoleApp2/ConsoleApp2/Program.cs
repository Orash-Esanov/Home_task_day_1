using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
          
            //1
            Console.WriteLine($" 1 зад");
            string name = "Arash";
            int age = 19;
            bool isEmployed = false;
            double weight = 65;
            Console.WriteLine($"Имя: {name}");
            Console.WriteLine($"Возраст: {age}");
            Console.WriteLine($"Вес: {weight}");
            Console.WriteLine($"Работает: {isEmployed}");

            //2
            Console.WriteLine($" 2 зад");
            int p = 14, sum;
            sum = p + 1;
            Console.WriteLine($"sum = {sum}");
            //3
            Console.WriteLine($" 3 зад");
            int A = 5;
            int B = 10;

            Console.WriteLine($" Значения: a = {A}, b = {B}");
            A = 15;
            B = 20;

            Console.WriteLine($" Измен значения a = {A}, b = {B}");

            //4
            Console.WriteLine($" 4 зад");

            int a = 2;

            int P = 4 * a;

            Console.WriteLine($"Периметр квадрата P = {P}");



            Console.ReadKey();
        }
    }
}
