using System;
using System.Text;
using NUnit.Framework;
using Assert = NUnit.Framework.Assert;
namespace myFunctions
{
    //быстрая сортировка
    public class QuickSort
    {
        public void Sort(int[] array, int left, int right)
        {
            if (left < right)
            {
                int pivotIndex = Partition(array, left, right);
                Sort(array, left, pivotIndex - 1);
                Sort(array, pivotIndex + 1, right);
            }
        }
        private int Partition(int[] array, int left, int right)
        {
            int pivot = array[right];
            int i = left - 1;

            for (int j = left; j < right; j++)
            {
                if (array[j] <= pivot)
                {
                    i++;
                    Swap(array, i, j);
                }
            }
            Swap(array, i + 1, right);
            return i + 1;
        }
        private void Swap(int[] array, int i, int j)
        {
            int temp = array[i];
            array[i] = array[j];
            array[j] = temp;
        }
    }

    //проверка строки на палиндром
    public class PalindromeChecker
    {
        public bool IsPalindrome(string input)
        {
            if (string.IsNullOrEmpty(input))
            {
                return false;
            }

            // Убираем пробелы и переводим в нижний регистр
            string cleanedInput = input.Replace(" ", "").ToLower();

            int left = 0;
            int right = cleanedInput.Length - 1;

            while (left < right)
            {
                if (cleanedInput[left] != cleanedInput[right])
                {
                    return false;
                }
                left++;
                right--;
            }

            return true;
        }
    }

    //вычисление факториала числа
    public class FactorialCalculator
    {
        public long Factorial(int number)
        {
            if (number < 0)
            {
                throw new ArgumentOutOfRangeException(nameof(number), "Число должно быть неотрицательным.");
            }

            if (number == 0 || number == 1)
            {
                return 1;
            }

            long result = 1;
            for (int i = 2; i <= number; i++)
            {
                result *= i;
            }

            return result;
        }
    }

    //число фибоначи на указанной позиции
    public class FibonacciCalculator
    {
        public long Fibonacci(int position)
        {
            if (position < 0)
            {
                throw new ArgumentOutOfRangeException(nameof(position), "Позиция должна быть неотрицательной.");
            }

            if (position == 0) return 0;
            if (position == 1) return 1;

            long a = 0, b = 1;
            for (int i = 2; i <= position; i++)
            {
                long temp = a;
                a = b;
                b = temp + b;
            }

            return b;
        }
    }

    public class SubstringSearcher
    {
        public int IndexOf(string source, string substring)
        {
            if (source == null) throw new ArgumentNullException(nameof(source));
            if (substring == null) throw new ArgumentNullException(nameof(substring));

            return source.IndexOf(substring, StringComparison.Ordinal);
        }
    }

    //проверка на простое число
    public class PrimeNumberChecker
    {
        public bool IsPrime(int number)
        {
            // Числа меньше 2 не являются простыми
            if (number < 2) return false;

            // Проверяем делимость от 2 до квадратного корня из number
            for (int i = 2; i <= Math.Sqrt(number); i++)
            {
                if (number % i == 0)
                {
                    return false; // Найден делитель, число не простое
                }
            }
            return true; // Число простое
        }
    }

    //переворот 32х битного числа
    public class NumberReverser
    {
        public int ReverseNumber(int x)
        {
            int reversed = 0;

            while (x != 0)
            {
                int digit = x % 10; // Получаем последнюю цифру
                x /= 10; // Убираем последнюю цифру

                reversed = reversed * 10 + digit; // Добавляем цифру в конец числа
            }

            return reversed;
        }
    }

    //перевод в римскую систему счисления
    public class RomanConverter
    {
        public string ConvertToRoman(int number)
        {
            if (number < 1 || number > 3999)
            {
                throw new ArgumentOutOfRangeException(nameof(number), "Число должно быть в диапазоне от 1 до 3999.");
            }

            var romanNumerals = new (int Value, string Symbol)[]
            {
            (1000, "M"),
            (900, "CM"),
            (500, "D"),
            (400, "CD"),
            (100, "C"),
            (90, "XC"),
            (50, "L"),
            (40, "XL"),
            (10, "X"),
            (9, "IX"),
            (5, "V"),
            (4, "IV"),
            (1, "I")
            };

            var result = new StringBuilder();

            foreach (var (value, symbol) in romanNumerals)
            {
                while (number >= value)
                {
                    result.Append(symbol);
                    number -= value;
                }
            }

            return result.ToString();
        }
    }
    public class Program
    {
        static void Main() { }
    }
}