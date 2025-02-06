using System;
using System.Xml.Serialization;

public class Reference
{
    private string _book;
    private int _chapter;
    private int _startVerse;
    private int _endVerse; 

    public Reference(string bookName, int chapter, int verse)
    {
        _book = bookName;
        _chapter = chapter;
        _startVerse = verse;
        _endVerse = verse;
    }
    private Reference(string bookName, int chapter, int startVerse, int endVerse)
    {
        _book = bookName;
        _chapter = chapter;
        _startVerse = startVerse;
        _endVerse = endVerse;
    }
    public string GetReference()
    {   if (_startVerse != _endVerse)
        {
            return $"{_book} {_chapter}:{_startVerse}-{_endVerse}";
        }
        else 
        {
            return $"{_book} {_chapter}:{_startVerse}";
        
        }
    }
}