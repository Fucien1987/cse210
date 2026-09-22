public class Reference
{
    private string _book;
    private int _chapter;
    private int _verse;
    private int __endVerse;

    public Reference(string book, int chapter, int verse)
    {
        _book = book;
        _chapter = chapter;
        _verse = verse;
        __endVerse = verse;
    }
    public Reference(string book, int chapter, int startVerse, int endVerse)
    {
        _book = book;
        _chapter = chapter;
        _verse = startVerse;
        __endVerse = endVerse;
    }
    public string GetDisplayText()
    {
        if (_verse == __endVerse)
        {
            return $"{_book} {_chapter}:{_verse}";
        }
        return $"{_book} {_chapter}:{_verse}-{__endVerse}";
    }
}