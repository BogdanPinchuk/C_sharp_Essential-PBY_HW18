using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Підключення іншого простору імен
using MyNamespace;

namespace LesApp0
{
    class Program
    {
        static void Main()
        {
            // join unicode
            Console.OutputEncoding = Encoding.Unicode;

            // перевірка доступу до класу із іншого простору імен
            MyClass @class = new MyClass();

            Console.WriteLine("Базовий простір імен: " + typeof(Program));
            Console.WriteLine(@class.GetType());

            // delay
            Console.ReadKey(true);
        }
    }
}
