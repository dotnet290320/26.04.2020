using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2604
{
    class Program
    {
        static long MyPower(params int[] numbers)
        {
            long sum = 0;
            int power = 1;

            for (int i = 0; i < numbers.Length; i++)
            {
                long power_of_number = Convert.ToInt64(Math.Pow(numbers[i], power));

                sum = sum + power_of_number;

                power++;
            }

            return sum;
        }

        static void Foo(ref int x)
        {
            x++;
        }

        static void ArrayChanger(int[] x)
        {
            // arr = new int[10]; // 0 0 0 0 0 0 ..
            x[0] = 1;
        }

        static void ArrayMagic(out int[] y)
        {
            y = new int[10];
            y[0] = 1;
            //Console.WriteLine(y[0]);
        }

        static void DividerPosNeg(int[] numbers, out int[] positive, out int[] negative)
        {
            int counter_positive = 0;
            int counter_negative = 0;

            // counting loop
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] > 0)
                    counter_positive++;
                else if (numbers[i] < 0)
                    counter_negative++;
            }

            positive = new int[counter_positive];
            negative = new int[counter_negative];
            int index_positive = 0;
            int index_negative = 0;

            // populate loop
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] > 0)
                {
                    positive[index_positive] = numbers[i];
                    index_positive++;
                }
                else if (numbers[i] < 0)
                {
                    negative[index_negative] = numbers[i];
                    index_negative++;
                }
            }
        }

        static void Main(string[] args)
        {
            Console.WriteLine(MyPower(4, 9, 10, 1));
            int y = 1;
            Foo(ref y); // y == 2

            int[] arr = new int[10]; // 0 0 0 0 0 0 ..
            ArrayChanger(arr);
            Console.WriteLine(arr[0]);

            int[] arr2; // = new int[10]; // 0 0 0 0 0 0 ..
            ArrayMagic(out arr2);
            Console.WriteLine(arr2[0]);

            int[] numbers = { -4, 6, -91, 800, 1000, 0, -33, 0, -100 };
           // int[] pos;
            //int[] neg;
            DividerPosNeg(numbers, out int[] pos, out int[] neg);

            Console.WriteLine("-------------- Positive");
            for (int i = 0; i < pos.Length; i++)
            {
                Console.Write(pos[i] + " ");
            }
            Console.WriteLine();

            Console.WriteLine("-------------- Negative");
            for (int i = 0; i < neg.Length; i++)
            {
                Console.Write(neg[i] + " ");
            }
            Console.WriteLine();
        }
    }
}
