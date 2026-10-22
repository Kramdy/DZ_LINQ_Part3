using System;
using System.Linq;

namespace SurnamesLINQ
{
    internal class Program
    {
        private static void Main()
        {
            // Задание 1
            // Для массива фамилий проверьте All: длина больше 3; длина больше 3 и
            // меньше 10. Проверьте Any: начинается с W; заканчивается на Y.
            // Используйте Contains для Orange, FirstOrDefault для первой длиной 6,
            // LastOrDefault для последней фамилии длиной меньше 15.
            string[] surnames = { "Brown", "White", "Orange", "Wilson", "Davis", "Kennedy" };
            Console.WriteLine("Фамилии: " + string.Join(", ", surnames));
            Console.WriteLine("Все длиннее 3: " + surnames.All(surname => surname.Length > 3));
            Console.WriteLine("Все длиннее 3 и короче 10: " + surnames.All(surname => surname.Length > 3 && surname.Length < 10));
            Console.WriteLine("Есть фамилия на W: " + surnames.Any(surname => surname.StartsWith("W")));
            Console.WriteLine("Есть фамилия на Y: " + surnames.Any(surname => surname.EndsWith("Y")));
            Console.WriteLine("Есть фамилия Orange: " + surnames.Contains("Orange"));
            Console.WriteLine("Первая фамилия длиной 6: " + surnames.FirstOrDefault(surname => surname.Length == 6));
            Console.WriteLine("Последняя фамилия короче 15: " + surnames.LastOrDefault(surname => surname.Length < 15));
            Console.ReadKey();
        }
    }
}
