using System;
using System.Collections.Generic;
using System.Linq;

namespace linq
{
  class Program
  {
    static void Main(string[] args)
    {

      // Find the words in the collection that start with the letter 'L'
      List<string> fruits = new List<string>() { "Lemon", "Apple", "Orange", "Lime", "Watermelon", "Loganberry" };

      IEnumerable<string> LFruits = from fruit in fruits
                                    where fruit[0] is 'L'
                                    select fruit;
      System.Console.WriteLine("All the fruits that start with L");
      foreach (string Lfruit in LFruits)
      {
        System.Console.WriteLine(Lfruit);
      }

      // Which of the following numbers are multiples of 4 or 6
      List<int> numbers = new List<int>()
      {
            15, 8, 21, 24, 32, 13, 30, 12, 7, 54, 48, 4, 49, 96
      };

      IEnumerable<int> fourSixMultiples = numbers.Where(n => n % 4 == 0 || n % 6 == 0);
      System.Console.WriteLine("All the numbers that are multiplies of 4 or 6");

      foreach (int fourSixMultiple in fourSixMultiples)
      {
        System.Console.WriteLine(fourSixMultiple);
      }

      // Order these student names alphabetically, in descending order (Z to A)
      List<string> names = new List<string>()
      {
            "Heather", "James", "Xavier", "Michelle", "Brian", "Nina",
            "Kathleen", "Sophia", "Amir", "Douglas", "Zarley", "Beatrice",
            "Theodora", "William", "Svetlana", "Charisse", "Yolanda",
            "Gregorio", "Jean-Paul", "Evangelina", "Viktor", "Jacqueline",
            "Francisco", "Tre"
      };
      System.Console.WriteLine("Order these student names alphabetically, in descending order (Z to A)");
      List<string> descend = names.OrderByDescending(people=>people).ToList();
      foreach (string descendNames in descend)
      {
        System.Console.WriteLine(descendNames);
      }
    }
  }
}
