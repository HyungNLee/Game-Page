using Microsoft.VisualStudio.TestTools.UnitTesting;
using WordCounter;
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

    [TestMethod]
    public void IsSentenceValid_IsSentenceValid_false()
    {
      //Arrange
      RepeatCounter testCounter = new RepeatCounter();
      string sentence = "";

      //Act
      bool isValid = testCounter.IsSentenceValid(sentence);

      //Assert
      Assert.AreEqual(false, isValid);
    }

    [TestMethod]
    public void IsInputValid_IsInputValid_false()
    {
      //Arrange
      RepeatCounter testCounter = new RepeatCounter();
      string word = "Pizza.";

      //Act
      bool isValid = testCounter.IsInputValid(word);

      //Assert
      Assert.AreEqual(false, isValid);
    }

    [TestMethod]
    public void CountWords_CountWords_3()
    {
      //Arrange
      RepeatCounter testCounter = new RepeatCounter();
      string word = "Pizza";
      string sentence = "pizza, Pizza, PIZZA";

      //Act
      testCounter.SetWord(word);
      testCounter.SetSentence(sentence);
      int counter = testCounter.CountWords(word, sentence);

      //Assert
      Assert.AreEqual(3, counter);
    }
  }
}
