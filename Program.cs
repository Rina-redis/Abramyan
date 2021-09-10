using System;

namespace Abramyan
{
    class Program
    {
        static void Main(string[] args)
        {
            Case18(514);
        }
        #region Integer
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
            int tens = (x % 100) / 10;
            Console.WriteLine(ones + " " + tens);
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
            int numberOfDay = (k % 7) + n - 1;
            Console.WriteLine(numberOfDay);
        }
        public static void Integer29(int a, int b, int c)
        {
            int rectangleArea = a * b;
            int squareArea = 4 * c;
            int numberOfSquaresInRectangle = rectangleArea / squareArea;
            int leftedArea = rectangleArea - (squareArea * numberOfSquaresInRectangle);
            Console.WriteLine(numberOfSquaresInRectangle + " " + leftedArea);
        }
        public static void Integer30(int year)
        {
            int century = (year - 1) / 100 + 1;
            Console.WriteLine(century);
        }

        #endregion 
        #region Boolean
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
            return a == -b || b == -c || a == -c;
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
            return x > x1 && x < x2 && y > y1 && y < y2;
        }
        public static bool Boolean30(int a, int b, int c)
        {
            return a == b && b == c;
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
            return x1 == x2 || y1 == y2;
        }
        public static bool Boolean37(int x1, int y1, int x2, int y2)
        {
            return Math.Abs(x1 - x2) == 1 || Math.Abs(y1 - y2) == 1;
        }
        public static bool Boolean38(int x1, int y1, int x2, int y2)
        {
            return Math.Abs(x1 - x2) == Math.Abs(y1 - y2);
        }
        public static bool Boolean40(int x1, int y1, int x2, int y2)
        {
            return (Math.Abs(x1 - x2) == 2 && Math.Abs(y1 - y2) == 1) || (Math.Abs(x1 - x2) == 1 && Math.Abs(y1 - y2) == 2);
        }
        #endregion
        #region If
        public static void If2(int x)
        {
            if (x > 0)
                x++;
            else
                x -= 2;
        }
        public static void If4(int a, int b, int c)
        {
            int N = 0;
            if (a > 0)
                ++N;
            if (b > 0)
                ++N;
            if (c > 0)
                ++N;
            Console.WriteLine(N);
        }
        public static void If6(int a, int b)
        {
            if (a > b)
                Console.WriteLine(a);
            else
                Console.WriteLine(b);

        }
        public static void If8(int a, int b)
        {
            if (a > b)
                Console.WriteLine(a + " " + b);
            else
                Console.WriteLine(b + " " + a);
        }
        public static void If10(int a, int b)
        {
            if (a == b)
            {
                a += b;
                b = a;
            }
            else
            {
                a = b = 0;
            }
            Console.WriteLine("a: " + a + "\n" + "b: " + b);
        }
        public static void If12(int a, int b, int c)
        {
            int min = 0;
            if (a < b && a < c)
                min = a;
            if (b < c && b < a)
                min = b;
            if (c < b && c < a)
                min = c;
            Console.WriteLine(min);
        }
        public static void If14(int a, int b, int c)
        {
            int min = 0, max = 0;
            if (a < b && a < c)
                min = a;
            if (b < c && b < a)
                min = b;
            if (c < b && c < a)
                min = c;
            if (a > b && a > c)
                max = a;
            if (b > c && b > a)
                max = b;
            if (c > b && c > a)
                max = c;
            Console.WriteLine(min + " " + max);
        }
        public static void If16(float a, float b, float c)
        {
            if (a < b && b < c)
            {
                a *= 2;
                b *= 2;
                c *= 2;
            }
            else
            {
                a = -a;
                b = -b;
                c = -c;
            }
            Console.WriteLine(a + " " + b + " " + " " + c);
        }
        public static void If18(int a, int b, int c)
        {
            if (a == b)
                Console.WriteLine(3);
            if (b == c)
                Console.WriteLine(1);
            else
                Console.WriteLine(1);
        }
        public static void If20(float a, float b, float c)
        {
            float AB = Math.Abs(b - a);
            float AC = Math.Abs(c - a);
            if (AB > AC)
                Console.WriteLine(b + " " + AB);
            else
                Console.WriteLine(c + " " + AC);
        }
        public static void If22(int x, int y)
        {
            if (x > 0 && y > 0)
                Console.WriteLine(1);
            if (x > 0 && y < 0)
                Console.WriteLine(4);
            if (x < 0 && y > 0)
                Console.WriteLine(2);                       
            else 
                Console.WriteLine(3);
        }
        public static void If24(float x)
        {
            float y;
            if (x > 0)
                y = 2 * (float)Math.Sin(x);
            else
                y = 6 - x;
        }
        public static void If26(float x)
        {
            float y;
            if (x <= 0)
                y = -x;
            if (x > 0 && x < 2)
                y = x * x;
            else 
                y = 4;
        }
        public static void If27(float x)
        {
            float y;
            if (x < 0)
                y = 0;
            if (x % 2 == 0)
                y = 1;
            else 
                y = -1;
            Console.WriteLine(y);
        }
        public static void If28(int year)
        {
            if ((year % 4 == 0 || year % 100 == 0) && year % 400 != 0)
                Console.WriteLine(366);
            else
                Console.WriteLine(365);
        }
        public static void If30(int x)
        {
            string numberDescription = "";
            if (x % 2 == 0)
                numberDescription += "чётное ";
            else
                numberDescription += "нечётное ";

            if(x/100>0)
                numberDescription += "трехзначное ";
            else if(x/10<10)
                numberDescription += "двухзначное ";
            else
                numberDescription += "однозначное ";
            Console.WriteLine(numberDescription); ;
        }
        #endregion
        #region Cases
        public static void Case2(int k)
        {
            switch (k)
            {
                case 1:
                    Console.WriteLine("1-плохо");
                    break;
                case 2:
                    Console.WriteLine("2-неудовлетворительно");
                    break;
                case 3:
                    Console.WriteLine("3-удовлетворительно");
                    break;
                case 4:
                    Console.WriteLine("4-хорошо");
                    break;
                case 5:
                    Console.WriteLine("5-отлично");
                    break;
                default:
                    Console.WriteLine("ошибка");
                    break;
            }
        }
        public static void Case4(int k)
        {
            switch (k)
            {
                case 1:
                case 3:
                case 5:
                case 7:
                case 8:
                case 10:
                case 12:
                    Console.WriteLine("31 день");
                    break;

                case 4:
                case 6:
                case 9:
                case 11:
                    Console.WriteLine("30 день");
                    break;

                case 2:
                    Console.WriteLine("28 дней");
                    break;
                default:
                    Console.WriteLine("ошибка");
                    break;
            }
        }
        public static void Case6(int k, int lenght)
        {
            int convertedLenght = 0;
            switch (k)
            {
                case 1:
                    convertedLenght = lenght / 10;
                    break;
                case 2:
                    convertedLenght = lenght * 1000;
                    break;
                case 3:
                    convertedLenght = lenght;
                    break;
                case 4:
                    convertedLenght = lenght / 1000;
                    break;
                case 5:
                    convertedLenght = lenght / 100;
                    break;
                default:
                    Console.WriteLine("ошибка");
                    break;                  
            }
            Console.WriteLine(convertedLenght + " метров");
        }
        public static void Case8(int d, int m)
        {
            int dayBefore = 0, mounth = 0;
            if (d == 0 || m == 1)
            {
                switch (m)
                {
                    case 1:
                        dayBefore = 31;
                        mounth = 12;
                        break;
                    case 3:
                    case 5:
                    case 7:
                    case 8:
                    case 10:
                    case 12:
                        dayBefore = 31;
                        break;
                     
                    case 4:
                    case 6:
                    case 9:
                    case 11:
                        dayBefore = 30;
                        break;

                    case 2:
                        dayBefore = 28;
                        break;
                    default:
                        Console.WriteLine("ошибка");
                        break;
                }
            }
            else
            {
                dayBefore = d - 1;
                mounth = m - 1;
            }
            Console.WriteLine(dayBefore +" "+ mounth);          
        }
        public static void Case10(char c, int n)
        {
            string destination = "";
            string command = "";
            switch (char.ToLower(c))
            {
                case 'с':
                    destination += "север";
                    break;
                case 'з':
                    destination += "запад";
                    break;
                case 'ю':
                    destination += "юг";
                    break;
                case 'в':
                    destination += "восток";
                    break;
                default:
                    Console.WriteLine("ошибка");
                    break;
            }
            switch (n)
            {
                case 1:
                    command += "продолжить движение";
                    break;
                case 2:
                    command += "поворот налево";
                    break;
                case 3:
                    command += "поворот направо";
                    break;
                default:
                    Console.WriteLine("ошибка");
                    break;
            }
            Console.WriteLine(command + " на " + destination);
        }
        public static void Case12(int typeOfElement, int value)
        {
            double radius = 0, diametr = 0, lenght = 0, square = 0;
            switch (typeOfElement)
            {
                case 1:
                    radius = value;
                    diametr = findDiametr(radius);
                    lenght = findLenght(radius);
                    square = findSquare(radius);
                    break;
                case 2:
                    diametr = value;
                    radius = diametr / 2;
                    lenght = findLenght(radius);
                    square = findSquare(radius);
                    break;
                case 3:
                    lenght = value;
                    radius = lenght / (2 * 3.14);
                    diametr = findDiametr(radius);
                    square = findSquare(radius);
                    break;
                case 4:
                    square = value;
                    radius = Math.Sqrt(square / 3.14);
                    break;

                default:
                    Console.WriteLine("ошибка");
                    break;
            }
            Console.WriteLine( radius +" "+diametr +" "+lenght+" "+square);

             static double findDiametr(double radius)
            {
                return radius * 2;
            }
             static double findLenght(double radius)
            {
                return 2 * radius * 3.14;
            }
             static double findSquare(double radius)
            {
                return radius * radius * 3.14;
            }
        }

       
        public static void Case14(int typeOfElement, int value)
        {
            double side = 0, inscribedRadius = 0, describedRadius = 0, square = 0;
            switch (typeOfElement)
            {
                case 1:
                    side = value;
                    inscribedRadius = findInscribedRadius(side);
                    describedRadius = findDescribedRadius(inscribedRadius);
                    square = findSquare(side);
                    break;
                case 2:
                    inscribedRadius = value;
                    side = 6 * inscribedRadius / Math.Sqrt(3);
                    describedRadius = findDescribedRadius(inscribedRadius);
                    square = findSquare(side);
                    break;
                case 3:
                    describedRadius = value;
                    inscribedRadius = describedRadius / 2;
                    side = 6 * inscribedRadius / Math.Sqrt(3);
                    square = findSquare(side);
                    break;
                case 4:
                    square = value;
                    side = Math.Sqrt(4*square / Math.Sqrt(3));
                    inscribedRadius = findInscribedRadius(side);
                    describedRadius = findDescribedRadius(inscribedRadius);
                    break;

                default:
                    Console.WriteLine("ошибка");
                    break;
            }
            Console.WriteLine(side + " " + inscribedRadius + " " + describedRadius + " " + square);

            static double findInscribedRadius(double side)
            {
                return side * Math.Sqrt(3) / 6;
            }
            static double findDescribedRadius(double inscribedRadius)
            {
                return 2 * inscribedRadius;
            }
            static double findSquare(double side)
            {
                return side * side * Math.Sqrt(3) / 4;
            }
        }
        public static void Case16(int age)
        {
            string tens = "";
            string ones = "";
            string years = "";
            switch (age % 10)
            {
                case 1:
                    years += "год";
                    break;
                case 2:
                case 3:
                case 4:
                    years += "года";
                    break;
                case 5:
                case 6:
                case 7:
                case 8:
                case 9:
                case 0:
                    years += "лет";
                    break;
            }
            switch (age % 10)
            {
                case 1:
                    ones += "один";
                    break;
                case 2:
                    ones += "два";
                    break;
                case 3:
                    ones += "три";
                    break;
                case 4:
                    ones += "четыре";
                    break;
                case 5:
                    ones += "пять";
                    break;
                case 6:
                    ones += "шесть";
                    break;
                case 7:
                    ones += "семь";
                    break;
                case 8:
                    ones += "восемь";
                    break;
                case 9:
                    ones += "девять";
                    break;
                default:
                    ones += "";
                    break;
            }
            switch (age / 10)
            {
                case 2:
                    tens += "двадцать";
                    break;
                case 3:
                    tens += "тридцать";
                    break;
                case 4:
                    tens += "сорок";
                    break;
                case 5:
                    tens += "пятьдесят";
                    break;
                case 6:
                    tens += "шестьдесят";
                    break;
 
                default:
                    Console.WriteLine("Число меньше 20 или больше 70");
                    break;
            }
            Console.WriteLine(tens + " " + ones+ " "+years);
        }
        public static void Case18(int number)
        {
            string hundrets = "";
            string tens = "";
            string ones = "";
            switch (number / 100)
            {
                case 1:
                    hundrets += "сто";
                    break;
                case 2:
                    hundrets += "двести";
                    break;
                case 3:
                    hundrets += "триста";
                    break;
                case 4:
                    hundrets += "четыреста";
                    break;
                case 5:
                    hundrets += "пятсот";
                    break;
                case 6:
                    hundrets += "шестсот";
                    break;
                case 7:
                    hundrets += "семьсот";
                    break;
                case 8:
                    hundrets += "восемьсот";
                    break;
                case 9:
                    hundrets += "девятьсот";
                    break;

                default:
                    Console.WriteLine("Число меньше 100 или больше 999");
                    break;
            }
           
            if(number % 100 < 20 && number % 100 >10)
            {
                switch (number % 100)
                {
                    case 11:
                        tens += "одинадцать";
                        break;
                    case 12:
                        tens += "двенадцать";
                        break;
                    case 13:
                        tens += "тринадцать";
                        break;
                    case 14:
                        tens += "четырнадцать";
                        break;
                    case 15:
                        tens += "пятнадцать";
                        break;
                    case 16:
                        tens += "шестнадцать";
                        break;
                    case 17:
                        tens += "семьнадцать";
                        break;
                    case 18:
                        tens += "восемьнадцать";
                        break;
                    case 19:
                        tens += "девятнадцать";
                        break;
                }
            }
            else
            {
                switch (number / 10 % 10)
                {
                    case 1:
                        tens += "десять";
                        break;
                    case 2:
                        tens += "двадцать";
                        break;
                    case 3:
                        tens += "тридцать";
                        break;
                    case 4:
                        tens += "сорок";
                        break;
                    case 5:
                        tens += "пятьдесят";
                        break;
                    case 6:
                        tens += "шестьдесят";
                        break;
                    case 7:
                        tens += "семьдесят";
                        break;
                    case 8:
                        tens += "восемьдесят";
                        break;
                    case 9:
                        tens += "девяносто";
                        break;
                    default:
                        tens += "";
                        break;
                }
                switch (number % 10)
                {
                    case 1:
                        ones += "один";
                        break;
                    case 2:
                        ones += "два";
                        break;
                    case 3:
                        ones += "три";
                        break;
                    case 4:
                        ones += "четыре";
                        break;
                    case 5:
                        ones += "пять";
                        break;
                    case 6:
                        ones += "шесть";
                        break;
                    case 7:
                        ones += "семь";
                        break;
                    case 8:
                        ones += "восемь";
                        break;
                    case 9:
                        ones += "девять";
                        break;
                    default:
                        ones += "";
                        break;
                }
            }                         
            Console.WriteLine(hundrets + " " + tens + " " + ones);
        }
        public static void Case20(int d, int m)
        {
            string zodiacSign = "";
            switch (m)
            {
                case 1:
                    if (d > 19)
                        zodiacSign += "Водолей";
                    else
                        zodiacSign += "Козерог";
                    break;
                case 2:
                    if (d > 18)
                        zodiacSign += "Рыбы";
                    else
                        zodiacSign += "Водолей";
                    break;
                case 3:
                    if (d > 20)
                        zodiacSign += "Овен";
                    else
                        zodiacSign += "Рыбы";
                    break;
                case 4:
                    if (d > 19)
                        zodiacSign += "Телец";
                    else
                        zodiacSign += "Овен";
                    break;
                case 5:
                    if (d > 20)
                        zodiacSign += "Близнецы";
                    else
                        zodiacSign += "Телец";
                    break;
                case 6:
                    if (d > 21)
                        zodiacSign += "Рак";
                    else
                        zodiacSign += "Близнецы";
                    break;
                case 7:
                    if (d > 22)
                        zodiacSign += "Лев";
                    else
                        zodiacSign += "Рак";
                    break;
                case 8:
                    if (d > 22)
                        zodiacSign += "Дева";
                    else
                        zodiacSign += "Лев";
                    break;
                case 9:
                    if (d > 22)
                        zodiacSign += "Весы";
                    else
                        zodiacSign += "Дева";
                    break;
                case 10:
                    if (d > 22)
                        zodiacSign += "Скорпион";
                    else
                        zodiacSign += "Весы";
                    break;
                case 11:
                    if (d > 22)
                        zodiacSign += "Стрелец";
                    else
                        zodiacSign += "Скорпион";
                    break;
                case 12:
                    if (d > 21)
                        zodiacSign += "Козерог";
                    else
                        zodiacSign += "Стрелец";
                    break;
            }            
        }
        #endregion
    }
}
