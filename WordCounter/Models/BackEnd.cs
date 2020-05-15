using System;
using System.Collections.Generic;

namespace WordInASentence
{
  public class RepeatCounters
  {
    public int  GrandTotal {get; set;}
    public int  WordIsThere {get; set;}
    public RepeatCounters()
    {
      GrandTotal =0;
      WordIsThere = 0;

    }
    
    public void DoesItContain (string Word, string Sentence)
    {
      string TheWord = Word.ToLower();
      string TheSentence =Sentence.ToLower();
      if(TheSentence.Contains(TheWord))
      {
        WordIsThere = 1;
        NumberOfTimes (TheWord, TheSentence);
      }
      
    }

    public void NumberOfTimes (string Word, string Sentence)
    {
      string [] MyArray = Sentence.Split(" ");
      for (int i=0; i<MyArray.Length; i++)
      {
        if (Word == MyArray[i])
        {
          GrandTotal += 1;
        }
      }
    }
  }
}