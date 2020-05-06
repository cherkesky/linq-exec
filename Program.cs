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
      List<string> descend = names.OrderByDescending(people => people).ToList();
      foreach (string descendNames in descend)
      {
        System.Console.WriteLine(descendNames);
      }

      // Build a collection of these numbers sorted in ascending order
      List<int> numbers2 = new List<int>()
    {
        15, 8, 21, 24, 32, 13, 30, 12, 7, 54, 48, 4, 49, 96
    };
      System.Console.WriteLine("Build a collection of these numbers sorted in ascending order");

      List<int> ascends = numbers2.OrderBy(nums2 => nums2).ToList();
      foreach (int ascend in ascends)
      {
        System.Console.WriteLine(ascend);
      }
      // Output how many numbers are in this list
      List<int> numbers3 = new List<int>()
    {
        15, 8, 21, 24, 32, 13, 30, 12, 7, 54, 48, 4, 49, 96
    };
      System.Console.WriteLine("Output how many numbers are in this list");

        int counter=numbers3.Count();
        System.Console.WriteLine(counter);

    // How much money have we made?
    List<double> purchases = new List<double>()
    {
        2340.29, 745.31, 21.76, 34.03, 4786.45, 879.45, 9442.85, 2454.63, 45.65
    };
        System.Console.WriteLine("How much money have we made?");
      double counter2=purchases.Sum();
        System.Console.WriteLine(counter2);


    }
  }
}
