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

     IEnumerable<string> LFruits = from fruit in fruits where fruit[0] is 'L'
     select fruit;
        
    foreach (string Lfruit in LFruits){
        System.Console.WriteLine(Lfruit);
    }

    }
  }
}
