using Microsoft.VisualStudio.TestTools.UnitTesting;
using WordCounter;
using System;

namespace WordCounter.TestTools
{
  [TestClass]
  public class RepeatCounterTest
  {
    [TestMethod]
    public void GetInputs_True()
    {
      //Arrange
      RepeatCounter testCounter = new RepeatCounter();
      string word = "Pizza";
      string sentence = "pizza, Pizza, PIZZA";

      //Act
      testCounter.SetWord(word);
      testCounter.SetSentence(sentence);
      string testString = word + sentence;
      string result = testCounter.GetWord() + testCounter.GetSentence();

      //Assert
      Assert.AreEqual(testString, result);
    }
  }
}
