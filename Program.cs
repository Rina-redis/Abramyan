using System;

namespace Abramyan
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Boolean10(3, 3)); 
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
        public static void Integer30(int year)
        {
            int century = (year-1)/ 100 + 1;            
            Console.WriteLine(century);
        }


        public bool Boolean2(int a)
        {
            return a % 2 != 0;
        }
        public bool Boolean4(int a, int b)
        {
            return (a > 2 && b <= 3);
        }
        public bool Boolean6(int a, int b, int c)
        {
            return (b > a && c > b);
        }
        public bool Boolean8(int a, int b)
        {
            return a % 2 != 0 && b % 2 != 0;
        }
        public static bool Boolean10(int a, int b)
        {
            return a % 2 != 0 ^ b % 2 != 0;
        }
        public static bool Boolean12(int a, int b, int c)
        {
            return a % 2 != 0 && b % 2 != 0 && c % 2 != 0;
        }
        public static bool Boolean14(int a, int b, int c)
        {
            return a > 0 ^ b > 0 ^ c > 0;
        }
        public static bool Boolean16(int a)
        {
            return a % 2 == 0 && a / 10 > 0;
        }
        public static bool Boolean18(int a, int b, int c)
        {
            return a == b || b == c || a == c;
        }
        public static bool Boolean19(int a, int b, int c)
        {
            return a == -b || b == -c || a ==-c;
        }
        public static bool Boolean20(int a)
        {
            int hundrets = a / 100;
            int tens = (a % 100) / 10;
            int ones = a % 10;
            return hundrets != tens && tens != ones && hundrets != ones;
        }
        public static bool Boolean22(int a)
        {
            int hundrets = a / 100;
            int tens = (a % 100) / 10;
            int ones = a % 10;
            return (hundrets > tens && tens > ones) || (hundrets < tens && tens < ones);
        }
        public static bool Boolean24(int a, int b, int c)
        {
            float discriminant = (b * b) - (4 * a * c);
            return discriminant > 0;
        }
        public static bool Boolean26(int x, int y)
        {
            return x > 0 && y < 0;
        }
        public static bool Boolean28(int x, int y)
        {
            return (x > 0 && y > 0) || (x < 0 && y < 0);
        }
        public static bool Boolean29(int x, int y, int x1, int y1, int x2, int y2)
        {
            return x>x1 && x < x2 && y > y1 && y < y2;
        }
        public static bool Boolean30(int a, int b, int c)
        {
            return a==b&&b==c;
        }
        public static bool Boolean32(int a, int b, int c)
        {
            return (c * c == a * a + b * b) || (a * a == b * b + c * c) || (b * b == a * a + c * c);
        }
        public static bool Boolean34(int x, int y)
        {
            return (x + y) % 2 != 0; //why?
        }
        public static bool Boolean35(int x1, int y1, int x2, int y2)
        {
            return (x1 + y1) % 2 == (x2 + y2) % 2;
        }
        public static bool Boolean36(int x1, int y1, int x2, int y2)
        {
            return x1==x2 || y1==y2;
        }
        public static bool Boolean37(int x1, int y1, int x2, int y2)
        {
            return Math.Abs(x1 - x2) == 1 || Math.Abs(y1 - y2) == 1;
        }
        public static bool Boolean38(int x1, int y1, int x2, int y2)
        {
            return Math.Abs(x1 - x2) ==  Math.Abs(y1 - y2);
        }
        public static bool Boolean40(int x1, int y1, int x2, int y2)
        {
            return (Math.Abs(x1 - x2) == 2 && Math.Abs(y1 - y2) == 1) || (Math.Abs(x1 - x2) == 1 && Math.Abs(y1 - y2) == 2);
        }
    }
}
