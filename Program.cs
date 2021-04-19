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

    // Solution 1:
    // readable solution with bad performance?
    /*
    return numbers
      .GroupBy(n => n)
      .Where(group => group.Count() > 1)
      .Select(group => group.First());
      */

    // Solution 2:
    // fun solution, slightly more performant? but more complex?
    /*
    numbers.Sort(); // warning: this mutates the original list!
    var alreadyCounted = new List<int>();
    for (var i = 0; i < numbers.Count; i++)
    {
      // crazy logic
      if (!alreadyCounted.Contains(numbers[i])
        && (i + 1) < numbers.Count
        && numbers[i + 1] == numbers[i])
      {
        // using another array
        alreadyCounted.Add(numbers[i]);
        // but at least they understand enumerables
        yield return numbers[i];
        // and the output is in a different order than the other one
      }
    }
    */
  }
}