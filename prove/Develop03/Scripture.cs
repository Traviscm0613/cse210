class Scripture
{
    private List<Word> _words;
    // TODO - Add scripture reference
    private ScriptureReference _reference;

    public Scripture(string bookName, int chapter, int verse, string text)
    {
        _reference = new ScriptureReference(bookName, chapter, verse);
        _words = ConvertToWordList(text);
    }

    public Scripture(string name, int chapter, int startVerse, int endVerse, string text)
    {
        _words = ConvertToWordList(text);
    }

    public Scripture(ref ScriptureReference reference, string text)
    {
        _reference = reference;
        _words = ConvertToWordList(text);
    }

    public bool HideSomeWords()
    {
        List<int> unhiddenWords = new List<int>();

        for (int i = 0; i < _words.Count; i++)
        {
            if (!_words[i].IsHidden())
            {
                unhiddenWords.Add(i);
            }
        }

        return NumberOfHiddenWords() ==_words.Count;
    }
    
    public int GetWordCount()
    {
        return _words.Count;
    }
    public void ShowScripture()
    {
        foreach(Word word in _words)
        {
            word.Display();
        }
    }

    // TODO - Add constructor for ScriptureReference
    public string GetScriptureReference()
    {
        return _reference.GetScriptureReference();
    }

    public int NumberOfHiddenWords()
    {
        int hiddenWords = 0;

        foreach (Word word in _words)
        {
            if (word.IsHidden())
            {
                hiddenWords++;
            }
        }

        return hiddenWords;
    }

    // ConvertTOWordList() - this method will receive a string paramter, which is a paragraph of text. It will split that text into words and create and add those words to a List<word> and return the list. //
    private List<Word> ConvertToWordList(string text)
    {
        List<Word> tempWordList = new List<Word>();
        string[] tempWords = text.Split(' ');
        foreach(string w in tempWords)
        {
            Word tempWord = new Word(w);
            tempWordList.Add(tempWord);
        }
        return tempWordList;
    }


}