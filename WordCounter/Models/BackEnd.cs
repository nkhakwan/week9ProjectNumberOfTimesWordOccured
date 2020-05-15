using System;
using System.Collections.Generic;

namespace WordInASentence
{
  public class RepeatCounters
  {
    public static Dictionary<int,string> WordsContainer {get; set;}
    public int  GrandTotal {get; set;}
    public int  WordIsThere {get; set;}
    public RepeatCounters()
    {
      WordsContainer = new Dictionary <int,string> { {1,""}, {2,""}, {3,""}, {4, ""},{5, ""},{6,""},{7,""} };
      GrandTotal =0;
      WordIsThere = 0;

    }
    
    public void DoesItContain (string Word, string Sentence)
    {
      
    }

    public void NumberOfTimes (string Word, string Sentence)
    {
      
    }
  }
}