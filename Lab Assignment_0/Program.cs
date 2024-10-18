using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Assignment0
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Assignment0 Question 1");
            A1Q1 A1Q1 = new A1Q1();
            A1Q1.function1();
            Console.ReadLine();
            Console.WriteLine("Assignment Question 2");
            A1Q2 A1Q2 = new A1Q2();
            A1Q2.function1();
            Console.ReadLine();
            Console.WriteLine("Assignment Question 3");
            A1Q3 A1Q3 = new A1Q3();
            A1Q3.function1();
            Console.ReadLine();
            Console.WriteLine("Assignment Question 4");
            A1Q4 A1Q4 = new A1Q4();
            A1Q4.function1();
            Console.ReadLine();
        }
    }
    class A1Q1
    {
        private int num;
        public void function1()
        {
            int sum = 0;
            int[] array = { 200, -150, 340, 500, -100 };
            for (int i = 0; i < array.Length; i++)
            {
                sum += array[i];
            }
            Console.WriteLine(sum);
        }
    }
    class A1Q2
    {
        private int num;
        public void function1()
        {
            float[] score = { 85.5f, 90.3f, 78.4f, 88.9f, 92.1f };
            float sum = 0.0f;
            int count = score.Length;
            for (int i = 0; i < count; i++)
            {
                sum += score[i];
            }
            float average = sum / count;
            Console.WriteLine(average);
        }
    }
    class A1Q3
    {
        private int num;
        public void function1()
        {
            int max = 0;
            int[] array = { 1500, 2300, 999, 3200, 1750 };
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] > max)
                {
                    max = array[i];
                }
            }
            Console.WriteLine(max);
        }
    }
    class A1Q4
    {
        private int num;
        public void function1()
        {
            int[] participantCodes = { 102, 215, 324, 453, 536 };
            int evenCount = 0;
            int oddCount = 0;
            for (int i = 0; i < participantCodes.Length; i++)
            {
                if (participantCodes[i] % 2 == 0)
                {
                    evenCount++;
                }
                else
                {
                    oddCount++;
                }
            }
            Console.WriteLine(evenCount);
            Console.WriteLine(oddCount);
        }
    }
}