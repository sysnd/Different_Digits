using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace difdigits
{
    class Program
    {
        static bool isMatch = false;
        static long numberResult;
        static int count = 0;
        static Stopwatch watch = new Stopwatch();
        static void Main(string[] args)
        {
            watch.Start();
            long n = long.Parse(Console.ReadLine());
            long number = n + 1;
            Calculate(number);
            watch.Stop();
            Console.WriteLine(watch.ElapsedMilliseconds.ToString() + "ms");
        }
        static int Calculate(long number)
        {
            long localNumber = number;
            long originalNumber = localNumber;
            int length = localNumber.ToString().Length;
            while (!isMatch)
            {
                for (int j = 0; j < length; j++)
                {
                    int lastDigit = (int)localNumber % 10;
                    int previousDigit = (int)(localNumber / 10) % 10;
                    if (lastDigit == previousDigit)
                    {
                        originalNumber++;
                        Calculate(originalNumber);

                    }
                    else
                    {
                        localNumber /= 10;
                        length--;
                        continue;
                    }
                }
                isMatch = true;
                if (++count == 1)
                {
                    numberResult = originalNumber;
                    Console.WriteLine(numberResult);
                }
            }
                return 0;
           
        }
    }
}
