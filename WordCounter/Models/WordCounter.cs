using System;
using System.Collections.Generic;

namespace WordCounter
{
  public class RepeatCounter
  {
    private string _word;
    private string _sentence;

    public void SetWord(string newWord)
    {
      _word = newWord;
    }

    public void SetSentence(string newSentence)
    {
      _sentence = newSentence;
    }

    public string GetWord()
    {
      return _word;
    }

    public string GetSentence()
    {
      return _sentence;
    }

    public bool IsInputValid(string word)
    {
      bool isValidWord = true;
      foreach (char c in word)
      {
        if (char.IsPunctuation(c))
        {
          isValidWord = false;
          return isValidWord;
        }
      }
      return isValidWord;
    }

    public int CountWords(string word, string sentence)
    {
      int counter = 0;
      word = word.ToLower();
      sentence = sentence.ToLower();

      for (int i = 0; i < sentence.Length; i++)
      {
        if (sentence[i] == word[0])
        {
          int indexOfWord = 1;
          int indexOfSentence = i + 1;
          while (indexOfWord < word.Length)
          {
            if (sentence[indexOfSentence] != word[indexOfWord])
            {
              break;
            }
            else if (indexOfWord == word.Length - 1)
            {
              counter++;
              break;
            }
            indexOfWord++;
            indexOfSentence++;
          }
        }
      }
      return counter;
    }
  }
}
