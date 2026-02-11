using System;


namespace MathOperationsApp {

  class Program {

    static void Main() {

      uint baseNumber;
      uint exponent;
      ulong powerResult;

      // Task 1: Exponentiation
      Console.Write("Enter the base (natural number): ");
      baseNumber = uint.Parse(Console.ReadLine());

      Console.Write("Enter the exponent (natural number): ");
      exponent = uint.Parse(Console.ReadLine());

      powerResult = CalculatePower(baseNumber, exponent);
      Console.WriteLine($"{baseNumber} ^ {exponent} = {powerResult}");

      // Task 2: Number transformation
      uint originalNumber;
      uint transformedNumber;

      Console.Write("\nEnter X (must be at least 100): ");
      originalNumber = uint.Parse(Console.ReadLine());

      transformedNumber = RemoveSecondDigitAndAppendToEnd(originalNumber);
      Console.WriteLine($"Transformation result: {transformedNumber}");

      // Wait for user input before closing
      Console.WriteLine("\nPress any key to exit...");
      Console.ReadKey();
    }

    // Calculates exponentiation using only multiplication
    static ulong CalculatePower(uint baseValue, uint exponent) {

      ulong result = 1;

      for (uint counter = 0; counter < exponent; counter++) {

            result *= baseValue;
      }

      return result;
    }

    // Removes the second digit of a number and appends it to the end
    static uint RemoveSecondDigitAndAppendToEnd(uint number) {

      string numberString;
      char secondDigit;
      string numberWithoutSecondDigit;
      string resultString;
      uint resultNumber;

      numberString = number.ToString();
      secondDigit = numberString[1];
      numberWithoutSecondDigit = numberString.Remove(1, 1);
      resultString = numberWithoutSecondDigit + secondDigit;
      resultNumber = uint.Parse(resultString);

      return resultNumber;
    }
  }
}