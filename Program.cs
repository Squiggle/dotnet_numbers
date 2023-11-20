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

    var duplicates = GetDuplicatesWithLinq(numbers);
    //var duplicates = GetDuplicatesWithLoops(numbers);

    foreach (var dupe in duplicates)
    {
      Console.WriteLine(dupe.ToString());
    }
  }


  /// <summary>
  /// With Linq
  /// </summary>
  private static IEnumerable<int> GetDuplicatesWithLinq(List<int> numbers) => numbers
      .GroupBy(n => n)
      .Where(group => group.Count() > 1)
      .Select(group => group.Key);

  /// <summary>
  /// With loops
  /// </summary>
  private static IEnumerable<int> GetDuplicatesWithLoops(List<int> numbers)
  {
    var alreadyCounted = new List<int>();
    if (numbers.Count > 1)
    {
      for (var i = 1; i < numbers.Count; i++)
      {
        for (var j = 0; j < i; j++)
        {
          if (numbers[j] == numbers[i] && !alreadyCounted.Contains(numbers[i]))
          {
            alreadyCounted.Add(numbers[i]);
            yield return numbers[i];
          }
        }
      }
    }
  }
}