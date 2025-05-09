public class Word
{
    private bool _isVisible;
    private string _word;

    public Word(string word)
    {
        _word = word;
        _isVisible = true;
    }

    public string GetWord()
    {
        return $" {_word}";
    }

    public void Hide()
    {
        _isVisible = false;

        string hiddenWord = "";
        
        for(int i=_word.Length; i > 0; i--)
        {
            hiddenWord += "-";
        }
        _word = hiddenWord;
    }

    public bool GetIsVisible()
    {
        return _isVisible;
    }
}