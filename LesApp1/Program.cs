using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Знову проблеми із умовою.
// "задания 3 из 15 урока" - там такого і близько немає,
// єдине що більш менш схоже на правду:
// 1. завдання 3 из 14 урок
// 2. завдання 3 из 10 урок

// Скопіюємо із 14 уроку файл і підключимо, та виконаємо аналогічні дії як в тому завданні
using LesApp2;

namespace LesApp1
{
    class Program
    {
        static void Main()
        {
            // Enable Unicode
            Console.OutputEncoding = Encoding.Unicode;

            // створення словника
            MyDictionary<int, string> dictionary = new MyDictionary<int, string>();

            // перерахунок днів тижня
            var dayOfWeek = Enum.GetValues(typeof(DayOfWeek))
                .Cast<DayOfWeek>().ToArray();

            // заповнення масива даними
            for (int i = 0; i < dayOfWeek.Length; i++)
            {
                dictionary.Add(i, dayOfWeek[i].ToString());
            }

            // вивід результатів
            Console.WriteLine("\n\tВиведення значень через foreach:\n");
            foreach (MyKeyValuePair<int, string> i in dictionary)
            {
                Console.WriteLine(i.ToString());
            }

            // repeat
            DoExitOrRepeat();
        }

        /// <summary>
        /// Метод виходу або повторення методу Main()
        /// </summary>
        static void DoExitOrRepeat()
        {
            Console.WriteLine("\n\nСпробувати ще раз: [т, н]");
            Console.Write("\t");
            var button = Console.ReadKey(true);

            if ((button.KeyChar.ToString().ToLower() == "т") ||
                (button.KeyChar.ToString().ToLower() == "n")) // можливо забули переключити розкладку клавіатури
            {
                Console.Clear();
                Main();
                // без використання рекурсії
                //Process.Start(Assembly.GetExecutingAssembly().Location);
                //Environment.Exit(0);
            }
            else
            {
                // закриває консоль
                Environment.Exit(0);
            }
        }
    }
}
