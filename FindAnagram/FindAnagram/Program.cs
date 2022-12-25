
using System;
using System.Collections;

namespace FindAnagram
{

    public class Program
    {
        public static bool areAnagram(ArrayList str1,
                                   ArrayList str2)
        {
            // For lengths of both strings
            int n1 = str1.Count;
            int n2 = str2.Count;

            if (n1 != n2)
            {
                return false;
            }

            // Sort both strings
            str1.Sort();
            str2.Sort();

            // Compare sorted strings
            for (int i = 0; i < n1; i++)
            {
                if (str1[i] != str2[i])
                {
                    return false;
                }
            }

            return true;
        }

       
        public static void Main(string[] args)
        {
            
            ArrayList str1 = new ArrayList();
            str1.Add('g');
            str1.Add('r');
            str1.Add('a');
            str1.Add('m');
           
            ArrayList str2 = new ArrayList();
            str2.Add('a');
            str2.Add('r');
            str2.Add('m');

            // Function call
            if (areAnagram(str1, str2))
            {
                Console.WriteLine("The two strings are"
                                  + " anagram of each other");
            }
            else
            {
                Console.WriteLine("The two strings are not"
                                  + " anagram of each other");
            }
        }
    }
}