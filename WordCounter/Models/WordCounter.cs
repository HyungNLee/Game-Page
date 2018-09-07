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
      if (word == "")
      {
        isValidWord = false;
        return isValidWord;
      }
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

    public bool IsSentenceValid(string sentence)
    {
      return (sentence == "") ? false : true;
    }

    public int CountWords()
    {
// This way of counting will also count words within words and not full words.
// Will keep in case of need of this functionality in future iterations.
      // int counter = 0;
      // word = word.ToLower();
      // sentence = sentence.ToLower();
      //
      // for (int i = 0; i < sentence.Length; i++)
      // {
      //   if (sentence[i] == word[0])
      //   {
      //     int indexOfWord = 1;
      //     int indexOfSentence = i + 1;
      //     while (indexOfWord < word.Length)
      //     {
      //       if (sentence[indexOfSentence] != word[indexOfWord])
      //       {
      //         break;
      //       }
      //       else if (indexOfWord == word.Length - 1)
      //       {
      //         counter++;
      //         break;
      //       }
      //       indexOfWord++;
      //       indexOfSentence++;
      //     }
      //   }
      // }
      // return counter;

      string word = _word.ToLower();
      string sentence = _sentence.ToLower();
      string tempString = "";

      foreach (char c in sentence)
      {
        if (!char.IsPunctuation(c))
        {
          tempString += c;
        }
      }

      string[] sentenceWords = tempString.Split(' ');
      int count = 0;
      foreach (string fullWord in sentenceWords)
      {
        if (fullWord.Equals(word))
        {
          count++;
        }
      }
      return count;
    }
  }
}
