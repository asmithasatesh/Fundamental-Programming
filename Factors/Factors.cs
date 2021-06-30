using System;

namespace Factors
{
    public class Factors
    {
            public static void ReadInput()
            {
                //Local Variables
                int number;
                //Get input from user
                Console.WriteLine("Enter a four digit number\n");
                number = Convert.ToInt32(Console.ReadLine());
                FactorsCalculate(number);

            }

            private static void FactorsCalculate(int number)
            {
            Console.WriteLine("Prime Factors of "+number+" is\n");

            // Using Sqrt instead of i*i
            for (int i = 3; Math.Sqrt(i) <= number; i++)
                {
                //To check if there are prime factors of 2
                while (number % 2 == 0)
                {
                    number /= 2;
                    Console.WriteLine(2);
                }

                    //Check whether number is not divisible by 2
                    while (i % 2 != 0 && number % i == 0)
                    {
                        //If i is divisible by number , then we print value of i and then divide number by it
                        number /= i;
                        Console.WriteLine(i);
                    }
                }
            }
        
    }
}
