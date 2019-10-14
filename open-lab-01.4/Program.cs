using System;

namespace open_lab_01._4
{
    class Program
    {
        public static int Sum(int a, int b)
        {
            return (a * b) / 2;
        }
        static void Main(string[] args)
        {
            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(Sum(a, b));
        }
    }
}
