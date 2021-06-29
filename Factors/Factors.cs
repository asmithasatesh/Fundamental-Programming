using System;

namespace Factors
{
    class Factors
    {
        static void Main(string[] args)
        {
            //Local Variables
            int number = 0;
            //Get input from user
            Console.WriteLine("Enter a four digit number\n");
            number = Convert.ToInt32(Console.ReadLine());
            // Using Sqrt instead of i*i
            for(int i=3;Math.Sqrt(i) <=number;i++)
            {
                //Check whether number is not divisible by 2
                while(i%2!=0 && number % i == 0)
                {
                 //If i is divisible by number , then we print value of i and then divide number by it
                 number = number/ i;
                 Console.WriteLine(i);
                }
            }
        }
    }
}
