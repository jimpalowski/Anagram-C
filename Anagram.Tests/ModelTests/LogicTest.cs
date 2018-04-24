using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System;
using Anagram.Models;

namespace Anagram.Tests
{
      [TestClass]
      public class AnagramTest
      {
      [TestMethod]
      public void GetAnagram_ReturnSorted()
      {
      //Arrange
      string Anagram = "Hello";
      char[] charX = Anagram.ToCharArray();
      Array.Sort(charX);
      Solution newAnagram = new Solution(Anagram);
      foreach(char letter in charX)
      {
        // Console.WriteLine(letter);
        Console.WriteLine(charX);
      }
      //Act
      string result = newAnagram.GetAnagram();

      //Assert
      Assert.AreEqual(charX, result);
    }


  //   [TestMethod]
  //   public void SplitAnagram()
  //   {
  //   //Arrange
  //   string[] Anagram = {"a", "x", "c", "e"};
  //
  //   Solution newAnagram = new Solution(Anagram);
  //   var sortedNames = Anagram.OrderBy(n => n);
  //   foreach(var item in sortedNames)
  //   {
  //     Console.WriteLine(item);
  //   }
  //   //Act
  //   string result = Anagram;
  //
  //   //Assert
  //   Assert.AreEqual(result);
  // }
  }
}
