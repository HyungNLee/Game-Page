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
  }
}
