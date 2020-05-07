using System;
using System.Collections.Generic;
using System.Linq;


namespace linq
{
  // Build a collection of customers who are millionaires
  public class Customer
  {
    public string Name { get; set; }
    public double Balance { get; set; }
    public string Bank { get; set; }
  }
 public class MillionairReport
 {
     public string BankName {get; set;}
    public int MillionairCounter {get; set;}

 }

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

      int counter = numbers3.Count();
      System.Console.WriteLine(counter);

      // How much money have we made?
      List<double> purchases = new List<double>()
    {
        2340.29, 745.31, 21.76, 34.03, 4786.45, 879.45, 9442.85, 2454.63, 45.65
    };
      System.Console.WriteLine("How much money have we made?");
      double counter2 = purchases.Sum();
      System.Console.WriteLine(counter2);

      // What is our most expensive product?
      List<double> prices = new List<double>()
    {
        879.45, 9442.85, 2454.63, 45.65, 2340.29, 34.03, 4786.45, 745.31, 21.76
    };

      List<double> orderedPrices = prices.OrderByDescending(p => p).ToList();
      System.Console.WriteLine("What is our most expensive product?");
      System.Console.WriteLine(orderedPrices[0]);


      List<int> wheresSquaredo = new List<int>()
    {
        66, 12, 8, 27, 82, 34, 7, 50, 19, 46, 81, 23, 30, 4, 68, 14
    };
      /*
          Store each number in the following List until a perfect square
          is detected.

          Expected output is { 66, 12, 8, 27, 82, 34, 7, 50, 19, 46 } 

          Ref: https://msdn.microsoft.com/en-us/library/system.math.sqrt(v=vs.110).aspx
      */

      System.Console.WriteLine("Store each number in the following List until a perfect square is detected.");
      foreach (int number2 in wheresSquaredo)
      {
        double result = Math.Sqrt(number2);
        bool isPerfectSquare = result % 1 == 0;
        if (isPerfectSquare == true)
        {
          break;
        }
        else
        {
          System.Console.WriteLine(number2);

        }
      }

// Build a collection of customers who are millionaires

        List<Customer> customers = new List<Customer>() {
            new Customer(){ Name="Bob Lesman", Balance=80345.66, Bank="FTB"},
            new Customer(){ Name="Joe Landy", Balance=9284756.21, Bank="WF"},
            new Customer(){ Name="Meg Ford", Balance=487233.01, Bank="BOA"},
            new Customer(){ Name="Peg Vale", Balance=7001449.92, Bank="BOA"},
            new Customer(){ Name="Mike Johnson", Balance=790872.12, Bank="WF"},
            new Customer(){ Name="Les Paul", Balance=8374892.54, Bank="WF"},
            new Customer(){ Name="Sid Crosby", Balance=957436.39, Bank="FTB"},
            new Customer(){ Name="Sarah Ng", Balance=56562389.85, Bank="FTB"},
            new Customer(){ Name="Tina Fey", Balance=1000000.00, Bank="CITI"},
            new Customer(){ Name="Sid Brown", Balance=49582.68, Bank="CITI"}
        };
        System.Console.WriteLine("Build a collection of customers who are millionaires");
        List<MillionairReport> millionairReport1 = (from customer in customers
        group customer by customer.Bank into bankGroup
        select new MillionairReport {
            BankName = bankGroup.Key,
            MillionairCounter = bankGroup.Count()
        }).ToList();

            foreach(MillionairReport entry in millionairReport1)
            {
                Console.WriteLine($"{entry.BankName}, {entry.MillionairCounter}");
            }
}
}
}
