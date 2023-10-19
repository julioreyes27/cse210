using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Scripture
{
    // Attributes
    private Reference _reference;
    private List<Word> _scripture = new List<Word>();

    // Constructors
    public Scripture(Reference reference, string text)
    {
        _reference = reference;

        string[] words = text.Split(' ');

        foreach (string w in words)
        {
            Word word = new Word(w);

            _scripture.Add(word);
        }
    }

    // Methods
    public void DisplayScripture()
    {
        Console.WriteLine(_reference.GetRenderedReference());

        foreach (Word word in _scripture )
        {
            Console.Write(word.GetRenderedWord() + " ");
        }

        Console.WriteLine();
    }

    public void HideWords()
    {
        int number;
        
        for (int i = 0; i < 3; i++) 
        {
            while(true)
            {
                Random randomGenerator = new Random();
                number = randomGenerator.Next(0, _scripture.Count);

                Word word = _scripture[number];
                
                if (word.IsHidden() == false)
                {
                    word.Hide();
                    break;
                }
            }
        } 
    }

    public bool IsCompletelyHidden()
    {
        int count = 0;

        foreach (Word word in _scripture )
        {
            if (word.IsHidden() == true)
            {
                count++;
            }
        }

        if (count == _scripture.Count)
        {
            return true;
        }
        else
        {
            return false;
        }
    }
}
