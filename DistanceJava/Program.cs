using System;

namespace LineComparison
{
    class Program
    {
        public static void Main(string[] args)
        {
            

            //bool loopContinue = true;
            //while (loopContinue)
            {
                double valueOne = LineOne();
                double valueTwo = LineTwo();

                bool loopContinue = true;
                while (loopContinue)
                {


                    Console.WriteLine("1.Check if equal or not ");
                    Console.WriteLine("2.Check if greater");
                    Console.WriteLine("3.Exit");


                    Console.WriteLine("");

                    int input = Convert.ToInt32(Console.ReadLine());

                    {

                        switch (input)
                        {
                            case 1:
                                if (valueOne == valueTwo)
                                    Console.WriteLine("This lines are equal");
                                else
                                    Console.WriteLine("They are not euqal");
                                break;

                            case 2:
                                if (valueOne > valueTwo)
                                    Console.WriteLine("Line 1 is greater");
                                else
                                    Console.WriteLine("Line 2 is greater");
                                break;


                        }
                    }
                    if (loopContinue)
                        Console.WriteLine("Please enter a valid choice.");
                }
            }
        }

        public static double LineOne()
        {
            int x1, y1;

            Console.WriteLine("Enter x and y coordinates");
            x1 = Convert.ToInt32(Console.ReadLine());
            y1 = Convert.ToInt32(Console.ReadLine());

            double distance1 = Math.Sqrt(Math.Pow(x1, 2) + Math.Pow(y1, 2));
            Console.WriteLine("Distance from (0, 0) to (" + x1 + ", " + y1 + ") is " + distance1);
            return distance1;

        }

        public static double LineTwo()
        {
            int x2, y2;

            Console.WriteLine("Enter x and y coordinates");
            x2 = Convert.ToInt32(Console.ReadLine());
            y2 = Convert.ToInt32(Console.ReadLine());

            double distance2 = Math.Sqrt(Math.Pow(x2, 2) + Math.Pow(y2, 2));
            Console.WriteLine("Distance from (0, 0) to (" + x2 + ", " + y2 + ") is " + distance2);
            return distance2;

        }










    }
}