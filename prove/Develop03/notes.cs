// static void Main(string[] args)
// {
//     List<Scripture> scriptures = new List<Scripture>
//     {
//         new Scripture("Moses", 1, 39,
//             "Behold, this is my work and my glory to bring to pass the immortality and eternal life of man"),
//     new Scripture("John", 3, 16,
//         "For God so loved the world, that he gave his only begotten Son"),

//     new Scripture("Proverbs", 3, 5,
//         "Trust in the Lord with all thine heart; and lean not unto thine own understanding"),

//     new Scripture("Philippians", 4, 13,
//         "I can do all things through Christ which strengtheneth me"),

//     new Scripture("Psalm", 23, 1,
//         "The Lord is my shepherd; I shall not want")
// };

// Random random = new Random();
// Scripture scripture = scriptures[random.Next(scriptures.Count)];

// while (true)
// {
//     Console.Clear();

//     Console.WriteLine(scripture.GetScriptureReference());
//     scripture.ShowScripture();
//     Console.WriteLine();

//     Console.Write("Press Enter to continue or type 'quit' to finish: ");
//     string input = Console.ReadLine();

//     if (input.ToLower() == "quit")
//     {
//         break;
//     }

//     if (scripture.HideSomeWords())
//     {
//         break;
//     }
// }
// } class Scripture
// {
//     private List<Word> _words;
//     // TODO - Add scripture reference
//     private ScriptureReference _reference;
// public Scripture(string bookName, int chapter, int verse, string text)
// {
//     _reference = new ScriptureReference(bookName, chapter, verse);
//     _words = ConvertToWordList(text);
// }

// public Scripture(string name, int chapter, int startVerse, int endVerse, string text)
// {
//     _words = ConvertToWordList(text);
// }

// public Scripture(ref ScriptureReference reference, string text)
// {
//     _reference = reference;
//     _words = ConvertToWordList(text);
// }

// public bool HideSomeWords()
// {
//     List<int> unhiddenWords = new List<int>();

//     for (int i = 0; i < _words.Count; i++)
//     {
//         if (!_words[i].IsHidden())
//         {
//             unhiddenWords.Add(i);
//         }
//     }

//     return NumberOfHiddenWords() ==_words.Count;
// }

// public int GetWordCount()
// {
//     return _words.Count;
// }
// public void ShowScripture()
// {
//     foreach(Word word in _words)
//     {
//         word.Display();
//     }
// }

// // TODO - Add constructor for ScriptureReference
// public string GetScriptureReference()
// {
//     return _reference.GetScriptureReference();
// }

// public int NumberOfHiddenWords()
// {
//     int hiddenWords = 0;

//     foreach (Word word in _words)
//     {
//         if (word.IsHidden())
//         {
//             hiddenWords++;
//         }
//     }

//     return hiddenWords;
// }

// // ConvertTOWordList() - this method will receive a string paramter, which is a paragraph of text. It will split that text into words and create and add those words to a List<word> and return the list. //
// private List<Word> ConvertToWordList(string text)
// {
//     List<Word> tempWordList = new List<Word>();
//     string[] tempWords = text.Split(' ');
//     foreach(string w in tempWords)
//     {
//         Word tempWord = new Word(w);
//         tempWordList.Add(tempWord);
//     }
//     return tempWordList;
// }
// } class ScriptureReference
// {
//     private string _bookName;
//     private int _chapter;
//     private int _startVerse;
//     private int? _endVerse;
// public ScriptureReference(string name, int chapter, int verse)
// {
//     _bookName = name;
//     _chapter = chapter;
//     _startVerse = verse;
//     _endVerse = null;

// }

// public ScriptureReference(string name, int chapter, int startVerse, int endVerse)
// {
//     _bookName = name;
//     _chapter = chapter;
//     _startVerse = startVerse;
//     _endVerse = endVerse;
// }

// public void DisplayScriptureReference()
// {
//     Console.WriteLine(GetScriptureReference());
// }
// public string GetScriptureReference()
// {
//     if (_endVerse.HasValue)
//     {
//         return $"{_bookName} {_chapter}:{_startVerse}-{_endVerse}";
//     }

//     return $"{_bookName} {_chapter}:{_startVerse}";
// }
// }  class Word
// {
//     private string  _word;
// private bool _hidden;

// public Word(string word)
// {
//     _word = word;
//     _hidden = false;
// }

// public bool IsHidden()
// {
//     return _hidden;
// }

// public void Hide()
// {
//     _hidden = true;
// }

// public string GetWordString()
// {
//     string returnString = "";
//     if (_hidden)
//     {
//         // for(int i = 0; i < _word.Length; i++)
//         foreach(char c in _word)
//         {
//             returnString += '_';
//         }
//     }
//     else
//         {
//             returnString = _word;
//         }
//     return returnString;
// }

// public void Display()
// {
//     Console.Write($"{GetWordString()} ");
// }
// }
//  whats wrong?