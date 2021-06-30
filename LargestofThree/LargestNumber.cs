using System;



namespace LargestNumber
{
    public static class LargestofThree
    {
        public static void ReadInput()
        {
            //local Variables
            int num1, num2, num3;

            // get input from user
            Console.Write("Enter number 1\n");
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter number 2\n");
            num2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter number 3\n");
            num3 = Convert.ToInt32(Console.ReadLine());
            CompareThree(num1, num2, num3);
        }

        private static void CompareThree(int num1,int num2,int num3)
        {
            //Compare 1 and 2
            if (num1 > num2)
            {
                //Compare 1 and 3
                if (num1 > num3)
                {
                    Console.Write("Number" + num1 + "is the largest!\n");
                }
                else
                {
                    Console.Write("Number " + num3 + " is the largest!\n");
                }
            }//Compare 2 and 3
            else if (num2 > num3)
            {
                Console.Write("Number " + num2 + " is the largest!\n");
            }
            else
                Console.Write("Number " + num3 + " is the largest!\n");
        }
        
    }
}