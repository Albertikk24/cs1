using System;
using System.Linq;

namespace NumberDataProcessor
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                string filePath = "numbers.txt"; // Ваш файл с данными
                var processor = new NumberDataProcessor();

                // 1. Загрузка данных
                processor.LoadFromFile(filePath);
                Console.WriteLine($"Загружено чисел: {processor.Numbers.Count}");
                Console.WriteLine();

                // 2. Статистика
                var stats = processor.GetStatistics();
                Console.WriteLine("Статистика:");
                Console.WriteLine(stats);
                Console.WriteLine();

                // 3. Фильтрация (например, числа от 100 до 200)
                var filtered = processor.FilterByRange(100, 200);
                Console.WriteLine($"Числа от 100 до 200: {filtered.Count()} значений");
                Console.WriteLine(string.Join(", ", filtered.Take(10)) + "...");
                Console.WriteLine();

                // 4. Поиск аномалий (например, шаг не равен 1.0)
                FindIrregularSteps(processor.Numbers);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Ошибка: {ex.Message}");
            }
        }

        /// <summary>
        /// Находит и выводит нерегулярные шаги в последовательности чисел.
        /// </summary>
        private static void FindIrregularSteps(IReadOnlyList<double> numbers)
        {
            Console.WriteLine("Поиск нерегулярных шагов в последовательности:");

            for (int i = 1; i < numbers.Count; i++)
            {
                double step = numbers[i] - numbers[i - 1];
                if (Math.Abs(step - 1.0) > 0.01 && Math.Abs(step - 0.5) > 0.01)
                {
                    Console.WriteLine($"Нестандартный шаг между [{i-1}]={numbers[i-1]} и [{i}]={numbers[i]}: {step:F2}");
                }
            }
        }
    }
}