using Microsoft.VisualStudio.TestTools.UnitTesting;
using WordCounter;
using WordCounter.Models;
using System;

namespace WordCounter.TestTools
{
  [TestClass]
  public class RepeatCounterTest
  {
    [TestMethod]
    public void GetInputs_SetWordAndSentence_True()
    {
      //Arrange
      string word = "Pizza";
      string sentence = "pizza, Pizza, PIZZA";
      RepeatCounter testCounter = new RepeatCounter(word, sentence);

      //Act
      string testString = word + sentence;
      string result = testCounter.GetWord() + testCounter.GetSentence();

      //Assert
      Assert.AreEqual(testString, result);
    }


    [TestMethod]
    public void CountWords_CountWords_3()
    {
      //Arrange
      string word = "Pizza";
      string sentence = "pizza, Pizza, PIZZA";
      RepeatCounter testCounter = new RepeatCounter(word, sentence);

      //Act
      int counter = testCounter.GetCount();

      //Assert
      Assert.AreEqual(3, counter);
    }
  }
}
