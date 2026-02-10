using System;

namespace MathOperationsApp
{
    class Program
    {
        static void Main()
        {
            uint baseNumber;
            uint exponent;
            ulong powerResult;

            // Задание 1: Возведение в степень
            Console.Write("Введите основание (натуральное число): ");
            baseNumber = uint.Parse(Console.ReadLine());

            Console.Write("Введите показатель степени (натуральное число): ");
            exponent = uint.Parse(Console.ReadLine());

            powerResult = CalculatePower(baseNumber, exponent);
            Console.WriteLine($"{baseNumber} ^ {exponent} = {powerResult}");

            // Задание 2: Преобразование числа
            uint originalNumber;
            uint transformedNumber;

            Console.Write("\nВведите число X (не менее 100): ");
            originalNumber = uint.Parse(Console.ReadLine());

            transformedNumber = TransformNumber(originalNumber);
            Console.WriteLine($"Результат преобразования: {transformedNumber}");
        }

        /// <summary>
        /// Вычисляет возведение в степень, используя только операцию умножения.
        /// </summary>
        static ulong CalculatePower(uint baseValue, uint exponent)
        {
            ulong result = 1;

            for (uint counter = 0; counter < exponent; counter++)
            {
                result = result * baseValue;
            }

            return result;
        }

        /// <summary>
        /// Преобразует число по заданному алгоритму.
        /// </summary>
        static uint TransformNumber(uint number)
        {
            string numberString = number.ToString();

            char secondDigit = numberString[1];
            string withoutSecondDigit = numberString.Remove(1, 1);
            string resultString = withoutSecondDigit + secondDigit;

            uint resultNumber = uint.Parse(resultString);
            return resultNumber;
        }
    }
}