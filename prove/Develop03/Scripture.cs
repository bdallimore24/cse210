using System;
using System.Collections.Generic;

public class Scripture
{
    
    private Reference _reference = new Reference(); 

    private List<Word> _words = new List<Word>();

    private int wordshown = 0;
    

    public void HideRandomWords()
    {   

        wordshown = _words.Count();
        foreach(Word word in _words)
        {   
            
            if(word.IsHidden() == false)
            {
                
                Random randomgen2 = new Random();
                int pickword = randomgen2.Next(0,20);

                if (pickword >= 10)
                {

                    word.Hide();

                }
             
            }

            if(word.IsHidden() == true)
            {

                wordshown -= 1;

            }
        }
        
    }

    public string GetDisplayText()
    {

        string refText =  _reference.GetDisplayText();
        string verse = "";
        foreach (Word word in _words)

        {

            string newWord = word.GetDisplayText();
            verse = verse + newWord;

        }

        string fullScript = ($"{refText} - {verse}");
        return fullScript;

    }

    public bool IsCompletelyHidden()
    {

        if(wordshown == 0)
        {

            return true;

        }

        else
        {

            return false;

        }
        

    }

    public Scripture(Reference reference, string text)
    {
        _reference = reference;
        string[] words = text.Split();
        foreach(string word in words)
        {
            string word1 = ($"{word} ");
            Word word2 = new Word(word1);
            
            _words.Add(word2);
        }

    }
}