class Word
{
    private string _text;
    private bool _isHidden;

    public Word(string text)
    {
        _text = text;
        _isHidden = false;
    }

    public void Hide()
    {
        _isHidden = true;
    }
    public void Show()
    {
        _isHidden = false;
    }
    public bool IsHidden()
    {
        return _isHidden;
    }
    public string GetDisplayText()
    {
        string resultado;

        if (_isHidden)
        {
            resultado = new string('_', _text.Length);
        }
        else
        {
            resultado = _text;
        }

        return resultado;

    }
}