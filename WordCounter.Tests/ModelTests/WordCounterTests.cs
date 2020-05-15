using Microsoft.VisualStudio.TestTools.UnitTesting;
using WordInASentence;
// confirmed tests fail before writing the code


namespace WordInASentence
{
  [TestClass]
  public class RepeatCounterTests
  {
    [TestMethod]
    public void DoesItContain_ChecksIfWordIsContained_WordIsThereUpdated()
    {
      // Arrange
      string Word = "cat";
      string Sentence = "My cat lives in Petcat village with other cats that look like cat";

      // Act
      RepeatCounters MyRepeatCounter = new RepeatCounters();
      MyRepeatCounter.DoesItContain(Word, Sentence);

      // Assert
      Assert.AreEqual(1,MyRepeatCounter.WordIsThere);

    }

    [TestMethod]
    public void NumberOfTimes_ChecksWhetherCountedWordCorrect_GrandTotalIsUpdated()
    {
      // Arrange
      string Word = "cat";
      string Sentence = "My cat lives in Petcat village with other cats that look like cat";


      // Act
       RepeatCounters MyRepeatCounter = new RepeatCounters();
       MyRepeatCounter.NumberOfTimes(Word, Sentence);

      // Assert
      Assert.AreEqual(2, MyRepeatCounter.GrandTotal);

    }
  }
}
