

public class Word
{

    private string _text = "";

    private bool _isHidden = false;


    public Word(string text)
    {

        _text = (text);

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

    if (IsHidden() == true)
    {

        string hideWord = "";
        int help = _text.Count() - 1;
        for(int i = 0; i < help; i++)
        {
            
            hideWord = hideWord + "_";

        }

        hideWord = ($"{hideWord} ");
        

        return hideWord;
    }

    else
    {

        return _text;

    }

   }

}