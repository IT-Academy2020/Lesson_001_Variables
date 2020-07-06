using System;

namespace DefaultValues
{
    class Program
    {
        static void Main()
        {
            // На 11-му рядку, створюємо змінну з ім'ям a, типу byte і не присвоюємо їй ніякого значення.

            byte a;         
            bool b;
            char c;
            string s;

            // На 18-му рядку - ПОМИЛКА: Забороняється використання неініціалізованої локальної змінної!

            //Console.WriteLine(a);

            // Затримка.
            Console.ReadKey();
        }
    }
}
