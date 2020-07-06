using System;

// Змінна (Variable) - це область пам'яті, яка зберігає в собі деяке значення, яке можна змінити.

namespace TypeBasics
{
    class Program
    {
        static void Main()
        {
            // На 13-му рядку, створюємо змінну з ім'ям a, типу byte і присвоюємо їй значення 2.

            byte a = 2;

            // На 17-му рядку, виводимо значення змінної - a, на екран.

            Console.WriteLine(a);

            // Затримка.
            Console.ReadKey();
        }
    }
}
