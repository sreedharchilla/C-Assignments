using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
           //  The  avarage maximum and minimum are:
            int[] num = { 6, 3, 15, 9, 12 };
            Console.WriteLine(" The avarage element  is:" + " " + num.Average());
            Console.WriteLine(" The largest element  is:" + " " + num.Max());
            Console.WriteLine(" The smallest element is:" + " " + num.Min());

       
      //  10 marks avarage, maximum and minimum, sum of all marks, aescending , descending order is:
             int[] cs = { 12, 71, 22, 15, 11, 18, 33, 16, 9,5 };
            Console.WriteLine(" The smallest element is :" + " " + cs.Min());
            Console.WriteLine(" The largest element is :" + " " + cs.Max());
            Console.WriteLine(" The avarage element is :" + " " + cs.Average());
            Console.WriteLine("the sum of elements is: " + cs.Sum()); Array.Sort(cs);
            Console.WriteLine("The array aescending order is...");
            foreach (int i in cs)
            {
                Console.WriteLine(i + " ");
            }
            Array.Reverse(cs);
            Console.WriteLine("The array descending order is ...");
            foreach (int i in cs)
            {
                Console.Write(i + " ");
            }

            
           //     The word length is:
             Console.WriteLine(" Enter the  word is ");
            string str = Console.ReadLine();
            Console.WriteLine("String length is :- " + str.Length);

       
          // Reverse  The string is:
          Console.WriteLine(" Enter a string ");
         string Orginal = Console.ReadLine();
            string Reverse = string.Empty; for (int i = Orginal.Length - 1; i >= 0; i--)
            {
                Reverse += Orginal[i];
            }
            Console.WriteLine("  The Reverse String is : " + Reverse);

            
        // Both words are same or not is:
         Console.WriteLine(" Enter a word1 is ");
              string s1 = Console.ReadLine();
            Console.WriteLine(" Enter a word2 is ");
            string s2 = Console.ReadLine();
            if (s1 == s2)
            {
                Console.WriteLine(" Both words are same ");
            }
            else if (s2 != s1)
            {
                Console.WriteLine(" Both words are not same ");
            }

            //find out whether the given word is a palindrome or not.



            string str2, rev;
            Console.WriteLine(" Enter  The  word is ");
            str2 = Console.ReadLine();
            char[] ch = str2.ToCharArray();
            Array.Reverse(ch);
            rev = new string(ch);
            bool b = str2.Equals(rev, StringComparison.OrdinalIgnoreCase);
            if (b == true)
            {
                Console.WriteLine(" " + str2 + " The word is  a palindrome");
            }
            else if (b == false)
            {
                Console.WriteLine(" " + str2 + " The word is not a palindrome ");
            }



            Console.ReadLine();


        }
    }
}
