using System.Collections.Generic;
using System;
using System.Linq;

namespace Anagram.Models
{
  public class Solution
  {
      //Receive Words from User
         private string _anagramOne;
         private string _anagramTwo;
         private static List<Solution> _instances = new List<Solution> {};
         public Solution(string AnagramOne, string AnagramTwo)
         {
           _anagramOne = AnagramOne;
           _anagramTwo = AnagramTwo;
         }

         public string GetAnagramOne()
         {
           return _anagramOne;
         }
         public string GetAnagramTwo()
         {
           return _anagramTwo;
         }
         public static List<Solution> GetAll()
         {
           return _instances;
         }
         public void Save()
         {
           _instances.Add(this);
         }
         public bool IsAnagram()
         {
         char[] char1 = _anagramOne.ToLower().ToArray();
         char[] char2 = _anagramTwo.ToLower().ToArray();
         Array.Sort(char1);
         Array.Sort(char2);
         return string.Join("", char1).Contains( string.Join("", char2) );
        //  string NewWord1 = new string(char1);
        //  string NewWord2 = new string(char2);
        //  if (NewWord1 == NewWord2)
        //  {
        //      Console.WriteLine("Yes! Words \"{0}\" and \"{1}\" are Anagrams", AnagramOne, AnagramTwo);
        //  }
        //  else
        //  {
        //      Console.WriteLine("No! Words \"{0}\" and \"{1}\" are not Anagrams", AnagramOne, AnagramTwo);
        //  }
       }
     }
   }
