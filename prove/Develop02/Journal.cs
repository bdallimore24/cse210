using System;
using System.IO;

public class Journal
{
    
    public List<Entry> entries = new List<Entry>();
    public void DisplayJournal ()
    {

        foreach (Entry entry in entries)
        {

            entry.DisplayEntry();
            Console.WriteLine(" ");
        }
    }
    
}