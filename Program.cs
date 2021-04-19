using System;
using System.Collections.Generic;
using System.Linq;

/**
  It's a coding challenge!

  Complete the 'GetDuplicates' method to return only
  the numbers that are duplicated in the given collection.

  For the list 7, 2, 7, 7, 9, 5, 2
  we would expect an output similar to "7, 2"
*/
public class Program
{
  public static void Main()
  {
    var numbers = new List<int> { 7, 2, 7, 7, 9, 5, 2 };

    var duplicates = GetDuplicates(numbers);

    foreach (var dupe in duplicates)
    {
      Console.WriteLine(dupe.ToString());
    }
  }

  private static IEnumerable<int> GetDuplicates(List<int> numbers)
  {
    return new List<int>();
  }
}