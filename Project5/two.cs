using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project5
{
    internal class two
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Два числа через enter");
            int one = Convert.ToInt32(Console.ReadLine());
            int two = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("1.Сложение\r\n" +
                "2.Вычитание\r\n" +
                "3.Умножение\r\n" +
                "4.Деление\r\n" +
                "5.Нахождение остатка\r\n");

        }
    }
}
