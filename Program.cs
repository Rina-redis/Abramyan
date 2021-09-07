using System;

namespace Abramyan
{
    class Program
    {
        static void Main(string[] args)
        {
            Integer29(15,5,2);
        }
        public static void Integer7(int x)
        {
            int tens = x / 10;
            int ones = x % 10;
            int sum = tens + ones;
            int multiplication = tens * ones;
        }
        public static void Integer8(int x)
        {
            int tens = x / 10;
            int ones = x % 10;
            Console.WriteLine(ones + tens);
        }
        public static void Integer10(int x)
        {
            int ones = x % 10;
            int tens = (x % 100)/10;
            Console.WriteLine(ones +" "+ tens);
        }
        public static void Integer12(int x)
        {
            int ones = x % 10;
            int tens = (x % 100) / 10;
            int hundrets = x / 100;
            Console.WriteLine(ones + "" + tens + "" + hundrets);
        }
        public static void Integer16(int x)
        {
            int ones = x % 10;
            int tens = (x % 100) / 10;
            int hundrets = x / 100;
            Console.WriteLine(hundrets + "" + ones + "" + tens);
        }
        public static void Integer17(int x)
        {
            int hundrets = (x % 100) / 10;
            Console.WriteLine(hundrets);
        }
        public static void Integer19(int n)
        {
            int secondsAfterLastMinute = n % 60;
            Console.WriteLine(secondsAfterLastMinute);
        }
        public static void Integer23(int n)
        {
            int minutes = n % 3600 / 60;
            Console.WriteLine(minutes);
        }
        public static void Integer26(int k)
        {
            int numberOfDay = (k % 7) + 1;
            Console.WriteLine(numberOfDay);
        }
        public static void Integer28(int k, int n)
        {
            int numberOfDay = (k % 7) + n-1;
            Console.WriteLine(numberOfDay);
        }
        public static void Integer29(int a, int b, int c)
        {
            int rectangleArea = a * b;
            int squareArea = 4*c;
            int numberOfSquaresInRectangle = rectangleArea / squareArea;
            int leftedArea = rectangleArea - (squareArea * numberOfSquaresInRectangle);
            Console.WriteLine(numberOfSquaresInRectangle + " " + leftedArea);
        }
    }
}
