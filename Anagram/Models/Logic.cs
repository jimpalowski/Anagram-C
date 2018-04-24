using System.Collections.Generic;
using System;

namespace Anagram.Models
{
  public class Solution
  {
  public static List<Solution> _instances = new List<Solution> {};
  private string _anagram;

  public Solution(string newAnagram)
  {
    _anagram = newAnagram;
  }
  public string GetAnagram()
  {
    return _anagram;
  }
  public static List<Solution> GetAll()
  {
    return _instances;
  }
  public static void Clear()
  {
    _instances.Clear();
  }

  }
}
