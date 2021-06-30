using System;

namespace Leap_Year
{
    public class LeapYear
    {

        public static void ReadInput()
        {

            //local variable
            int temp = 0;
            int year = 0;
            while (temp == 0)
            {
                //Getting 4-digit input from user
                Console.WriteLine("Enter a four digit number\n");
                year = Convert.ToInt32(Console.ReadLine());

                //Condition to check if its 4-digit
                if ((int)Math.Log10(year) == 3)
                {
                    temp = 1;
                }
                else
                {
                    Console.WriteLine("Entered number is not 4-digit.Try Again\n");
                }
            }
            LeapYearInput(year);
        }
        private static void LeapYearInput(int year)
        {
            //Condition to check if its Leap Year
            if (((year % 4 == 0) && (year % 100 != 0)) || (year % 400 == 0))
            {
                Console.WriteLine("Year " + year + " is a Leap Year! \n");

            }
            else
            {
                Console.WriteLine("Year " + year + " is not Leap Year! \n");

            }
        }

    }
 }
