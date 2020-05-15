using Microsoft.VisualStudio.TestTools.UnitTesting;
using WordInASentence;


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
      string Sentence = "My Cat lives in Petcat village with other cats that look like Cat";


      // Act
       RepeatCounters MyRepeatCounter = new RepeatCounters();
       MyRepeatCounter.NumberOfTimes(Word, Sentence);

      // Assert
      Assert.AreEqual(2, MyRepeatCounter.GrandTotal);

    }

    [TestMethod]
    public void DoesItContain_ChecksIfWordIsContained_ExpectingZero()
    {
      // Arrange
      string Word = "cat";
      string Sentence = "It is a dog sentence and reverse of tac is not here";

      // Act
      RepeatCounters MyRepeatCounter = new RepeatCounters();
      MyRepeatCounter.DoesItContain(Word, Sentence);

      // Assert
      Assert.AreEqual(1,MyRepeatCounter.WordIsThere);

    }

    [TestMethod]
    public void NumberOfTimes_ChecksWhetherCountedWordCorrect_GrandTotalEqualsZero()
    {
      // Arrange
      string Word = "cat";
      string Sentence = "My cats live in Petcat village with other cats that look more like a dog";


      // Act
       RepeatCounters MyRepeatCounter = new RepeatCounters();
       MyRepeatCounter.NumberOfTimes(Word, Sentence);

      // Assert
      Assert.AreEqual(2, MyRepeatCounter.GrandTotal);

    }
  }
}
