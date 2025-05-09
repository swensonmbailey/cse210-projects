using System.Linq.Expressions;
using System.Security.Cryptography;

public class Scripture
{
    private string _passage;
    private Reference _ref;
    private List<Word> _words = new List<Word>();

    public Scripture(string passage, string scriptRef)
    {
        _passage = passage;
        _ref = new Reference(FindBook(scriptRef), FindChapter(scriptRef), FindStartVerse(scriptRef), FindEndVerse(scriptRef));
        MakeWoodList(passage);
    }

    public bool HideWord()
    {
        
        //use length of words list to randomize element indexes.
        //use for loop and counter to loop through until 3 words are hidden
        
        int areVisible = CountStillVisible();

        int counter = areVisible >= 3 ? 3 : areVisible;

        Random rand = new Random();
        while(counter > 0)
        {
            int randIndex = rand.Next(0, _words.Count);
            if(_words[randIndex].GetIsVisible()){
                _words[randIndex].Hide();
                counter -= 1;
            }
        }
        DisplayScripture();
        return CheckAllHidden();
    }

    public void DisplayScripture()
    {
        string passage = "Memorize the following verse. \n";
        passage = $"{_ref.GetRef()} \n";

        foreach(var word in _words)
        {
            passage += word.GetWord();
        }
        Console.Clear();
        Console.WriteLine(passage);
        Console.WriteLine("Press Enter to hide more words. Type 'quit' to end.");
    }

    private void MakeWoodList(string passage)
    {
        string[] words = passage.Split(" ");

        foreach(var item in words)
        {
            Word newWord = new Word(item);
            _words.Add(newWord);
        }
    }

    private string FindBook(string scriptRef)
    {
        return scriptRef.Substring(0, scriptRef.IndexOf(' '));
    }

    private int FindChapter(string scriptRef)
    {
        int startIndex = scriptRef.IndexOf(" ");
        int numOfChar = (scriptRef.IndexOf(":")) - (scriptRef.IndexOf(" "));
        int chapter = int.Parse(scriptRef.Substring(startIndex, numOfChar));

        return chapter;
    }

    private int FindStartVerse(string scriptRef)
    {
        int startIndex = scriptRef.IndexOf(": ") + 2;
        int startVerse;

        int dashIndex = scriptRef.IndexOf("-");

        if(dashIndex > -1)
        {
            int numOfChar = dashIndex - startIndex;
            startVerse = int.Parse(scriptRef.Substring(startIndex, numOfChar));
        }else
        {
            startVerse = int.Parse(scriptRef.Substring(startIndex));
        }
        
        

        return startVerse;
    }

    private int FindEndVerse(string scriptRef)
    {
        int endVerse;

        int dashIndex = scriptRef.IndexOf("-");

        if(dashIndex > -1)
        {
            int startIndex = dashIndex + 1;
            endVerse = int.Parse(scriptRef.Substring(startIndex));
        }else
        {
            endVerse = -1;
        }
        return endVerse;
    }

    private bool CheckAllHidden()
    {
        bool allHidden = true;
        foreach(var word in _words)
        {
            if(word.GetIsVisible())
            {
                allHidden = false;
                break;
            }
        }
        return allHidden;
    }  

    private int CountStillVisible()
    {
        int areVisible=0;
        foreach(var word in _words)
        {
            if(word.GetIsVisible())
            {
                areVisible++;
            }
        }
        return areVisible;
    }
}