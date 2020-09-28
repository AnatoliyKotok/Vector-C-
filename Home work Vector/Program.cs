using System;

namespace Home_work_Vector
{
    class Program
    {
        static void Main(string[] args)
        {
            Vector a1 = new Vector(5.2, 8.7);
            Vector b1 = new Vector(1.5, 4.5);

            Console.WriteLine();
            Console.WriteLine("===");
            Console.WriteLine(a1[1]);
            // Vector a2 = new Vector(2.3, 1.1);
            double s = (double)a1;
            Console.WriteLine(s);
            Vector b = a1;
            Console.WriteLine(b);
            Console.WriteLine("_____");
            Console.WriteLine($"{-a1}");
        }
    }
}
