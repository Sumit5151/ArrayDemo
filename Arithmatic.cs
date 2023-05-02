using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayDemo
{
    internal class Arithmatic
    {

        public void AdditionOfArray()
        {
            Console.WriteLine("Please enter 10 numbers");
            //int num1, num2, num3, num4, num5;

            int[] num = new int[10];

            for (int i = 0; i < 10; i++)
            {
                num[i] = Convert.ToInt32(Console.ReadLine());
            }

            Console.WriteLine("Printing the array");

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(num[i]);
            }


            //num[0] = Convert.ToInt32(Console.ReadLine());
            //num[1] = Convert.ToInt32(Console.ReadLine());
            //num[2] = Convert.ToInt32(Console.ReadLine());
            //num[3] = Convert.ToInt32(Console.ReadLine());
            //num[4] = Convert.ToInt32(Console.ReadLine());
            //num[5] = Convert.ToInt32(Console.ReadLine());
            //num[6] = Convert.ToInt32(Console.ReadLine());
            //num[7] = Convert.ToInt32(Console.ReadLine());
            //num[8] = Convert.ToInt32(Console.ReadLine());
            //num[9] = Convert.ToInt32(Console.ReadLine());

            int result = 0;
            for (int i = 0; i < 10; i++)
            {
                result = result + num[i];
            }


            Console.WriteLine("Addition of array =" + result);
            //int result = num[0] = 10 
            //           + num[1] = 20
            //           + num[2] = 30
            //           + num[3] = 40
            //           + num[4] = 50
            //           + num[5] = 60
            //           + num[6] = 70
            //           + num[7] = 80
            //           + num[8] = 90
            //           + num[9] = 100

        }


        public void PrintAllOddNumbersFromArray()
        {
            Console.WriteLine("Please enter 10 numbers");

            int[] num = new int[10];

            for (int i = 0; i < 10; i++)
            {
                num[i] = Convert.ToInt32(Console.ReadLine());
            }

            Console.WriteLine("Odd numbers");
            for (int i = 0; i < 10; i++)
            {
                if (num[i] % 2 == 1)
                {
                    Console.WriteLine(num[i]);
                }
            }


            Console.WriteLine("Even numbers");
            for (int i = 0; i < 10; i++)
            {
                if (num[i] % 2 == 0)
                {
                    Console.WriteLine(num[i]);
                }
            }


        }


        public void ReverseArray()
        {
            Console.WriteLine("please enter 5 numbers");

            int[] num = new int[5];

            for (int i = 0; i < 5; i++)
            {
                num[i] = Convert.ToInt32(Console.ReadLine());
            }

            Console.WriteLine("Array before reverse");

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine(num[i]);
            }


            Console.WriteLine("Array after reverse");
            for (int i = 4; i >= 0; i--)
            {
                Console.WriteLine(num[i]);
            }


        }


        public void FindMaxNumberFromArray()
        {
            int[] num = new int[] { 45, 67, 21, 34, 09, 57, 388, 332, 400, 44 };

            //int[] num = new int[10];

            //Console.WriteLine("Please enter 10 numbers");

            //for (int i = 0; i < 10; i++)
            //{
            //    num[i] = Convert.ToInt32(Console.ReadLine());
            //}


            int max = num[0];

            for (int i = 1; i < 10; i++)
            {
                if (max < num[i])
                {
                    max = num[i];
                }
            }

            Console.WriteLine("The maximum number = " + max);


        }


        public void BubbleSort()
        {
            int[] num = new int[] { 45, 67, 21, 34, 09, 57, 388, 332, 400, 44 };


            for (int i = 0; i < 9; i++)
            {
                for (int j = i + 1; j < 10; j++)
                {

                    if (num[i] > num[j])
                    {
                        int temp = num[i];    //67
                        num[i] = num[j];  //21
                        num[j] = temp;
                    }
                }
            }


            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(num[i]);
            }


        }



        public void SwappingTwoNumbersWithoutThirdVariable()
        {
            int a = 10;
            int b = 20;


            Console.WriteLine("Values before swapping");
            Console.WriteLine("a = "+a +" b= "+b);
            

            a = a + b;
            b = a - b;
            a = a - b;

            Console.WriteLine("Values after swapping");
            Console.WriteLine("a = " + a + " b= " + b);



        }

    }
}



