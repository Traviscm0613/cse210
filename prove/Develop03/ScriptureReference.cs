class ScriptureReference
{
    private string _bookName;
    private int _chapter;
    private int _startVerse;
    private int? _endVerse;

    public ScriptureReference(string name, int chapter, int verse)
    {
        _bookName = name;
        _chapter = chapter;
        _startVerse = verse;
        _endVerse = null;

    }

    public ScriptureReference(string name, int chapter, int startVerse, int endVerse)
    {
        _bookName = name;
        _chapter = chapter;
        _startVerse = startVerse;
        _endVerse = endVerse;
    }

    public void DisplayScriptureReference()
    {
        Console.WriteLine(GetScriptureReference());
    }

    // This is how the scripture in program.cs will return.
    public string GetScriptureReference()
    {
        if (_endVerse.HasValue)
        {
            return $"{_bookName} {_chapter}:{_startVerse}-{_endVerse}";
        }

        return $"{_bookName} {_chapter}:{_startVerse}";
    }
}