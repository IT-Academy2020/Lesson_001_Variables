using System;

namespace Char
{
    class Program
    {
        static void Main()
        {
            char a = 'A';      // Символ
            char b = '\x0041'; // Значення в 16-ковому форматі
            char c = '\u0041'; // Значення в форматі unicode

            Console.WriteLine(a);
            Console.WriteLine(b);
            Console.WriteLine(c);

            Console.ReadKey();
        }
    }
}
