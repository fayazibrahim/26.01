using System;

namespace _2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");



            {

                int[] numbers = { 77, 3, 2, 11, 18, 36 };

                int Max = numbers[0];

                for (var i = 0; i < numbers.Length; i++)
                {
                    if (numbers[i] > Max)
                    {
                        Max = numbers[i];
                    }
                }

                Console.WriteLine(Max);

            }







        }
    }
}
