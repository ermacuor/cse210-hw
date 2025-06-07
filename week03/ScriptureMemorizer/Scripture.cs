class Scripture
{
    private Reference _reference;
    private List<Word> _words;

    public Scripture(Reference reference, string text)
    {
        _reference = reference;
        _words = new List<Word>();
    
        string[] wordArray = text.Split(' ');
        foreach (string word in wordArray) 
        {
            _words.Add(new Word(word));
        }

    }

    public void HideRandomWords(int numberToHide)
    {
        List<Word> visibleWords = new List<Word>();

        foreach (var word in _words)
        {
            if (!word.IsHidden())
            {
                visibleWords.Add(word);
            }
        }

        Random random = new Random();


        for (int i = 0; i < numberToHide && visibleWords.Count>0; i++)
        {
            int index = random.Next(visibleWords.Count);
            visibleWords[index].Hide();
            visibleWords.RemoveAt(index);
        }
    }

    public string GetDisplayText()
    {
        string referenceText = _reference.GetDisplayText() + ": ";
        string wordsText = "";

        foreach (var word in _words)
        {
            wordsText += word.GetDisplayText() + " ";
        }

        return referenceText + wordsText.Trim();
    }

    public bool IsCompletelyHidden()
    {
        foreach (var word in _words)
        {
            if (!word.IsHidden())
            {
                return false;
            }
        }
        return true;
    }
    public string GetCompletelyHiddenText()
    {
        string referenceText = _reference.GetDisplayText() + ": ";
        string wordsText = "";

        foreach (var word in _words)
        {
            wordsText += new string('_', word.GetDisplayText().Length) + " ";
        }

        return referenceText + wordsText.Trim();
    }

}
