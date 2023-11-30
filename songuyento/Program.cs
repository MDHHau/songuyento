using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace songuyento
{
    internal class Program
    {
        static bool kiemtra(int n)
        {
            if (n <= 1)
            {
                return false;
            }
            if (n <= 3)
            {
                return true;
            }
            if (n % 2 == 0 || n % 3 == 0)
            {
                return false;
            }
            for (int i = 5; i  <= n/2 ; i += 6)
            {
                if (n % i == 0 || n % (i + 2) == 0)
                {
                    return false;
                }
            }
            return true;
        }
        static int demsnt(int a, int b)
        {
            int count = 0;
            for (int i = a; i <= b; i++)
            {
                if (kiemtra(i))
                {
                    count++;
                }
            }
            return count;
        }

        static void Main(string[] args)
        {
            int a, b;
            Console.Write("nhap a: ");
             a = int.Parse(Console.ReadLine());

            Console.Write("nhap  b: ");
             b = int.Parse(Console.ReadLine());

            if (a <= b)
            {
                 int dem = demsnt(a,b);
                Console.WriteLine("co: "+dem+" so nguyen to tu "+a+" den "+b+".");
            }
            else
            {
                Console.WriteLine("a phai nho hon b.");
            }
            Console.ReadKey();

        }
    }
}
