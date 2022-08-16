using System;
namespace HomeWork2
{
    class Program
    {

        static void Main()
        {
            Console.WriteLine("Введите любое число: ");
            dynamic myNum = Int64.Parse(s: Console.ReadLine());
            dynamic result;

            if (myNum < sbyte.MaxValue && myNum > sbyte.MinValue)
            {
                result = (sbyte)myNum;
                Console.WriteLine($"Число {myNum} является допустимым значением типа sbyte");
            }
            if (myNum > sbyte.MaxValue || myNum < sbyte.MinValue)
            {
                Console.WriteLine($"Для приведения числа {myNum} к типу sbyte число не может быть больше {sbyte.MaxValue} и меньше {sbyte.MinValue}");
            }
            if (myNum < short.MaxValue && myNum > short.MinValue)
            {
                result = (short)myNum;
                Console.WriteLine($"Число {myNum} является допустимым значением типа short");
            }
            if (myNum > short.MaxValue || myNum < short.MinValue)
            {
                Console.WriteLine($"Для приведения числа {myNum} к типу short число не может быть больше {short.MaxValue} и меньше {short.MinValue}");
            }
            if (myNum < int.MaxValue && myNum > int.MinValue)
            {
                result = (int)myNum;
                Console.WriteLine($"Число {myNum} является допустимым значением типа int");
            }
            if (myNum > int.MaxValue || myNum < int.MinValue)
            {
                Console.WriteLine($"Для приведения числа {myNum} к типу int число не может быть больше {int.MaxValue} и меньше {int.MinValue}");
            }
            if (myNum < long.MaxValue && myNum > long.MinValue)
            {
                result = (long)myNum;
                Console.WriteLine($"Число {myNum} является допустимым значением типа long");
            }
            if (myNum > long.MaxValue || myNum < long.MinValue)
            {
                Console.WriteLine($"Для приведения числа {myNum} к типу long число не может быть больше {long.MaxValue} и меньше {long.MinValue}");
            }
            if (myNum < byte.MaxValue && myNum > byte.MinValue)
            {
                result = (byte)myNum;
                Console.WriteLine($"Число {myNum} является допустимым значением типа byte");
            }
            if (myNum > byte.MaxValue || myNum < byte.MinValue)
            {
                Console.WriteLine($"Для приведения числа {myNum} к типу byte число не может быть больше {byte.MaxValue} и меньше {byte.MinValue}");
            }
            if (myNum < ushort.MaxValue && myNum > ushort.MinValue)
            {
                result = (ushort)myNum;
                Console.WriteLine($"Число {myNum} является допустимым значением типа ushort");
            }
            if (myNum > ushort.MaxValue || myNum < ushort.MinValue)
            {
                Console.WriteLine($"Для приведения числа {myNum} к типу ushort число не может быть больше {ushort.MaxValue} и меньше {ushort.MinValue}");
            }
            if (myNum < uint.MaxValue && myNum > uint.MinValue)
            {
                result = (uint)myNum;
                Console.WriteLine($"Число {myNum} является допустимым значением типа uint");
            }
            if (myNum > uint.MaxValue || myNum < uint.MinValue)
            {
                Console.WriteLine($"Для приведения числа {myNum} к типу uint число не может быть больше {uint.MaxValue} и меньше {uint.MinValue}");
            }
        }
    }
}