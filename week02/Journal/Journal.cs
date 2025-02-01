using System;
using System.Collections.Generic;
using System.IO;
using System.IO.Enumeration;
public class Journal
{
    public List<Entry> _entries;
    public void AddEntry(Entry newEntry)
    {
        
    }

    public void DisplayAll()
    {
        foreach (Entry entry in _entries)
        {
            entry.Display();
        }

        SaveToFile(_entries);
    }

    public void SaveToFile(List<Entry> _entries)
    {
        Console.WriteLine("Saving to file...");
        string file = "_entries.txt";
        using (StreamWriter outputfile = new StreamWriter(file))// Close and clean up the file when done (constructor)
        {
            foreach (Entry entry in _entries)
            {
                outputfile.WriteLine(entry._date);
                outputfile.WriteLine(entry._promptText);
                outputfile.WriteLine($"Answer: {entry._EntryText}");
                Console.WriteLine("");
            }
        }
    }

    public void loadFromFile(string file)
    {

    }




}