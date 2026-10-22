using System;
using System.Linq;

namespace MagazinesLINQ
{
    internal class Magazine
    {
        public string Name { get; set; }
        public string Genre { get; set; }
        public int Pages { get; set; }
        public DateTime ReleaseDate { get; set; }
        public Magazine(string name, string genre, int pages, DateTime date) { Name = name; Genre = genre; Pages = pages; ReleaseDate = date; }
        public override string ToString() { return Name + " | " + Genre + " | " + Pages + " стр. | " + ReleaseDate.ToShortDateString(); }
    }

    internal class Program
    {
        private static void Main()
        {
            // Задание 2
            // Создайте тип Журнал: название, жанр, количество страниц, дата выпуска.
            // Для массива журналов используйте All, Any, Contains, FirstOrDefault и
            // LastOrDefault: страницы, жанры, Сад и Огород, Рыбалка, Охота без учёта
            // регистра, первый журнал 2022 года и последний журнал, начинающийся с Авто.
            Magazine[] magazines =
            {
                new Magazine("ELLE", "Мода", 120, new DateTime(2022, 5, 1)),
                new Magazine("АвтоМир", "Спорт", 64, new DateTime(2023, 4, 10)),
                new Magazine("Сад и Огород", "Сад и Огород", 48, new DateTime(2024, 3, 12)),
                new Magazine("Рыбалка сегодня", "Рыбалка", 55, new DateTime(2023, 8, 20)),
                new Magazine("Охотник", "охота", 72, new DateTime(2022, 11, 5)),
                new Magazine("Авто News", "Политика", 80, new DateTime(2025, 2, 9))
            };
            Console.WriteLine("Журналы:"); foreach (Magazine magazine in magazines) Console.WriteLine(magazine);
            Console.WriteLine("\nУ всех больше 30 страниц: " + magazines.All(magazine => magazine.Pages > 30));
            Console.WriteLine("У всех жанр Политика, Мода или Спорт: " + magazines.All(magazine => magazine.Genre == "Политика" || magazine.Genre == "Мода" || magazine.Genre == "Спорт"));
            Console.WriteLine("Есть Сад и Огород: " + magazines.Any(magazine => magazine.Genre == "Сад и Огород"));
            Console.WriteLine("Есть Рыбалка: " + magazines.Any(magazine => magazine.Genre == "Рыбалка"));
            Console.WriteLine("Есть Охота: " + magazines.Select(magazine => magazine.Genre).Contains("Охота", StringComparer.OrdinalIgnoreCase));
            Console.WriteLine("Первый журнал 2022 года: " + magazines.FirstOrDefault(magazine => magazine.ReleaseDate.Year == 2022));
            Console.WriteLine("Последний журнал на Авто: " + magazines.LastOrDefault(magazine => magazine.Name.StartsWith("Авто")));
            Console.ReadKey();
        }
    }
}
