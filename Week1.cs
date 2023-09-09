using System;

namespace Workspace
{
    class Week1
    {
        public static void menu()
        {
            Console.WriteLine("---");
            while (true)
            {
                switch (Project.option(0, 13))
                {
                    case 1:
                        task1();
                        break;
                    case 2:
                        task2();
                        break;
                    case 3:
                        task3();
                        break;
                    case 4:
                        task4();
                        break;
                    case 5:
                        task5();
                        break;
                    case 6:
                        task6();
                        break;
                    case 7:
                        task7();
                        break;
                    case 8:
                        task8();
                        break;
                    case 9:
                        task9();
                        break;
                    case 10:
                        task10();
                        break;
                    case 11:
                        task11();
                        break;
                    case 12:
                        task12();
                        break;
                    case 13:
                        task13();
                        break;
                    default:
                        Console.WriteLine("\n- EXIT -");
                        return;
                }
                Console.WriteLine("\nPress 0 to exit!\n---");
            }
        }


        //Task 1
        static void task1()
        {
            Console.Write("Enter a date dd/MM/yyyy: ");
            string date = Console.ReadLine();
            while (!dateCheck(date))
            {
                Console.Write(">> Wrong format!\nEnter a date dd/MM/yyyy: ");
                date = Console.ReadLine();
            }

            string[] arr = date.Split('/');
            int d = int.Parse(arr[0]);
            int M = int.Parse(arr[1]);
            int y = int.Parse(arr[2]);

            if (M < 3)
            {
                M += 12;
                y--;
            }

            int n = (d + 2 * M + 3 * (M + 1) / 5 + y + y / 4) % 7;
            string[] result = { "Sunday", "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday" };

            Console.WriteLine(">> That is " + result[n] + ".");
        }
        static bool dateCheck(string text)
        {
            try
            {
                DateTime date = DateTime.ParseExact(text, "d/M/yyyy", null);
            }
            catch (System.Exception)
            {
                return false;
            }
            return true;
        }

        //Task 2
        static void task2()
        {
            Console.Write("Enter a date dd/MM/yyyy: ");
            string datestr = Console.ReadLine();
            while (!dateCheck(datestr))
            {
                Console.Write(">> Wrong format!\nEnter a date dd/MM/yyyy: ");
                datestr = Console.ReadLine();
            }

            DateTime date = DateTime.ParseExact(datestr, "d/M/yyyy", null);
            Console.WriteLine("The previous day is: " + date.AddDays(-1).ToString("dd/MM/yyyy") + "");
            Console.WriteLine("The next day is: " + date.AddDays(1).ToString("dd/MM/yyyy"));
        }

        //Task 3: ax + b = 0
        static void task3()
        {
            Console.WriteLine("Here is the program to solve the linear equation ax + b = 0.");

            Console.Write("Enter a number of a: ");
            double a = -1;
            bool flag = false;
            while (!flag)
                try
                {
                    a = double.Parse(Console.ReadLine());
                    flag = true;
                }
                catch (System.Exception)
                {
                    Console.Write("Error. Try again!\nEnter a number of a: ");
                    flag = false;
                }

            Console.Write("Enter a number of b: ");
            double b = -1;
            flag = false;
            while (!flag)
                try
                {
                    b = double.Parse(Console.ReadLine());
                    flag = true;
                }
                catch (System.Exception)
                {
                    Console.Write("Error. Try again!\nEnter a number of b: ");
                    flag = false;
                }

            if (a != 0)
                Console.WriteLine("x = " + -b / a);
            else if (b != 0)
                Console.WriteLine("The equation has no solution!");
            else
                Console.WriteLine("The equation has infinite solutions!");
        }

        //Task 4: ax^2 + bx + c = 0
        static void task4()
        {
            Console.WriteLine("Here is the program to solve the degree equation ax^2 + bx + c = 0.");

            Console.Write("Enter a number of a: ");
            double a = -1;
            bool flag = false;
            while (!flag)
                try
                {
                    a = double.Parse(Console.ReadLine());
                    flag = true;
                }
                catch (System.Exception)
                {
                    Console.Write("Error. Try again!\nEnter a number of a: ");
                    flag = false;
                }

            Console.Write("Enter a number of b: ");
            double b = -1;
            flag = false;
            while (!flag)
                try
                {
                    b = double.Parse(Console.ReadLine());
                    flag = true;
                }
                catch (System.Exception)
                {
                    Console.Write("Error. Try again!\nEnter a number of b: ");
                    flag = false;
                }

            Console.Write("Enter a number of c: ");
            double c = -1;
            flag = false;
            while (!flag)
                try
                {
                    c = double.Parse(Console.ReadLine());
                    flag = true;
                }
                catch (System.Exception)
                {
                    Console.Write("Error. Try again!\nEnter a number of c: ");
                    flag = false;
                }

            double delta = b * b - 4 * a * c;
            if (delta < 0)
                Console.WriteLine("x1 = (" + -b + "+" + Math.Sqrt(delta) + "i)/" + (2 * a) + "\nx2 = (" + -b + "-" + Math.Sqrt(delta) + "i)/" + (2 * a));
            else if (delta == 0)
                Console.WriteLine("x1 = x2 = " + -b / (2 * a));
            else
                Console.WriteLine("x1 = " + (-b + Math.Sqrt(delta)) / (2 * a) + "\nx2 = " + (-b - Math.Sqrt(delta)) / (2 * a));

        }

        //Task 5: Arrays int numbers
        static void task5()
        {
            Console.Write("Enter a number of N: ");
            int N = 0;
            bool flag = false;
            while (!flag)
                try
                {
                    N = int.Parse(Console.ReadLine());
                    flag = true;
                }
                catch (System.Exception)
                {
                    Console.Write("Error. Try again!\nEnter a number of N: ");
                    flag = false;
                }


            //Number a:
            Console.WriteLine("a. Sum of numbers <= N");
            long sa = 0;
            for (int i = 0; i < N + 1; i++)
            {
                Console.Write(i + "\t");
                sa += i;
            }
            Console.WriteLine("\n>> S(N) = " + sa);

            //Number b: 
            Console.WriteLine("b. Sum of even numbers <= N");
            long sb = 0;
            for (int i = 2; i < N + 1; i += 2)
            {
                Console.Write(i + "\t");
                sb += i;
            }
            Console.WriteLine("\n>> S(N) = " + sb);

            //Number c: 
            Console.WriteLine("c. Sum of odd numbers <= N");
            long sc = 0;
            for (int i = 1; i < N + 1; i += 2)
            {
                Console.Write(i + "\t");
                sc += i;
            }
            Console.WriteLine("\n>> S(N) = " + sc);

            //Number d: Prime
            Console.WriteLine("d. Sum of prime numbers <= N");
            long sd = 0;
            for (int i = 2; i < N + 1; i++)
                if (isPrime(i))
                {
                    Console.Write(i + "\t");
                    sd += i;
                }
            Console.WriteLine("\n>> S(N) = " + sd);

            //Number e: N prime numbers
            Console.WriteLine("e. Array of N prime numbers");
            int s = 2;
            for (int count = 0; count < N; count++)
            {
                while (!isPrime(s))
                    s++;
                Console.Write(s + "\t");
                s++;
            }
        }

        static bool isPrime(int n)
        {
            if (n == 2) return true;
            if (n < 2 || n % 2 == 0) return false;
            for (int i = 3; i <= Math.Sqrt(n); i += 2)
                if (n % i == 0)
                    return false;
            return true;
        }

        //Task 6:
        static void task6()
        {
            //Number a:
            Console.WriteLine("a. S(n) = 2021 + 1/2! - 1/3! + ... + (-1)^n/n!");
            Console.Write("Enter a number of n: ");
            double n = 0;
            bool flag = false;
            while (!flag)
                try
                {
                    n = double.Parse(Console.ReadLine());
                    flag = true;
                }
                catch (System.Exception)
                {
                    Console.Write("Error. Try again!\nEnter a number of n: ");
                    flag = false;
                }
            double s = 2021;
            double e = -1;
            for (int i = 2; i < n + 1; i++)
            {
                e *= -1.0 / i;
                s += e;
            }
            Console.WriteLine(">> S(n) = " + s);

            //Number b:
            Console.WriteLine("b. S(n) = x/(x+1)! + x^2/(x+2)! + ... + x^n/(x+n)!");
            Console.Write("Enter a number of x: ");
            double x = 0;
            flag = false;
            while (!flag)
                try
                {
                    x = double.Parse(Console.ReadLine());
                    if (x < 1 || 50 < x)
                    {
                        Console.Write("Out of range! Try again!\nEnter a number in range[1,50]: ");
                        continue;
                    }
                    flag = true;

                }
                catch (System.Exception)
                {
                    Console.Write("Error. Try again!\nEnter a number of x: ");
                    flag = false;
                }
            Console.Write("Enter a number of n: ");
            flag = false;
            while (!flag)
                try
                {
                    n = double.Parse(Console.ReadLine());
                    flag = true;
                }
                catch (System.Exception)
                {
                    Console.Write("Error. Try again!\nEnter a number of n: ");
                    flag = false;
                }

            e = x;
            for (int i = 2; i < x + 2; i++)
                e /= i;
            s = e;
            for (int i = 2; i < n + 1; i++)
            {
                e *= x / (x + i);
                s += e;
            }
            Console.WriteLine(">> S(n) = " + s);
        }

        //Task 7:
        static void task7()
        {
            Console.Write("Enter a number of n: ");
            int n = 0;
            bool flag = false;
            while (!flag)
                try
                {
                    n = int.Parse(Console.ReadLine());
                    flag = true;
                }
                catch (System.Exception)
                {
                    Console.Write("Error. Try again!\nEnter a number of n: ");
                    flag = false;
                }

            Console.Write(">> S(N) = ");
            long s = n;
            for (int i = (n % 2 == 0) ? 0 : 1; i < n; i += 2)
            {
                Console.Write(i + " + ");
                s += i;
            }
            Console.WriteLine(n + " = " + s);
        }

        //Task 8: Max and min numbers of array
        static void task8()
        {
            Console.WriteLine("Enter numbers on 1 line, separated by 'Space'. Press 'Enter' when you finish.");
            string inp = Console.ReadLine();
            string[] arr = inp.Split(' ');
            int max = int.MinValue;
            int min = int.MaxValue;

            for (int i = 0; i < arr.Length; i++)
            {
                try
                {
                    int value = int.Parse(arr[i]);
                    max = value > max ? value : max;
                    min = value < min ? value : min;
                }
                catch (System.Exception) { }
            }

            Console.WriteLine(">> Max value: " + (max == int.MinValue ? "Not Exist" : max));
            Console.WriteLine(">> Min value: " + (min == int.MaxValue ? "Not Exist" : min));
        }

        //Task 9: Multiple of 3 range from 300 to 3
        static void task9()
        {
            Console.Write(">> Multiple of 3:\t");
            for (int n = 300; n >= 3; n -= 3)
                Console.Write(n + "\t");
            Console.WriteLine("");
        }

        //Task 10: GCD and LCM of 2 numbers
        static void task10()
        {
            Console.Write("Enter a number of a: ");
            int a = -1;
            bool flag = false;
            while (!flag)
                try
                {
                    a = int.Parse(Console.ReadLine());
                    flag = true;
                }
                catch (System.Exception)
                {
                    Console.Write("Error. Try again!\nEnter a number of a: ");
                    flag = false;
                }

            Console.Write("Enter a number of b: ");
            int b = -1;
            flag = false;
            while (!flag)
                try
                {
                    b = int.Parse(Console.ReadLine());
                    flag = true;
                }
                catch (System.Exception)
                {
                    Console.Write("Error. Try again!\nEnter a number of b: ");
                    flag = false;
                }

            Console.WriteLine(">> GCD(" + a + ", " + b + ") = " + GCD(a, b));
            Console.WriteLine(">> LCM(" + a + ", " + b + ") = " + LCM(a, b));
        }

        static int GCD(int a, int b)
        {
            while (b != 0)
            {
                int t = b;
                b = a % b;
                a = t;
            }
            return a;
        }

        static int LCM(int a, int b)
        {
            return (a * b) / GCD(a, b);
        }

        //Task 11: Fibonacci
        static void task11()
        {
            //Number 1:
            Console.Write("a. Enter a number of n: ");
            int n = int.MaxValue;
            while (!int.TryParse(Console.ReadLine(), out n))
            {
                Console.Write("Error. Try again!\nEnter a number of n: ");
            }
            Console.WriteLine(">> Fibo(n) = " + (int)(1 / Math.Sqrt(5) * (Math.Pow((1 + Math.Sqrt(5)) / 2, n) - Math.Pow((1 - Math.Sqrt(5)) / 2, n))));
            //Number 3:
            Console.Write(">>\t");
            for (int i = 1; i <= n; i++)
                Console.Write((int)(1 / Math.Sqrt(5) * (Math.Pow((1 + Math.Sqrt(5)) / 2, i) - Math.Pow((1 - Math.Sqrt(5)) / 2, i))) + "\t");
            Console.WriteLine("");

            //Number 2:
            Console.Write("b. Enter a number of x: ");
            int x = int.MaxValue;
            while (!int.TryParse(Console.ReadLine(), out x))
            {
                Console.Write("Error. Try again!\nEnter a number of x: ");
            }
            int t = 1;
            for (int i = 1; t < x; i++)
                t = (int)(1 / Math.Sqrt(5) * (Math.Pow((1 + Math.Sqrt(5)) / 2, i) - Math.Pow((1 - Math.Sqrt(5)) / 2, i)));
            Console.WriteLine(">> " + x + (t == x ? " is a fibonacci number" : " is not a fibonacci number"));

            //Number 4:
            Console.Write("d. Enter a number of m: ");
            int m = int.MaxValue;
            while (!int.TryParse(Console.ReadLine(), out m))
            {
                Console.Write("Error. Try again!\nEnter a number of m: ");
            }
            if (m < 1) 
            {
                Console.WriteLine(">> Sum(Fibo(i)) [Fibo(i) < " + m + "] = 0");
                return;
            }
            Console.Write(">> Sum(Fibo(i)) [Fibo(i) < " + m + "] = 1");
            long s = 1;
            t = 1;
            for (int i = 2; t < m; i++)
            {
                t = (int)(1 / Math.Sqrt(5) * (Math.Pow((1 + Math.Sqrt(5)) / 2, i) - Math.Pow((1 - Math.Sqrt(5)) / 2, i)));
                s += t;
                Console.Write(" + " + t);
            }
            Console.WriteLine(" = " + s);
        }

        //Task 12: Square number
        static void task12()
        {
            while (true)
                try
                {
                    Console.Write("Enter a square number: ");
                    int n = int.Parse(Console.ReadLine());
                    if (isSquare(n))
                    {
                        Console.WriteLine(">> " + n + " is square number.");
                        return;
                    }
                    Console.WriteLine("Wrong! Try again!");
                }
                catch (System.Exception) { }
        }

        static bool isSquare(int n)
        {
            if (n < 0)
                return false;
            if (Math.Pow((int)Math.Sqrt(n), 2) != n)
                return false;
            return true;
        }

        //Task 13: Primary factor
        static void task13()
        {
            Console.Write("Enter a number of n: ");
            long n = long.MaxValue;
            while (!long.TryParse(Console.ReadLine(), out n))
            {
                Console.Write("Error. Try again!\nEnter a number of n: ");
            }

            Console.Write(">> " + n + " = ");
            long t = n;
            int pf = 2; //primary factor
            while (t > 1)
            {
                if (t % pf == 0)
                {
                    Console.Write(pf);
                    t /= pf;
                    int e = 1;  //exponent
                    while (t % pf == 0)
                    {
                        e++;
                        t /= pf;
                    }
                    Console.Write(e != 1 ? ("^" + e) : "");
                    Console.Write(t > 1 ? "*" : "\n");
                }
                else
                    pf++;
            }
            Console.WriteLine(">> " + n + " has " + n.ToString().Length + " digits.");
        }
    }
}