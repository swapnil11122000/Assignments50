using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Assignments1
{
    internal class Program1
    {
        static void Main(string[] args)
        {
            /* //Display sum of two integers. 
             int a = 3; int b = 4;
             int c = a + b;
             Console.WriteLine($"Addition is {c}");


             //Display numbers from 1 to 100.
             Console.WriteLine("1-100 numbers");
             for (int i = 1; i <= 100; i++)
             {
                 Console.Write(i);
             }
             Console.WriteLine(".");

             //Display all even numbers from 1 to 100.
             Console.WriteLine("Even numbers from 1-100");
             for (int i = 2; i <= 100; i += 2)
             {
                 Console.Write(i);
             }
             Console.WriteLine(".");

             //Display all odd numbers from 1 to 100
             Console.WriteLine("Odd numbers from 1-100");
             for (int i = 1; i <= 100; i += 2)
             {
                 Console.Write(i);
             }
             Console.WriteLine(".");

             //Accept starting number ‘fromNum’ and end number ‘toNum’ and find odd numbers starting  from ‘fromNum’ till ‘toNum’.
             Console.WriteLine("Odd numbers from User defined range");
             Console.WriteLine("starting number :");
             int fromnum = Convert.ToInt32(Console.ReadLine());
             Console.WriteLine("End NUmber :");
             int tonum = Convert.ToInt32(Console.ReadLine());
             for (int i = fromnum; i < tonum; i++)
             {
                 if (i % 2 == 1)
                 {
                     Console.Write(i);
                 }
             }
             Console.WriteLine(".");

             //Find maximum number from given 3 numbers.
             Console.WriteLine(" maximum number from given 3 numbers.");
             int d = 10; int f = 12; int g = 13;
             if (d > f && d > g)
             {
                 Console.WriteLine("d is greater");
             }
             else if (f > g)
             {
                 Console.WriteLine("f is greater");
             }
             else
             {
                 Console.WriteLine("g is greater");
             }


             //Add numbers 1 to 20 to array
             Console.WriteLine("Add numbers 1 to 20 to array");
             int[] arr = new int[20];
             int sum = 0;
             for (int i = 1; i < arr.Length; i++)
             {
                 sum = sum + i;
             }
             Console.WriteLine("sum is" + sum);

             //Display maximum number from array of 10 numbers.
             Console.WriteLine("Display maximum number from array of 10 numbers.");
             int[] arr1 = new int[10] { 1, 2, 3, 4, 5, 43, 7, 8, 9, 10 };
             int max = 0;
             for (int i = 1; i < arr1.Length; i++)
             {
                 if (arr1[i] > max)
                 {
                     max = arr1[i];
                 }
             }
             Console.WriteLine("max number is " + max);


             //Print alternate number from an array.
             Console.WriteLine("Print alternate number from an array.");
             int[] arr3 = { 101, 90, 65, 88, 30, 40, 100 };
             for (int i = 1; i < arr3.Length; i++)
             {
                 Console.Write(i + " ");
             }
             Console.WriteLine(".");


             //Create table of a number. 
             Console.WriteLine("Create table of a number. ");
             Console.WriteLine("Enter NUmber :");
             int tablenum = Convert.ToInt32(Console.ReadLine());
             for (int i = 1; i <= 10; i++)
             {
                 Console.WriteLine($"{tablenum} x {i} = {tablenum * i}");
             }

             //Find if given number is prime or not.
             Console.WriteLine("Giver number is prime number or not");
             int number;
             Console.WriteLine("Enter a number: ");
             number = Convert.ToInt32(Console.ReadLine());
             int isPrime = 1;

             for (int i = 2; i <= number/2; i++)
             {
                 if (number % i == 0)
                 {
                     isPrime = 0;
                     break;
                 }
             }
             if (isPrime==1)
             {
                 Console.WriteLine(number + " is a prime number");
             }
             else
             {
                 Console.WriteLine(number + " is not a prime number");
             }
             //  Console.ReadLine();

             //Factorial
             Console.WriteLine("factorial");
             Console.WriteLine("Enter number");
             int num4=Convert.ToInt32(Console.ReadLine());
             int fact = 1;
             for (int i = 1; i <=num4; i++)
             {
                 fact *= i;
             }
             Console.WriteLine("Factorial is :"+fact);

             // Accept two numbers a and b. Find value of ab

             Console.WriteLine(" Accept two numbers a and b. Find value of araised to b");
             Console.WriteLine("Enter first number");
             int firstnum=Convert.ToInt32(Console.ReadLine());
             Console.WriteLine("Enter second number");
             int secondnum=Convert.ToInt32(Console.ReadLine());
             int result = 1;
             for (int i = 1; i <=secondnum; i++)
             {
                 result*= firstnum;
             }
             Console.WriteLine($"firstnumber :{firstnum} raisd to second number {secondnum} : {result}");


             // Count number of digits in any number.

             Console.WriteLine(" Count number of digits in any number.");
             Console.WriteLine("Enter number");
             int op=Convert.ToInt32(Console.ReadLine());
             int io = op;
             int count = 0;
             while (op!=0)
             {
                 op = op / 10;
                 count++;
             }
             Console.WriteLine($"number of digits in Number {io} :{count}");

             //Accept radius of a circle. Display area of a circl
             Console.WriteLine("Accept radius of a circle. Display area of a circl");
             Console.WriteLine("Enter radius ");
             double red=Convert.ToInt32(Console.ReadLine());
             double area = red * red * 3.14;
             Console.WriteLine("Area of circle is :"+area);

             //18. Accept length and breadth of a rectangle and find perimeter.
             Console.WriteLine("18. Accept length and breadth of a rectangle and find perimeter.");
             Console.WriteLine("Enter length of rectangle");
             int length=Convert.ToInt32(Console.ReadLine());
             Console.WriteLine("Enter breadth");
             int breadth=Convert.ToInt32(Console.ReadLine());
             int arear = length * breadth;
             Console.WriteLine("Area of rectangle is :"+arear);

             //19. Accept two angles of triangle and find third angle.

             Console.WriteLine("19. Accept two angles of triangle and find third angle.");
             Console.WriteLine("Enter the measurement of first angle");
             int ang1=Convert.ToInt32(Console.ReadLine());
             Console.WriteLine("Enter the measurement of second angle");
             int ang2=Convert.ToInt32(Console.ReadLine());
             int ang3 = 180 - (ang1 + ang2);
             Console.WriteLine($"Measurement of third angle is :{ang3}");

             //20. Find maximum number from array of 10 numbers.

             Console.WriteLine("20. Find maximum number from array of 10 numbers");
             int[] arr4 = new int[5] { 3, 6, 8, 34, 56 };
             int max1 = 0;
             for (int i = 1; i < arr4.Length; i++)
             {
                 if (arr4[i]>max1)
                 {
                     max1 = arr4[i];
                 }

             }
             Console.WriteLine($"Max number from array given : {max1}");

             //21. Find minimum number from array of 10 numbers.
             Console.WriteLine("21. Find minimum number from array of 10 numbers.");
             int[] arr5 = new int[10] { 3, 4, 5, 6, 7 ,34,45,56,56,56};
             int min = int.MaxValue;
             *//* foreach (int num in arr5)
              {
                  if (num < min)
                  {
                      min = num;
                  }
              }*//*
             for (int i = 0; i < arr5.Length; i++)
             {
                 if (arr5[i] < min)
                 {
                     min = arr5[i];
                 }

             }
             Console.WriteLine($"minimun number from array is {min}");


             //22. Reverse an array of 5 numbers.
             Console.WriteLine("22. Reverse an array of 5 numbers.");
             int[] arr6 = new int[5] { 34, 45, 56, 67, 78 };
             Console.WriteLine("Original array");
             for (int i = 0; i < arr6.Length; i++)
             {
                 Console.WriteLine(arr6[i]);
             }
             Console.WriteLine("After reversing ");
             for (int i = arr6.Length-1; i >0; i--)
             {
                 Console.WriteLine(arr6[i]);
             }
             Console.WriteLine(".");

             //23. Swap values of two interger variables using third variable.

             Console.WriteLine("23. Swap values of two interger variables using third variable.");
             int var1 = 23;
             int var2 = 45;
             int temp3;
             Console.WriteLine($"Before swapping first :{var1} second :{var2}");

             temp3 = var1;
             var1= var2;
             var2 = temp3;

             Console.WriteLine($"After swapping first :{var1} second :{var2}");


             //24. Swap values of two integer variables without using third variable.
             Console.WriteLine("24. Swap values of two integer variables without using third variable.");

             int fvar = 3;
             int svar = 5;
             Console.WriteLine($"Values before swapping first:{fvar} second :{svar}");
             fvar = fvar + svar;
             svar= fvar - svar;
             fvar= fvar - svar;
             Console.WriteLine($"Value safter swapping first :{fvar} second:{svar}");

             //25. Generate Fibonacci series. 0,1, 1, 2, 3, 5,8 ….. k. where k < n . n is entered by user

             Console.WriteLine("25. Generate Fibonacci series. ");
             Console.WriteLine("Enter number :");
             int fib=Convert.ToInt32(Console.ReadLine());
             int fib1 = 0; int fib2=1;
             int fibresult;
             Console.Write($"Fibonacci series :{fib1+" "}{fib2+" "}");

             for (int i = 1; i < fib; i++)
             {
                 result=fib1+ fib2;
                 Console.Write(result+" ");
                 fib1 = fib2;
                 fib2 = result;

             }
             Console.WriteLine(".");*/

            /* //27. Find duplicate numbers in an array of integers.
             Console.WriteLine("27. Find duplicate numbers in an array of integers.");
             int[] arr7 = new int[] { 1, 2, 3, 2, 4, 2, 4, 4, 4, 4 };
             for (int i = 0; i < arr7.Length; i++)
             {
                 for (int j = i + 1; j < arr7.Length; j++)
                 {
                     if (arr7[i] == arr7[j])
                     {
                         Console.WriteLine($"{arr7[i]} is duplicate");
                     }

                 }
             }*/
            /*  int[] array = new int[] { 1, 2, 3, 4, 5, 2, 4, 7, 8, 9, 7 ,7,7,6,5,4,3};

              for (int i = 0; i < array.Length; i++)
              {
                  for (int j = i + 1; j < array.Length; j++)
                  {
                      if (array[i] == array[j])
                      {
                          Console.WriteLine($"{array[i]} is a duplicate.");
                      }
                  }
              }*/

            //Conver decimal number into binary
            //Console.WriteLine("28. Convert decimal number to binary.");
            /*int decimalNumber = 25;
            string binaryNumber = "";

            while (decimalNumber > 0)
            {
                binaryNumber = (decimalNumber % 2) + binaryNumber;
                decimalNumber = decimalNumber / 2;
            }

            Console.WriteLine("Binary representation: " + binaryNumber);*/
            /* int decnum = 25;
             string binnum = "";
             while (decnum>0)
             {
                 binnum = (decnum % 2) + binnum;
                 decnum = decnum / 2;
             }
             Console.WriteLine(binnum);*/

            //29. Check if two arrays (of integers) are equal.
            /* Console.WriteLine("29. Check if two arrays (of integers) are equal.");
             int[] array1 = new int[] { 1, 2, 3, 4, 5 };
             int[] array2 = new int[] { 1, 2, 3, 5, 5 };

             bool areequal = true;
             if (array1.Length!=array2.Length)
             {
                 areequal = false;
             }
             else
             {
                 for (int i = 0; i < array1.Length; i++)
                 {
                     if (array1[i] != array2[i])
                     {
                         areequal = false;
                         break;
                     }
                 }
             }
             Console.WriteLine("arrays are equal"+areequal);*/

            //30. Remove given element from an array. 


            //31. Check if given number is Armstrong or not.
            /* Console.WriteLine("31. Check if given number is Armstrong or not.");
             Console.WriteLine("Enter a number: ");
             int num = Convert.ToInt32(Console.ReadLine());

             int originalNumber = num;
             int result = 0;
             int digit = 0;
             int digits = 0;

             int temp = originalNumber;
             while (temp != 0)
             {
                 digits++;
                 temp /= 10;
             }

             temp = originalNumber;
             while (temp != 0)
             {
                 digit = temp % 10;
                 int power = 1;
                 for (int i = 0; i < digits; i++)
                 {
                     power *= digit;
                 }
                 result += power;
                 temp /= 10;
             }

             if (result == originalNumber)
                 Console.WriteLine(num + " is an Armstrong number");
             else
                 Console.WriteLine(num + " is not an Armstrong number");*/


            /* //32. Find sum of all digits of a number.
             Console.WriteLine("32. Find sum of all digits of a number.");
             int addnum = Convert.ToInt32(Console.ReadLine());
             int sumofnum = 0;
             while (addnum!=0)
             {

                 int temp5 = addnum % 10;
                 sumofnum += temp5;
                 addnum /=10;
             }
             Console.WriteLine(sumofnum);
 */
            //33. Count number of occurrences of a number in an array
            /* Console.WriteLine("33. Count number of occurrences of a number in an array");
             int[] occarr = new int[] { 1, 2, 3, 4, 5, 4, 3 };
             int number = 3;
             int occurances=0;
             for (int i = 0; i < occarr.Length; i++)
             {
                 if (occarr[i]==number)
                 {
                     occurances++;
                 }
             }
             Console.WriteLine(occurances);
 */
            //34. Find out given number is palindrome or not.
            /* Console.WriteLine("34. Find out given number is palindrome or not.");
             int pali = Convert.ToInt32(Console.ReadLine());
             int originalnumber = pali;
             int reverse=0;
             while (pali!=0)
             {
                 int temp1 = pali % 10;
                 reverse = reverse*10 + temp1;
                 pali /= 10;
             }
             if (originalnumber==reverse)
             {
                 Console.WriteLine("It is Palindrome");
             }
             else
             {
                 Console.WriteLine("It is not Palindrome");
             }
 */
            //Find pair of elements in array whose number is given numbe
            /* Console.WriteLine("Find pair of elements in array whose number is given number");
             int[] givenarray = new int[] { 4, 5, 7, 1, 2, 3, 0 };
             for (int i = 0; i < givenarray.Length; i++)
             {
                 for (int j = i+1; j < givenarray.Length; j++)
                 {
                     if (givenarray[i] + givenarray[j]==7)
                     {
                         Console.WriteLine($"{givenarray[i]},{givenarray[j]}");
                     }
                 }
             }

 */
            /* //Find a continuous sub array whose sum is equal to given number.
             Console.WriteLine("Find a continuous sub array whose sum is equal to given number.");
             int[] arr = { 12, 4, 2, 10, 5, 1 };
             int targetSum = 16;

             for (int i = 0; i < arr.Length; i++)
             {
                 int currentSum = arr[i];
                 for (int j = i + 1; j < arr.Length; j++)
                 {
                     currentSum += arr[j];
                     if (currentSum == targetSum)
                     {
                         Console.WriteLine("The continuous subarray with the target sum starts at index " + i + " and ends at index " + j);
                         return;
                     }
                     if (currentSum > targetSum)
                         break;
                 }
             }

             Console.WriteLine("No continuous subarray with the target sum was found in the array");
        */

            //37. Move zeros to beginning or end of array. 

            /*Console.WriteLine("37. Move zeros to beginning or end of array. ");
            int[] arr = { 2, 10, 0, 5, 3, 0, 4, 1 };
            int count = arr.Length - 1;

            for (int i = arr.Length - 1; i >= 0; i--)
            {
                if (arr[i] != 0)
                {
                    arr[count] = arr[i];
                    count--;
                }
            }

            while (count >= 0)
            {
                arr[count] = 0;
                count--;
            }

            Console.WriteLine("Array with zeros moved to the beginning: " + string.Join(", ", arr));

            int[] arr = { 2, 10, 0, 5, 3, 0, 4, 1 };
            int count = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] != 0)
                {
                    arr[count] = arr[i];
                    count++;
                }
            }

            while (count < arr.Length)
            {
                arr[count] = 0;
                count++;
            }

            Console.WriteLine("Array with zeros moved to the end: " + string.Join(", ", arr));*/

            //38. Reverse and add till you get palindrome. 

            //Console.WriteLine("38. Reverse and add till you get palindrome. ");
            /*int number = 7325;
            int iterations = 0;

            while (true)
            {
                int reverse = 0;
                int originalNumber = number;

                while (originalNumber != 0)
                {
                    int lastDigit = originalNumber % 10;
                    reverse = reverse * 10 + lastDigit;
                    originalNumber /= 10;
                }

                if (number == reverse)
                {
                    Console.WriteLine("Palindrome obtained: " + number);
                    Console.WriteLine("Iterations: " + iterations);
                    break;
                }
                else
                {
                    iterations++;
                    number += reverse;

                }
            }*/

            //Append one array to another array.
            //  Console.WriteLine("Append one array to another array.");
            /* int[] array1 = new int[] { 5, 6, 7, 8 };
             int[] array2 = new int[] { 9, 10, 11, 12 };

             int[] result = new int[array1.Length + array2.Length];
             for (int i = 0; i < array1.Length; i++)
             {
                 result[i] = array1[i];
             }
             for (int i = 0; i < array2.Length; i++)
             {
                 result[array1.Length + i] = array2[i];
             }

             Console.Write("Resultant Array: [");
             for (int i = 0; i < result.Length; i++)
             {
                 Console.Write(result[i]);
                 if (i < result.Length-1 )
                 {
                     Console.Write(", ");
                 }
             }
             Console.WriteLine("]");*/

            //Sort array of 5 integers
            // Console.WriteLine("Sort array of 5 integers");
            /* int[] numbers = new int[] { 4, 1, 5, 2, 3 };
             int n = numbers.Length;

             for (int i = 0; i < n - 1; i++)
             {
                 for (int j = 0; j < n - i - 1; j++)
                 {
                     if (numbers[j] > numbers[j + 1])
                     {
                         int temp = numbers[j];
                         numbers[j] = numbers[j + 1];
                         numbers[j + 1] = temp;
                     }
                 }
             }

             Console.Write("Sorted Array: [");
             for (int i = 0; i < n; i++)
             {
                 Console.Write(numbers[i]);
                 if (i < n - 1)
                 {
                     Console.Write(", ");
                 }
             }
             Console.WriteLine("]");*/

            //divide  array in two parts and reverse it
            /*Console.WriteLine("divide  array in two parts and reverse it");
            int[] numbers = new int[] { 1, 2, 3, 4, 5, 6 };
            int n = numbers.Length;
            int mid = n / 2;

            int[] firstHalf = new int[mid];
            int[] secondHalf = new int[n - mid];

            for (int i = 0; i < mid; i++)
            {
                firstHalf[i] = numbers[i];
            }
            for (int i = mid; i < n; i++)
            {
                secondHalf[i - mid] = numbers[i];
            }

            for (int i = 0; i < mid / 2; i++)
            {
                int temp = firstHalf[i];
                firstHalf[i] = firstHalf[mid - i - 1];
                firstHalf[mid - i - 1] = temp;
            }

            for (int i = 0; i < (n - mid) / 2; i++)
            {
                int temp = secondHalf[i];
                secondHalf[i] = secondHalf[n - mid - i - 1];
                secondHalf[n - mid - i - 1] = temp;
            }

            Console.Write("Resultant Array: [");
            for (int i = 0; i < mid; i++)
            {
                Console.Write(firstHalf[i]);
                Console.Write(", ");
            }
            for (int i = 0; i < n - mid; i++)
            {
                Console.Write(secondHalf[i]);
                if (i < n - mid - 1)
                {
                    Console.Write(", ");
                }
            }
            Console.WriteLine("]");*/

            //displaying elements of two dimensional array
            /* Console.WriteLine("displaying elements of two dimensional array");
             int[,] array = new int[,] { { 1, 2, 3, 4 }, { 5, 6, 7, 8 }, { 9, 10, 11, 12 } };
             int rows = array.GetLength(0);
             int columns = array.GetLength(1);

             Console.WriteLine("Elements of 2D Array: ");
             for (int i = 0; i < rows; i++)
             {
                 for (int j = 0; j < columns; j++)
                 {
                     Console.Write("array[" + i + "," + j + "] = " + array[i, j] + " ");
                 }
                 Console.WriteLine();

             }*/

            //If a number from a two dimensional array is given , its position in the array should be show
            /*Console.WriteLine("If a number from a two dimensional array is given , its position in the array should be show");
            int[,] array = new int[,] { { 1, 2, 3, 4 }, { 5, 6, 7, 8 } };
            int rows = array.GetLength(0);
            int columns = array.GetLength(1);

            Console.WriteLine("Enter a number to find its position in the array: ");
            int number = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    if (array[i, j] == number)
                    {
                        Console.WriteLine("The number " + number + " is at position (row " + (i + 1) + ", column " + (j + 1) + ")");
                        return;
                    }
                }
            }*/

            // Console.WriteLine("The number " + number + " is not present in the array");

            //. Find maximum number from each row of two dimensional array with dimensions ( 3 x 4)
            /*Console.WriteLine(". Find maximum number from each row of two dimensional array with dimensions ( 3 x 4)");
            int[,] array = new int[,] { { 1, 2, 3, 4 }, { 5, 6, 7, 8 }, { 9, 10, 11, 12 } };
            int rows = array.GetLength(0);
            int columns = array.GetLength(1);

            Console.WriteLine("Maximum number from each row: ");
            for (int i = 0; i < rows; i++)
            {
                int max = array[i, 0];
                for (int j = 1; j < columns; j++)
                {
                    if (array[i, j] > max)
                    {
                        max = array[i, j];
                    }
                }
                Console.WriteLine("Row " + (i + 1) + ": " + max);
            }*/




            //Find minimum number from a two dimensional array 
            /* Console.WriteLine("Find minimum number from a two dimensional array ");
             int[,] array = new int[,] { { 1, 2, 3, 4 }, { 5, 6, 7, 8 }, { 9, 10, 11, 12 } };
             int rows = array.GetLength(0);
             int columns = array.GetLength(1);

             int min = array[0, 0];
             for (int i = 0; i < rows; i++)
             {
                 for (int j = 0; j < columns; j++)
                 {
                     if (array[i, j] < min)
                     {
                         min = array[i, j];
                     }
                 }
             }
             Console.WriteLine("The minimum number in the array is: " + min);*/


            //. Reverse two dimensional array in following manner.
            // Original array = { { 1, 2 }, { 3, 4 }, { 5, 6 } } reversed array will be { { 5,6} , { 3,4} ,{ 1,2} }
            /*            int[,] array = new int[,] { { 1, 2 }, { 3, 4 }, { 5, 6 } };
                        int rows = array.GetLength(0);
                        int columns = array.GetLength(1);

                        Console.WriteLine("Original Array: ");
                        for (int i = 0; i < rows; i++)
                        {
                            for (int j = 0; j < columns; j++)
                            {
                                Console.Write(array[i, j] + " ");
                            }
                            Console.WriteLine();
                        }

                        Console.WriteLine("Reversed Array: ");
                        for (int i = rows - 1; i >= 0; i--)
                        {
                            for (int j = 0; j < columns; j++)
                            {
                                Console.Write(array[i, j] + " ");
                            }
                            Console.WriteLine();
                        }*/




            //Accept marks of 3 subjects physics ,chemistry , maths out of 100. Calculate percentage.
            /*int physicsMarks, chemistryMarks, mathsMarks;
            float percentage;

            Console.WriteLine("Enter marks of Physics (out of 100): ");
            physicsMarks = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter marks of Chemistry (out of 100): ");
            chemistryMarks = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter marks of Maths (out of 100): ");
            mathsMarks = Convert.ToInt32(Console.ReadLine());

            percentage = (physicsMarks + chemistryMarks + mathsMarks) / 3.0f;

            Console.WriteLine("Percentage: " + percentage + "%");

            if (percentage > 80)
                Console.WriteLine("Grade: A");
            else if (percentage > 70)
                Console.WriteLine("Grade: B");
            else if (percentage > 60)
                Console.WriteLine("Grade: C");
            else
                Console.WriteLine("Grade: D");*/



            //Input basic salary and calculate gross 
            /* int basicSalary;
             float da, hra, grossSalary;

             Console.WriteLine("Enter Basic Salary: ");
             basicSalary = Convert.ToInt32(Console.ReadLine());

             if (basicSalary <= 10000)
             {
                 da = 0.8f * basicSalary;
                 hra = 0.2f * basicSalary;
             }
             else if (basicSalary <= 20000)
             {
                 da = 0.9f * basicSalary;
                 hra = 0.35f * basicSalary;
             }
             else
             {
                 da = 0.95f * basicSalary;
                 hra = 0.4f * basicSalary;
             }

             grossSalary = basicSalary + da + hra;
             Console.WriteLine("Gross Salary: " + grossSalary);*/



            // Display following pattern.If number of rows given is 4
            /* for (int i = 1; i <= 4; i++)
             {
                 for (int j = 1; j <= i; j++)
                 {
                     Console.Write(j + " ");
                 }
                 Console.WriteLine();
             }*/

            /* for (int i = 4; i >= 1; i--)
             {
                 for (int k = 4; k > i; k--)
                 {
                     Console.Write("   ");
                 }
                 for (int j = i; j >= 1; j--)
                 {
                     Console.Write(j + " ");
                 }
                 Console.WriteLine();
             }
 */
            //Display following pattern. If no. of rows given is 3.
            for (int i = 1; i <= 3; i++)
            {
                for (int k = 3; k > i; k--)
                {
                    Console.Write(" ");
                }
                for (int j = 1; j <= 2 * i - 1; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }






        }
    }
}
