using System;
using System.Collections.Generic;

namespace WordInASentence
{
  public class Program
  {
    public static void Main()
    {
      RepeatCounters MyCounter = new RepeatCounters();

      Console.WriteLine("I can take a word and a sentence and see how many times that word is contained in a sentence. Please enter the Word you want counted");
      string Word = Console.ReadLine();
      Console.WriteLine("Now please enter your sentence");
      string Sentence = Console.ReadLine();
      MyCounter.DoesItContain(Word, Sentence);
      Console.WriteLine($"here is the word is there{MyCounter.WordIsThere}");
      Console.WriteLine($"here is the MyTotal{MyCounter.GrandTotal}");
      
      
      

          



    }
  }
}