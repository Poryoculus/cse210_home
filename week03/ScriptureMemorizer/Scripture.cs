using System; 

public class Scripture 
{
    //Variables
    private List<Word> _scripture;
    private Reference _reference; 

    public Scripture(Reference reference, string scriptureText)
    {
        
        _reference = reference;
        _scripture = new List<Word>();
        foreach (var word in scriptureText.Split(" "))
        {
            _scripture.Add(new Word(word));
        }


    }
    public void hideWords()
    {
        Random randomFactor = new Random();
        int wordsToHide = 2;
        
        int hiddenWords = 0;

        while (hiddenWords < wordsToHide)
        {
            int index;
            do
            {
                index = randomFactor.Next(_scripture.Count);
            }
            while (_scripture[index].IsHidden());

            Word selectedWord = _scripture[index];
            selectedWord.HideWord();
            hiddenWords++;
        }
    }

    public void GetDisplayAll()
    {
        Console.WriteLine(_reference.GetReference());
        foreach (Word word in _scripture)
        {
            word.GetDisplayText();
            Console.Write(" ");
        }
    }
    public bool isCompletelyHidden()
    {
        int wordCount = _scripture.Count;
        int hiddenWords = 0;
        foreach (Word word in _scripture)
        {
            bool confirmation = word.IsHidden();
            if (confirmation == true)
            {
                hiddenWords++;
            }
        }
        if (hiddenWords == wordCount)
        {
            return true;
        }
        else
        {
            return false;
        }
    }
    
}