using System;
using System.Collections.Generic;

namespace VowelsorConstant
{
    //Determines whether an element is in the List<T>., where T is an item
    public static class Extensions
    {
        //Contains is a method in 
        public static bool find<T>(this List<T> vowel, T i)
        {
            //return either true or false
            return vowel.Contains(i);
        }
    }
    class VowelsorConstant
    {
        static void Main(string[] args)
        {
            //List containing all vowels
            List<string> vowel = new List<string> {"A","E","I","O","U","a","e","i","o","u"};
            //Input string from user
            Console.WriteLine("Enter a string \n");
            string input =Console.ReadLine();
            //check each character in string 
            foreach(char i in input)
            {
                bool isExist = vowel.find(Convert.ToString(i));
                if (isExist==true)
                {
                    Console.WriteLine(i+" ->Vowel");
                }
                else
                {
                    Console.WriteLine(i + " ->Consonant");

                }

            }
            
        }
    }
}
