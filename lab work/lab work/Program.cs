using System;
using System.ComponentModel.DataAnnotations;

namespace lab_work
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Task-1 Bir eded verilir eger eded 5 den kicikdirse eded bir vahid artir,5 e beraberdirse ekrana "Hello P232" capa veren proqram
            Console.WriteLine("Ededi daxil edin");
            var ededStr = Console.ReadLine();
            var eded = Convert.ToInt32(ededStr);
            if (eded < 5)
            {
                eded += 1;
                Console.WriteLine(eded);
            }
            else if (eded == 5)
                Console.WriteLine("Hello P232");

            // Task-2 Verilmis N ededinin ozunun son ededine hasilini tapan proqram
            Console.WriteLine("Ededi daxil edin");
            var numStr = Console.ReadLine();
            var num = Convert.ToInt32(numStr);
            var result = 1;
            var lastDigit = num % 10;
            result = lastDigit * num;
            Console.WriteLine(result);

            // Task-3 Verilmis 3 ededin son reqemlerinin kvadratlari cemini tapa proqram
            Console.WriteLine("Birinci ededi daxil edin");
            var number1Str = Console.ReadLine();
            var number1 = Convert.ToInt32(number1Str);
            Console.WriteLine("Ikinci ededi daxil edin");
            var number2Str = Console.ReadLine();
            var number2 = Convert.ToInt32(number2Str);
            Console.WriteLine("Ucuncu ededi daxil edin");
            var number3Str = Console.ReadLine();
            var number3 = Convert.ToInt32(number3Str);
            var X = number1 % 10;
            var Y = number2 % 10;
            var Z = number3 % 10;
            var sum = (X * X) + (Y * Y) + (Z * Z);
            Console.WriteLine(sum);

            // Task-4 Verilmis 4 reqemli ededin reqemlerinin tek olanlarin cemini cut olanlarin hasilini tapan proqram 
            Console.WriteLine("Ededi daxil edin");
            var inputStr = Console.ReadLine();
            var input = Convert.ToInt32(inputStr);
            var cem = 0;
            var hasil = 1;
            while (input != 0)
            {
                var x = input % 10;
                input = (input - x) / 10;
                if (x % 2 == 0)
                {
                    hasil *= x;
                }
                else
                    cem += x;
            }
            Console.WriteLine(cem);
            Console.WriteLine(hasil);

        }
    }
}
