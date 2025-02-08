using System; 

public class Word
{
    private string _text;
    private bool _isHidden;

    public Word(string word)
    {
        _text = word;
        _isHidden = false;
    }

    public void ShowWord()
    {
        _isHidden = false;
    }
    public void HideWord()
    {
        if (!_isHidden) 
        {
            _isHidden = true;
        }
    }
    public bool IsHidden()
    {
        return _isHidden;
    }
    public void GetDisplayText()
    {
        if (_isHidden)
        {
            Console.Write(new string( '_' , _text.Length));
        }
        else
        {
            Console.Write(_text);
        }
    }
}