using System.Linq.Expressions;

namespace IterationStatements
{
    public class Program
    {
        static void Main(string[] args)
        {
            //Counts all numbers from -1000 to 1000.

            void ThousandNumbers()
            {
                for (int i = -1000; i <= 1000; i++)
                {
                    Console.WriteLine(i);
                }
            }
            ThousandNumbers();

            //Method that adds numbers by 3.

            void NumbersOfThree()
            {
                for (int i = 3; i <= 999; i += 3)
                {
                    Console.WriteLine(i);
                }
            }
            NumbersOfThree();

            //Asking if two numbers are equal for new method.

            int EqualNumbers(int a, int b)
            {
                Console.WriteLine("Type two whole numbers to see if they are equal.");
                a = int.Parse(Console.ReadLine());
                b = int.Parse(Console.ReadLine());

                if (a == b)
                {
                    Console.WriteLine($"{a} and {b} are equal numbers!");
                }
                else
                {
                    Console.WriteLine($"{a} and {b} are NOT equal numbers!");
                }
                return a;
            }
            EqualNumbers(1, 2);

            //Method that checks if a number are even or odd.

            int EvenOrODD(int c)
            {
                Console.WriteLine("Type a number to see if it is even or odd.");
                c = int.Parse(Console.ReadLine());

                if (c % 2 == 0)
                {
                    Console.WriteLine($"{c} is a even number!");
                }
                else
                {
                    Console.WriteLine($"{c} is a odd number!");
                }
                return c;
            }
            EvenOrODD(1);

            //Method that checks if the number is positive or negative.

            int PosOrNeg(int d)
            {
                Console.WriteLine("Type a number to see if it is positive or negative.");
                d = int.Parse(Console.ReadLine());

                if (d > 0)
                {
                    Console.WriteLine($"{d} is a positive number!");
                }
                else
                {
                    Console.WriteLine($"{d} is a negative number!");
                }
                return d;
            }
            PosOrNeg(1);

            //Method that checks if the person is of age to vote.

            Console.WriteLine("Type in your age.");
            var n = Console.ReadLine();

            string VotingAge(string n)
            {
                int number;
                bool m = int.TryParse(n, out number);

                string age;

                if (m)
                {
                    if (number >= 18)
                    {
                        age = "Is of voting age.";
                    }
                    else
                    {
                        age = "Is NOT of voting age.";
                    }
                }
                else
                {
                    age = "try again";
                }
                return age;
            }
            Console.WriteLine(VotingAge(n));

            //Heating up section.

            int NegTenToTen(int f)
            {
                Console.WriteLine("Type a number to see if it's between negative ten and positive ten.");
                f = int.Parse(Console.ReadLine());

                if (f >= -10 && f <= 10)
                {
                    Console.WriteLine($"{f} is between -10 and 10!");
                }
                else
                {
                    Console.WriteLine($"{f} if NOT between -10 and 10!");
                }
                return f;
            }
            NegTenToTen(1);

            //number multiple of 1 - 12.

            int MathTable(int g)
            {
                Console.WriteLine("Type a number to see the math table of 1 - 12 with.");
                g = int.Parse(Console.ReadLine());
                int h = g;
                int j = 0;

                for (int i = 1; i <= 12; i++)
                {
                    switch (i)
                    {
                        case 1:
                            j = 1 * g;
                            Console.WriteLine($"{h} * {i} = {j}");
                            break;
                        case 2:
                            j = 2 * g;
                            Console.WriteLine($"{h} * {i} = {j}");
                            break;
                        case 3:
                            j = 3 * g;
                            Console.WriteLine($"{h} * {i} = {j}");
                            break;
                        case 4:
                            j = 4 * g;
                            Console.WriteLine($"{h} * {i} = {j}");
                            break;
                        case 5:
                            j = 5 * g;
                            Console.WriteLine($"{h} * {i} = {j}");
                            break;
                        case 6:
                            j = 6 * g;
                            Console.WriteLine($"{h} * {i} = {j}");
                            break;
                        case 7:
                            j = 7 * g;
                            Console.WriteLine($"{h} * {i} = {j}");
                            break;
                        case 8:
                            j = 8 * g;
                            Console.WriteLine($"{h} * {i} = {j}");
                            break;
                        case 9:
                            j = 9 * g;
                            Console.WriteLine($"{h} * {i} = {j}");
                            break;
                        case 10:
                            j = 10 * g;
                            Console.WriteLine($"{h} * {i} = {j}");
                            break;
                        case 11:
                            j = 11 * g;
                            Console.WriteLine($"{h} * {i} = {j}");
                            break;
                        case 12:
                            j = 12 * g;
                            Console.WriteLine($"{h} * {i} = {j}");
                            break;
                        default:
                            Console.WriteLine("Try again");
                            break;
                    }
                }
                return g;
            }
            MathTable(1);
        }
    }
}
