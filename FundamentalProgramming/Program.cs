using System;


namespace CheckuserOption
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the which program to execute");
            Console.WriteLine("1.Leap Year \n2. Factors  \n3.Largest of three number \n4.Vowels or Consonant");
            int ch = Convert.ToInt32(Console.ReadLine());
            switch (ch)
            {
                case 1:
                    Leap_Year.LeapYear.ReadInput();
                    break;

                case 2:
                    Factors.Factors.ReadInput();
                    break;
                case 3:
                    LargestNumber.LargestofThree.ReadInput();
                    break;
                case 4:
                    VowelsorConstant.VowelsorConstant. ReadInput();
                    break;

            }
        }
    }
}

