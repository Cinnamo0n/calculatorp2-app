using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pertemuan_1
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.Title = "Calculator";

            int a = 12;
            int b = 2;

            Console.WriteLine("hasil penambahan " + a + " + " + b + " = " + penambahan(a, b));
            Console.WriteLine("hasil pengurangan  {0} - {1} = {2} " ,a,b,pengurangan(a,b));
            Console.WriteLine("hasil pengurangan  {0} * {1} = {2} ", a, b, perkalian(a, b));
            Console.WriteLine("hasil pengurangan  {0} / {1} = {2} ", a, b, pembagian(a, b));


            Console.WriteLine("\n tekan enter untuk keluar");
            Console.ReadKey();

        }

        static int penambahan(int a, int b)
        {
            return a + b;
        }

        static int pengurangan(int a, int b)
        {
            return a - b;
        }

        static int perkalian(int a, int b)
        {
            return a * b;
        }

        static int pembagian(int a, int b)
        {
            return a / b;
        }
    }
}
