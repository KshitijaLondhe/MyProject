using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProject
{
    internal class Pattern
    {
        static void Main(string[] args)
        {
            /*1) *****
                 ****
                 ***
                 **
                 *
            */
            //Console.WriteLine("Star Pattern Program 1");
            //int num1 = 5;
            //for (int i = num1; i >= 0; i--)
            //{
            //    for (int j = i; j >= 0; j--)
            //    {
            //        Console.Write("*");
            //    }
            //    Console.WriteLine();
            //}

            /*2) Print pattern 
            1 
            12 
            123 
            1234 
            12345 
            1234 
            123 
            12 
            1
            */

            //Console.WriteLine("Num Pattern Program 1");
            //int num2 = 5;
            //for (int i = 0; i <= num2; i++)
            //{
            //    for (int j = 1; j <= i; j++)
            //    {
            //        Console.Write(j);
            //    }
            //    Console.WriteLine();
            //}

            //for (int i = num2 - 1; i >= 0; i--)
            //{
            //    for (int j = 1; j <= i; j++)
            //    {
            //        Console.Write(j);
            //    }
            //    Console.WriteLine();
            //}
            /*3) Print pattern 
            1 
            121 
            12321 
            1234321 
            123454321 
            1234321 
            12321 
            121 
            1 

            */
            //Console.WriteLine("Num Pattern Program 2");
            //int num3 = 5;
            //for (int i = 0; i <= num3; i++)
            //{
            //    for (int j = 1; j <= i; j++)
            //    {
            //        Console.Write(j);
            //    }

            //    for (int j = i - 1; j >= 1; j--)
            //    {
            //        Console.Write(j);
            //    }
            //    Console.WriteLine();
            //}

            //for (int i = num3 - 1; i >= 0; i--)
            //{
            //    for (int j = 1; j <= i; j++)
            //    {
            //        Console.Write(j);
            //    }

            //    for (int j = i - 1; j >= 1; j--)
            //    {
            //        Console.Write(j);
            //    }
            //    Console.WriteLine();
            //}
            /* 4)
                  1
            1 2
            1 2 3
            1 2 3 4
            1 2 3 4 5
            1 2 3 4 5 6
            1 2 3 4 5 6 7
            */
            //Console.WriteLine("Num Pattern Program 3");
            //int num4 = 7;
            //for (int i = 0; i <= num4; i++)
            //{

            //    for (int j = 1; j < num4 - i; j++)
            //    {
            //        Console.Write(" ");
            //    }
            //    for (int j = 1; j <= i; j++)
            //    {
            //        Console.Write(j + " ");
            //    }
            //    Console.WriteLine();
            //}
            /*5)
               1
            2 2
            3 3 3
            4 4 4 4
            5 5 5 5 5
            6 6 6 6 6 6
            7 7 7 7 7 7 7
            */

            //Console.WriteLine("Num Pattern Program 4");
            //int num5 = 7;
            //for (int i = 0; i <= num5; i++)
            //{
            //    for (int j = 1; j <= num5 - i; j++)
            //    {
            //        Console.Write(" ");
            //    }

            //    for (int j = 1; j <= i; j++)
            //    {
            //        Console.Write(i + " ");
            //    }
            //    for (int j = 1; j <= num5 - i; j++)
            //    {
            //        Console.Write(" ");
            //    }
            //    Console.WriteLine();
            //}

            /*6. WAP to print following Pattern
            *
            * *
            * * *
            * * * *
            * * * * *
            * * * * *
            * * * *
            * * *
            * *
            *.
            */

            //Console.WriteLine("Star Pattern Program 2");
            //int num6 = 5;
            //for (int i = 0; i <= num6; i++)
            //{
            //    for (int j = 1; j <= i; j++)
            //    {
            //        Console.Write("*");
            //    }
            //    Console.WriteLine();
            //}

            //for (int i = num6; i >= 0; i--)
            //{
            //    for (int j = 1; j <= i; j++)
            //    {
            //        Console.Write("*");
            //    }
            //    Console.WriteLine();
            //}

            /*7) WAP to print following Pattern
            *
            * *
            * * *
            * * * *
            * * * * *
            * * * *
            * * *
            * *
            */

            //Console.WriteLine("Star Pattern Program 3");
            //int num7 = 5;
            //for (int i = 0; i <= num7; i++)
            //{
            //    for (int j = 1; j <= num7 - i; j++)
            //    {
            //        Console.Write(" ");
            //    }
            //    for (int j = 1; j <= i; j++)
            //    {
            //        Console.Write("*" + " ");
            //    }
            //    for (int j = 1; j <= num7 - i; j++)
            //    {
            //        Console.Write(" ");
            //    }
            //    Console.WriteLine();
            //}

            //for (int i = num7 - 1; i >= 0; i--)
            //{
            //    for (int j = 1; j <= num7 - i; j++)
            //    {
            //        Console.Write(" ");
            //    }
            //    for (int j = 1; j <= i; j++)
            //    {
            //        Console.Write("*" + " ");
            //    }
            //    for (int j = 1; j <= num7 - i; j++)
            //    {
            //        Console.Write(" ");
            //    }
            //    Console.WriteLine();
            //}

            /*8)     WAP to print following Pattern
            1 0 1 0 1
            0 1 0 1 0
            1 0 1 0 1
            0 1 0 1 0
            1 0 1 0 1
            */

            //Console.WriteLine("Num Pattern Program 5");
            //int num8 = 5;
            //for (int i = 1; i <=num8; i++)
            //{
            //    for (int j = 1; j <=num8; j++)
            //    {
            //        if ((i + j) % 2 == 0)
            //        {
            //            Console.Write("1 ");
            //        }
            //        else
            //        {
            //            Console.Write("0 ");
            //        }
            //    }
            //    Console.WriteLine();
            //}

            /*9)       ab
            ababab
            ababababab
            */

            //int num9 = 3;
            //for (int i = 0; i <= num9; i++)
            //{
            //    for (int j = 1; j <= num9 - i; j++)
            //    {
            //        Console.Write(" ");
            //    }
            //    for (int j = 1; j <= i * 2; j++)
            //    {
            //        Console.Write("ab");
            //    }
            //    Console.WriteLine();

            //}


            /*10.Generate your own function to satisfy the relationship between the inputs and outputs.
              Your task is to create a function that, when fed the inputs below, 
              produce the sample outputs shown.
              Examples
              832 ➞ 594
              51 ➞ 36*/

            Console.WriteLine("Enter the number :");
            int num = System.Convert.ToInt32(Console.ReadLine());

            int rem = 0;
            int sum = 0;
            int temp = num;
            while (num > 0) {
                rem = num % 10;
                sum = sum * 10 + rem;
                num = num / 10;
            }

            Console.WriteLine("Entered Number : "+temp);
            Console.WriteLine("Reverse Number :"+sum);

            int res = temp - sum;
            Console.WriteLine("Result :"+res);










        }
    }
}
